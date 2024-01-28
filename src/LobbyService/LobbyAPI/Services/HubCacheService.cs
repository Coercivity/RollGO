using LobbyAPI.Hubs.Models;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace LobbyAPI.Services;

public class HubCacheService(IDistributedCache cache)
{
    private readonly IDistributedCache _cache = cache ?? throw new ArgumentNullException(nameof(cache));

    public async Task<ActiveMeeting> GetActiveMeetingAsync(Guid meetingId, CancellationToken cancellationToken)
    {
        var cachedMeetings = await _cache.GetStringAsync("ActiveMeetings", cancellationToken);
        if (cachedMeetings != null)
        {
            var meetingsDictionary = JsonConvert.DeserializeObject<Dictionary<Guid, ActiveMeeting>>(cachedMeetings);
            if (meetingsDictionary.TryGetValue(meetingId, out var activeMeeting))
            {
                return activeMeeting;
            }
        }
        return null;
    }

    public async Task SetActiveMeetingAsync(ActiveMeeting activeMeeting, CancellationToken cancellationToken)
    {
        var cachedMeetings = await _cache.GetStringAsync("ActiveMeetings", cancellationToken);
        var meetingsDictionary = cachedMeetings != null
            ? JsonConvert.DeserializeObject<Dictionary<Guid, ActiveMeeting>>(cachedMeetings)
            : new Dictionary<Guid, ActiveMeeting>();

        // Update or add the specific meeting in the dictionary
        meetingsDictionary[activeMeeting.Meeting.Id] = activeMeeting;

        var serializedMeetings = JsonConvert.SerializeObject(meetingsDictionary);
        await _cache.SetStringAsync("ActiveMeetings", serializedMeetings, cancellationToken);
    }
}
