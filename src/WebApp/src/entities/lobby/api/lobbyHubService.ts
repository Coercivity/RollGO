import { HubConnectionBuilder, HubConnectionState } from '@microsoft/signalr';
import { LobbyActionType, LobbyEventType } from '../models';

class LobbyHubService {
  private token: string = '';

  private unauthorizedCallback: () => void = () => {
    throw new Error('SignalR authorization is not handled');
  };

  private connection = new HubConnectionBuilder()
    .withUrl('/lobbyHub', {
      accessTokenFactory: () => this.token,
    })
    .withKeepAliveInterval(1000)
    .build();

  setToken(token: string) {
    this.token = token;
  }

  setUnauthorizedCallback(cb: () => void) {
    this.unauthorizedCallback = cb;
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

  async sendMessage(method: LobbyActionType, ...params: unknown[]) {
    try {
      await this.connection.invoke(method, ...params);
    } catch (error) {
      console.error(error);
      // TODO: add check for error to be 401
      if (error) {
        this.unauthorizedCallback();
      }
    }
  }

  onMessageReceive(event: LobbyEventType, cb: (...params: unknown[]) => void) {
    this.connection.on(event, cb);
  }
}

export default new LobbyHubService();
