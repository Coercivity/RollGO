namespace Domain.Entities
{
    public class Context
    {
        public int UserCount { get; set; }
        public IList<UserSession>? UserSessions { get; set; }
    }
}
