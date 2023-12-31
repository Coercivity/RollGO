﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Implementation
{
    public class EntertainmentRepository(LobbyDbContext context)
        : RepositoryBase<EntertainmentEntity>(context),
            IEntertainmentRepository
    {
        public async Task<EntertainmentEntity?> GetByKinopoiskId(int kinopoiskId) =>
            await _context.EntertainmentEntities.FirstOrDefaultAsync(
                x => x.KinopoiskId == kinopoiskId
            );
    }
}
