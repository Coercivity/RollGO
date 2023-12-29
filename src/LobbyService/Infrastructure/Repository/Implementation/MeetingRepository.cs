using Domain.Entities;

namespace Infrastructure.Repository.Implementation
{
    public class MeetingRepository(LobbyDbContext context)
        : RepositoryBase<Meeting>(context),
            IMeetingRepository { }
}
