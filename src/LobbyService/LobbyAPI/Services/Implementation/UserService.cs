using LobbyAPI.GrpcServices;
using static LobbyAPI.GrpcServices.User;

namespace LobbyAPI.Services.Implementation;

public class UserService(UserClient userClinet) : IUserService
{
    readonly UserClient _userClient = userClinet;

    public async Task<IEnumerable<Domain.Entities.User>> GetUsersByIds(IList<Guid> userIds)
    {
        IList<string> ids = userIds.Select(x => x.ToString()).ToList();
        UserByIdRequest userRequest = new() { UserIds = { ids } };

        var response = await _userClient.UsersByIdAsync(userRequest);

        var users = response.Users.ToList();

        return users.Select(
            x =>
                new Domain.Entities.User
                {
                    UserName = x.Username,
                    Id = Guid.Parse(x.UserId),
                    Icon = x.Icon
                }
        );
    }

    public async Task<Domain.Entities.User> GetUserById(Guid userId)
    {
        UserByIdRequest userRequest =
            new() { UserIds = { new List<string> { userId.ToString() } } };

        var response = await _userClient.UsersByIdAsync(userRequest);

        var user = response.Users.FirstOrDefault();

        return new Domain.Entities.User
        {
            UserName = user.Username,
            Id = Guid.Parse(user.UserId),
            Icon = user.Icon
        };
    }
}
