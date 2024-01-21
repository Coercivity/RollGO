using Domain.Entities;

namespace Infrastructure.Repository.Implementation
{
    public class LobbySettingsRepository(LobbyDbContext context)
        : RepositoryBase<LobbySettings>(context),
            ILobbySettingsRepository
    { }
}
