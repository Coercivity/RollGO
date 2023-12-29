using Domain.Entities;

namespace Infrastructure.Repository.Implementation
{
    public class UserWeightRepository(LobbyDbContext context)
        : RepositoryBase<UserWeight>(context),
            IUserWeightRepository { }
}
