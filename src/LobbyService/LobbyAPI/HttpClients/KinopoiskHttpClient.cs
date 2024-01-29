using Domain.Entities;
using Newtonsoft.Json;

namespace LobbyAPI.HttpClients;

public class KinopoiskHttpClient(HttpClient httpClient)
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<Film?> GetFilmAttributes(int id)
    {
        var apiUrl = $"{_httpClient.BaseAddress}{id}";

        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var film = JsonConvert.DeserializeObject<Film>(json);
                return film;
            }
            else
            {
                throw new Exception($"Request failed with status code {response.StatusCode}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"HttpRequestException: {e.Message}");
        }
    }
}
