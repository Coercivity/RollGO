using Domain.Entities;
using Infrastructure.Repository;

namespace LobbyAPI.Services
{
    public class FilmsDataService(
        KinopoiskDataClient dataClient,
        IEntertainmentRepository filmsRepository
    ) : IFilmsDataService
    {
        private readonly KinopoiskDataClient _dataClient = dataClient;
        private readonly IEntertainmentRepository _filmsRepository = filmsRepository;

        public async Task<EntertainmentEntity?> GetFilm(int filmId)
        {
            var film = await TryRecieveFromNative(filmId);
            if (film is not null)
                return film;

            return await _dataClient.GetFilmAttributes(filmId);
        }

        private async Task<EntertainmentEntity?> TryRecieveFromNative(int filmId) =>
            await _filmsRepository.GetByKinopoikId(filmId);
    }
}
