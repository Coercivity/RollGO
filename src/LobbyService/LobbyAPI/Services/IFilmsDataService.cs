using Domain.Entities;

namespace LobbyAPI.Services
{
    public interface IFilmsDataService
    {
        public Task<Film> GetFilm(int filmId);

    }
}