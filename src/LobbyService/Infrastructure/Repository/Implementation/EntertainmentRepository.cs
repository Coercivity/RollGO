using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Implementation
{
    public class EntertainmentRepository(LobbyDbContext context)
        : RepositoryBase<EntertainmentEntity>(context),
            IEntertainmentRepository
    {
        public async Task<EntertainmentEntity?> GetByKinopoikId(int kinopoikId) =>
            await _context.EntertainmentEntities.FirstOrDefaultAsync(
                x => x.KinopoiskId == kinopoikId
            );
    }
}
