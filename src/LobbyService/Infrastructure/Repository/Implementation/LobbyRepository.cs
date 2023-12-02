using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Implementation
{
    public class LobbyRepository(LobbyDbContext context) : ILobbyRepository
    {
        private LobbyDbContext _context { get; set; } = context;

        public async Task<Lobby> CreateAsync(Lobby entity)
        {
            await _context.Lobbies.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(Lobby entity)
        {
            _context.Lobbies.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Lobby> GetAll()
        {
           return _context.Lobbies.AsQueryable();
        }

        public async Task<Lobby?> GetByIdAsync(Guid id)
        {
            return await _context.Lobbies?.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Lobby> UpdateAsync(Lobby entity)
        {
            _context.Lobbies.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
