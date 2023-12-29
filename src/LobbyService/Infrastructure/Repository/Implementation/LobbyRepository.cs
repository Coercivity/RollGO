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

        public async Task DeleteAsync(Guid id)
        {
            Lobby lobby = await GetByIdAsync(id);
            await DeleteAsync(lobby);
        }

        public IQueryable<Lobby> GetAll()
        {
            return _context.Lobbies.AsQueryable();
        }

        public async Task<Lobby?> GetByIdAsync(Guid id)
        {
            return await _context.Lobbies?.FirstOrDefaultAsync(x => x.Id == id)!;
        }

        public IQueryable<Lobby> SearchByName(string searchName)
        {
            return _context
                .Lobbies.Where(x => x.Name.ToLower().Contains(searchName.ToLower()))
                .AsQueryable();
        }

        public async Task<Lobby> UpdateAsync(Lobby entity)
        {
            _context.Lobbies.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
