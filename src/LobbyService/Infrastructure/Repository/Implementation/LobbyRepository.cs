using Domain.Entities;

namespace Infrastructure.Repository.Implementation
{
    public class LobbyRepository(LobbyDbContext context)
        : RepositoryBase<Lobby>(context),
            ILobbyRepository
    {
        public IQueryable<Lobby> SearchByName(string searchName)
        {
            return _context
                .Lobbies.Where(x => x.Name.ToLower().Contains(searchName.ToLower()))
                .AsQueryable();
        }
    }
}
