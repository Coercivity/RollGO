import { HubConnectionBuilder, HubConnectionState } from '@microsoft/signalr';

import { Movie } from '@entities/movie';

import { LobbyAction, LobbyEvent } from '../models/types';

class LobbyHubService {
  private token: string = '';

  private lobbyId: string = '';

  private connection = new HubConnectionBuilder()
    .withUrl('/lobbyHub', {
      accessTokenFactory: () => this.token,
    })
    .withKeepAliveInterval(1000)
    .build();

  setToken(token: string) {
    this.token = token;
  }

  setLobbyId(lobbyId: string) {
    this.lobbyId = lobbyId;
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
    this.lobbyId = lobbyId;
    await this.startConnection();
    return this.connection.invoke(LobbyAction.JoinLobby, lobbyId);
  }

  async joinLobbyAnonymous(lobbyId: string, username: string): Promise<void> {
    this.lobbyId = lobbyId;
    await this.startConnection();
    return this.connection.invoke(LobbyAction.JoinLobbyAnonymous, lobbyId, username);
  }

  async ready(isReady: boolean): Promise<void> {
    return this.connection.invoke(LobbyAction.Ready, isReady);
  }

  async startRoll(): Promise<void> {
    return this.connection.invoke(LobbyAction.StartRoll);
  }

  async startRound(): Promise<void> {
    return this.connection.invoke(LobbyAction.StartRound);
  }

  async addMovie(movieId: number): Promise<void> {
    return this.connection.invoke(LobbyAction.AddMovie, this.lobbyId, movieId);
  }

  async removeMovie(movieId: string): Promise<void> {
    return this.connection.invoke(LobbyAction.RemoveMovie, movieId);
  }

  async joined(cb: (users: string[], movies: string[]) => void): Promise<void> {
    // TODO: add settings, round movies
    this.connection.on(LobbyEvent.Joined, cb);
  }

  async userJoined(cb: (user: string, users: string[]) => void): Promise<void> {
    this.connection.on(LobbyEvent.UserJoined, cb);
  }

  async userLeft(cb: (user: string, users: string[]) => void): Promise<void> {
    this.connection.on(LobbyEvent.UserLeft, cb);
  }

  async moviesChanged(cb: (movies: Movie[]) => void): Promise<void> {
    this.connection.on(LobbyEvent.MoviesChanged, cb);
  }

  async rollStarted(cb: () => void): Promise<void> {
    this.connection.on(LobbyEvent.RollStarted, cb);
  }

  async roundStarted(cb: (movies: string) => void): Promise<void> {
    this.connection.on(LobbyEvent.RoundStarted, cb);
  }

  async rollFinished(cb: (winner: string) => void): Promise<void> {
    this.connection.on(LobbyEvent.RollFinished, cb);
  }
}

export default new LobbyHubService();
