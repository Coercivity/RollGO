import { useState } from 'react';

import { Lobby } from '@models/Lobby';

export type SettingsProps = Omit<Lobby, 'id' | 'adminId'>;

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
  const [name, setName] = useState<string>(settings.name);
  const [moviesPerUser, setMoviesPerUser] = useState<number>(settings.moviesPerUser);
  const [rating, setRating] = useState<number>(settings.minimalRating);
  const [withCoefficient, setWithCoefficient] = useState<boolean>(settings.withCoefficient);

  return [
    name,
    moviesPerUser,
    rating,
    withCoefficient,
    setName,
    setMoviesPerUser,
    setRating,
    setWithCoefficient,
  ];
};
