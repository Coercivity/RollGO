using Domain.Entities;

namespace LobbyAPI.Services
{
    public class LobbyUser(User user)
    {
        private readonly HashSet<LobbyConnection> _connections = [];

        public User User { get; } = user ?? throw new ArgumentNullException(nameof(user));

        public IEnumerable<LobbyConnection> Connections => _connections;

        public void AddConnection(string connectionId)
        {
            ArgumentNullException.ThrowIfNull(connectionId);

            var connection = new LobbyConnection
            {
                ConnectionId = connectionId
            };

            _connections.Add(connection);
        }


        public void RemoveConnection(string connectionId)
        {
            ArgumentNullException.ThrowIfNull(connectionId);

            var connection = _connections.SingleOrDefault(x => x.ConnectionId.Equals(connectionId));

            if (connection == null)
            {
                return;
            }

            _connections.Remove(connection);
        }

        public record LobbyConnection
        {
            public required string ConnectionId { get; set; }
            public DateTime ConnectedAt { get; set; } = DateTime.UtcNow;
        }
    }
}