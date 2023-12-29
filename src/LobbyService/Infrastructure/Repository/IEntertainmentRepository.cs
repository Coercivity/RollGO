using Domain.Entities;

namespace Infrastructure.Repository
{
    public interface IEntertainmentRepository : IRepositoryBase<EntertainmentEntity>
    {
        public Task<EntertainmentEntity?> GetByKinopoiskId(int kinopoiskId);
    }
}
