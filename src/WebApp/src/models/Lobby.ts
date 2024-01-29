export interface Lobby {
  id: string;
  name: string;
  adminId: string;
  minimalRating: number;
  moviesPerUser: number;
  withCoefficient: boolean;
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
