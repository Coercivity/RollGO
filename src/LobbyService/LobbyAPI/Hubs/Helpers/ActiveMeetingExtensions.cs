using Domain.Entities;
using LobbyAPI.Hubs.Models;

namespace LobbyAPI.Hubs.Helpers;

internal static class ActiveMeetingExtensions
{
    public static void AddOrUpdateEntertainmentEntities(this ActiveMeeting activeMeeting, User user, EntertainmentEntity entertainmentEntity)
    {
        if (activeMeeting.AddedEntertainmentEntities.TryGetValue(user, out var list))
        {
            list.Add(entertainmentEntity);
        }
        else
        {
            activeMeeting.AddedEntertainmentEntities.TryAdd(user, [entertainmentEntity]);
        }
    }

    public static void RemoveEntertainmentEntity(this ActiveMeeting activeMeeting, User user, int entertainmentEntityId)
    {
        if (activeMeeting.AddedEntertainmentEntities.TryGetValue(user, out var list))
        {
            var entityToRemove = list.FirstOrDefault(e => e.KinopoiskId == entertainmentEntityId);
            if (entityToRemove != null)
            {
                list.Remove(entityToRemove);
            }
        }
    }

    public static List<UserWithEntity> GetEntertainmentEntitiesWithUserList(this ActiveMeeting activeMeeting)
    {
        return activeMeeting.AddedEntertainmentEntities
            .SelectMany(kv => kv.Value.Select(entity => new UserWithEntity
            {
                User = kv.Key,
                EntertainmentEntity = entity
            }))
            .ToList();
    }
}
