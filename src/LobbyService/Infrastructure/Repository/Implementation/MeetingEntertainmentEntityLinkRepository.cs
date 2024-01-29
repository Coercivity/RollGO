using Domain.Entities;

namespace Infrastructure.Repository.Implementation;

public class MeetingEntertainmentEntityLinkRepository(LobbyDbContext context) : 
    RepositoryBase<MeetingEntertainmentEntityLink>(context),
    IMeetingEntertainmentEntityLinkRepository
{
}

