using Domain.Entities;
using Infrastructure.Repository;
using LobbyAPI.HttpClients;

namespace LobbyAPI.Services.Implementation;

public class FilmsDataService(
    KinopoiskHttpClient kinopoiskHttpClient,
    IEntertainmentRepository filmsRepository
) : IFilmsDataService
{
    private readonly KinopoiskHttpClient _kinopoiskHttpClient = kinopoiskHttpClient;
    private readonly IEntertainmentRepository _filmsRepository = filmsRepository;

    public async Task<EntertainmentEntity?> GetFilm(int filmId)
    {
        var film = await TryRecieveFromNative(filmId);
        if (film is not null)
            return film;

        film = await _kinopoiskHttpClient.GetFilmAttributes(filmId);

        await SaveToNative(film);

        return film;
    }

    private async Task<EntertainmentEntity?> TryRecieveFromNative(int filmId) =>
        await _filmsRepository.GetByKinopoiskId(filmId);

    private async Task<EntertainmentEntity?> SaveToNative(EntertainmentEntity entertainmentEntity) =>
        await _filmsRepository.CreateAsync(entertainmentEntity);
}
