using Domain.Entities;

namespace Domain.Repositories;

public interface IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        public Task<TEntity> CreateAsync(TEntity entity);
        public Task<TEntity> UpdateAsync(TEntity entity);
        public Task<Guid?> DeleteAsync(Guid id);
        public Task<TEntity?> GetByIdAsync(Guid id);
        public IQueryable<TEntity> GetAll();
    }
