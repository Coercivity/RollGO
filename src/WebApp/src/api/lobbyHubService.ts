import { HubConnectionBuilder, HubConnectionState } from '@microsoft/signalr';

enum LobbyAction {
  JoinLobby = 'JoinLobby',
  JoinLobbyAnonymous = 'JoinLobbyAnonymous',
}

class LobbyHubService {
  private connection = new HubConnectionBuilder()
    .withUrl('/lobbyHub')
    .withKeepAliveInterval(1000)
    .build();

  async startConnection(): Promise<void> {
    if (this.connection.state === HubConnectionState.Disconnected) {
      try {
        await this.connection.start();
      } catch (error) {
        console.error(error);
      }
    }
  }

  async stopConnection(): Promise<void> {
    if (this.connection.state === HubConnectionState.Connected) {
      try {
        await this.connection.stop();
      } catch (error) {
        console.error(error);
      }
    }
  }

  async joinLobby(lobbyId: string): Promise<void> {
    await this.startConnection();
    this.connection.invoke(LobbyAction.JoinLobby, lobbyId);
  }

  async joinLobbyAnonymous(lobbyId: string, username: string): Promise<void> {
    await this.startConnection();
    await this.connection.invoke(LobbyAction.JoinLobbyAnonymous, lobbyId, username);
  }
}

export default new LobbyHubService();
