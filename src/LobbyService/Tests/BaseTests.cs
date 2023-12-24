
using LobbyAPI.Services;
using System.Net.Http.Headers;

namespace Tests
{
    internal class BaseTests
    {
        protected LobbyDbContext _dbContext;
        protected LobbyRepository _lobbyRepository;
        protected KinopoiskDataClient _kinopoiskDataClient;
        protected List<User> users = [];
        
        [SetUp]
        public void Setup()
        {
            // Set up the in-memory database and repository
            var serviceProvider = new ServiceCollection()
                .AddDbContext<LobbyDbContext>(options =>
                    options
                    .UseInMemoryDatabase(databaseName: "InMemoryDatabase"))
                    //.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=test123123;"))
                .BuildServiceProvider();

            _dbContext = serviceProvider.GetRequiredService<LobbyDbContext>();
            _lobbyRepository = new LobbyRepository(_dbContext);

            var client = new HttpClient
            {
                BaseAddress = new Uri("https://kinopoiskapiunofficial.tech/api/v2.2/films/")
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-API-KEY", "");

            _kinopoiskDataClient = new KinopoiskDataClient(client);

            SeedData();
        }

        private void SeedData()
        {
            List<Meeting> meetings = [];
            List<UserWeight> usersWeights = [];
            List<Lobby> lobbies = [];
            List<LobbyUser> lobbyUsers = [];

            RealNameGenerator nameGenerator = new();
            GamerTagGenerator tagGenerator = new();

            for (int i = 0; i < 10; i++)
            {
                var user = new User { UserName = nameGenerator.Generate() };
                var lobby = new Lobby { Name = tagGenerator.Generate(), AdminId = user.Id };
                users.Add(user);
                lobbies.Add(lobby);

                lobbyUsers.Add(new LobbyUser { Lobby =  lobby, UserId = user.Id });
                usersWeights.Add(new UserWeight { UserId = user.Id, Lobby = lobby });
            }
            _dbContext.Lobbies.AddRange(lobbies);
            _dbContext.UsersWeights.AddRange(usersWeights);
            _dbContext.LobbyUsers.AddRange(lobbyUsers);
            _dbContext.SaveChanges();


            foreach (var lobby in lobbies)
                meetings.Add(new Meeting { IsActive = true, Lobby = lobby });

            _dbContext.Meetings.AddRange(meetings);
            _dbContext.SaveChanges();

            SeedFilms();
        }

        private void SeedFilms()
        {
            List<Film> films = [];

            for (int i = 300; i < 310; i++)
            {
                var film = _kinopoiskDataClient.GetFilmAttributes(i).Result;
                if (film is not null) 
                { 
                    films.Add(film);
                }
            }

            _dbContext.Films.AddRange(films);
            _dbContext.SaveChanges();
        }

        [TearDown]
        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
