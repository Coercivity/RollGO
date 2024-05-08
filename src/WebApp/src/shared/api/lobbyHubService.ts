import { HubConnectionBuilder, HubConnectionState } from '@microsoft/signalr';

class LobbyHubService {
  private token: string = '';

  private connection = new HubConnectionBuilder()
    .withUrl('/lobbyHub', {
      accessTokenFactory: () => this.token,
    })
    .withKeepAliveInterval(1000)
    .build();

  setToken(token: string) {
    this.token = token;
  }

  async startConnection(): Promise<void> {
    if (this.connection.state === HubConnectionState.Disconnected) {
      try {
        await this.connection.start();
      } catch (error) {
        console.error(error);
      }
    }
  }
}

export default new LobbyHubService();
