using Domain.Repositories;
using Grpc.Core;

namespace UserAPI.GrpcServices.Services;
public class GrpcUserService(IUserRepository userRepository) : User.UserBase
{
    private readonly IUserRepository _userRepository = userRepository;
    public override async Task<UsersResponse> UsersById(UserByIdRequest request, ServerCallContext context)
    {
        List<Guid> userIds = [];
        foreach (var id in request.UserIds.ToList())
        {
            userIds.Append(Guid.Parse(id));
        }
        var users = await _userRepository.GetUsersByIds(userIds);
        var userResponses = users.Select(user => new UserResponse
            {
                UserId = user.Id.ToString(),
                Username = user.Username,
                Icon = user.Icon
            });
        var response = new UsersResponse();
        response.Users.Add(userResponses);
        return await Task.FromResult(response);
    }
}