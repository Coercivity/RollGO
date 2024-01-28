using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Implementation
{
    public class LobbyRepository(LobbyDbContext context)
        : RepositoryBase<Lobby>(context),
            ILobbyRepository
    {

        public override async Task<Lobby?> GetByIdAsync(Guid id)
        {
            return await _context.Set<Lobby>().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
