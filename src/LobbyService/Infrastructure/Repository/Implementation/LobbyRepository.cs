using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Implementation
{
    public class LobbyRepository(LobbyDbContext context)
        : RepositoryBase<Lobby>(context),
            ILobbyRepository
    {
        public IQueryable<Lobby> SearchByName(string searchName) =>
            GetAll(x => x.Name.ToLower().Contains(searchName.ToLower()));

        public override async Task<Lobby?> GetByIdAsync(Guid id)
        {
            return await _context.Set<Lobby>().Include(x => x.LobbySettings).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
