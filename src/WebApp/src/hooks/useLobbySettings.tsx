import { useState } from 'react';

export interface SettingsProps {
  numberOfSpins: number;
  rating: number;
  lobbyName: string;
}

export const useLobbySettings = (
  settings: SettingsProps
): [string, number, number, (t: string) => void, (t: number) => void, (t: number) => void] => {
  const [lobbyName, setLobbyName] = useState<string>(settings.lobbyName);
  const [numberOfSpins, setNumberOfSpins] = useState<number>(settings.numberOfSpins);
  const [rating, setRating] = useState<number>(settings.rating);

  return [lobbyName, numberOfSpins, rating, setLobbyName, setNumberOfSpins, setRating];
};
