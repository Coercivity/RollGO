export interface LobbySettings {
  minimalRating: number;
  moviesPerUser: number;
  withKoefficient: boolean;
}

export interface Lobby {
  id: string;
  name: string;
  adminId: string;
  lobbySettings: LobbySettings;
}

export enum LobbyAction {
  JoinLobby = 'JoinLobby',
  JoinLobbyAnonymous = 'JoinLobbyAnonymous',
  Ready = 'Ready',
  StartRoll = 'StartRoll',
  StartRound = 'StartRound',
  AddMovie = 'AddMovie',
  RemoveMovie = 'RemoveMovie',
}

export enum LobbyEvent {
  Joined = 'Joined',
  UserJoined = 'UserJoined',
  UserLeft = 'UserLeft',
  MoviesChanged = 'MoviesChanged',
  RollStarted = 'RollStarted',
  RoundStarted = 'RoundStarted',
  RollFinished = 'RollFinished',
}
