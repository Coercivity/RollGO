import { useState } from 'react';

import { LobbySettings } from '@models/Lobby';

export type SettingsProps = LobbySettings & {
  lobbyName: string;
};

export const useLobbySettings = (
  settings: SettingsProps
): [
  string,
  number,
  number,
  boolean,
  (t: string) => void,
  (t: number) => void,
  (t: number) => void,
  (t: boolean) => void,
] => {
  const [lobbyName, setLobbyName] = useState<string>(settings.lobbyName);
  const [moviesPerUser, setMoviesPerUser] = useState<number>(settings.moviesPerUser);
  const [rating, setRating] = useState<number>(settings.minimalRating);
  const [withKoefficient, setWithKoefficient] = useState<boolean>(settings.withKoefficient);

  return [
    lobbyName,
    moviesPerUser,
    rating,
    withKoefficient,
    setLobbyName,
    setMoviesPerUser,
    setRating,
    setWithKoefficient,
  ];
};
