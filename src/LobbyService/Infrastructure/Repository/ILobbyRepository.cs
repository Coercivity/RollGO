using Domain.Entities;
using System.Collections;

namespace Infrastructure.Repository
{
    public interface ILobbyRepository : IRepositoryBase<Lobby>
    {
        public IQueryable<Lobby> SearchByName(string name);
    }
}
