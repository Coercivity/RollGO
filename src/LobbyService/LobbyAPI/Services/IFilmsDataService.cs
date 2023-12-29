using Domain.Entities;

namespace LobbyAPI.Services
{
    public interface IFilmsDataService
    {
        public Task<EntertainmentEntity?> GetFilm(int filmId);
    }
}
