using Domain.Entities;

namespace Infrastructure.Repository
{
    public interface ILobbyRepository : IRepositoryBase<Lobby>
    {
        public IQueryable<Lobby> SearchByName(string name);
    }
}
