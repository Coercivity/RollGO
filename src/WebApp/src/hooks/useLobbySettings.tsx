import { useState } from 'react';

export interface SettingsProps {
  spinCount: number;
  rating: number;
  lobbyName: string;
}

export const useLobbySettings = (
  settings: SettingsProps
): [string, number, number, (t: string) => void, (t: number) => void, (t: number) => void] => {
  const [lobbyName, setLobbyName] = useState<string>(settings.lobbyName);
  const [spinCount, setSpinCount] = useState<number>(settings.spinCount);
  const [rating, setRating] = useState<number>(settings.rating);

  return [lobbyName, spinCount, rating, setLobbyName, setSpinCount, setRating];
};
