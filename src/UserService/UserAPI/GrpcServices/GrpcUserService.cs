using Domain.Repositories;
using Grpc.Core;

namespace UserAPI.GrpcServices;
public class UserService(IUserRepository userRepository) : User.UserBase
{
    private readonly IUserRepository _userRepository = userRepository;
    public override async Task<UsersResponse> UsersById(UserByIdRequest request, ServerCallContext context)
    {
        List<Guid> userIds = request.UserIds.Select(id => Guid.Parse(id)).ToList();

        var users = await _userRepository.GetUsersByIds(userIds);

        var userResponses = users.Select(user => new UserResponse
        {
            UserId = user.Id.ToString(),
            Username = user.Username,
            Icon = user.Icon ?? ""
        });

        var response = new UsersResponse();
        response.Users.AddRange(userResponses);

        return response;
    }
}