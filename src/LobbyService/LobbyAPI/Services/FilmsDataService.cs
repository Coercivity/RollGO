using Domain.Entities;

namespace LobbyAPI.Services
{
    public class FilmsDataService(KinopoiskDataClient dataClient, IConfiguration configuration)
        : IFilmsDataService
    {
        private readonly KinopoiskDataClient _dataClient = dataClient;
        private readonly IConfiguration _configuration = configuration;

        public async Task<Film> GetFilm(int filmId)
        {
            //if (_configuration.Get([])) take data from external/internal api condition
            return await _dataClient.GetFilmAttributes(filmId);
        }
    }
}
