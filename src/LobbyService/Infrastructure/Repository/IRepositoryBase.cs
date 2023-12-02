using Domain.Entities;

namespace Infrastructure.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        public Task<TEntity> CreateAsync(TEntity entity);
        public Task<TEntity> UpdateAsync(TEntity entity);
        public Task DeleteAsync(TEntity entity);
        public Task<TEntity?> GetByIdAsync(Guid id);
        public IQueryable<TEntity> GetAll();
    }
}
