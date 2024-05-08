import { useState } from 'react';

import { Lobby } from '..';

export type SettingsProps = Partial<Omit<Lobby, 'id' | 'adminId'>>;

const INITIAL_SETTINGS = {
  moviesPerUser: 1,
  minimalRating: 5,
  name: '',
  withCoefficient: true,
};
export const useLobbySettings = (
  settings?: SettingsProps
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
  const [name, setName] = useState<string>(settings?.name ?? INITIAL_SETTINGS.name);
  const [moviesPerUser, setMoviesPerUser] = useState<number>(
    settings?.moviesPerUser ?? INITIAL_SETTINGS.moviesPerUser
  );
  const [rating, setRating] = useState<number>(
    settings?.minimalRating ?? INITIAL_SETTINGS.minimalRating
  );
  const [withCoefficient, setWithCoefficient] = useState<boolean>(
    settings?.withCoefficient ?? INITIAL_SETTINGS.withCoefficient
  );

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
