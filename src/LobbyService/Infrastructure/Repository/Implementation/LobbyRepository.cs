using Domain.Entities;

namespace Infrastructure.Repository.Implementation
{
    public class LobbyRepository(LobbyDbContext context)
        : RepositoryBase<Lobby>(context),
            ILobbyRepository
    {
        public IQueryable<Lobby> SearchByName(string searchName) =>
            GetAll(x => x.Name.ToLower().Contains(searchName.ToLower()));
    }
}
