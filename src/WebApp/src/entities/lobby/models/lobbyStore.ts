import { create } from 'zustand';

import { Lobby } from '@entities/lobby';
import { lobbyService } from '../api';
import { CreateLobbyRequest } from '../models';

interface State {
  lobbies: Lobby[];
  lobby?: Lobby;
}

interface Actions {
  fetchLobbies: () => Promise<void>;
  fetchLobby: (id: string) => Promise<void>;
  createLobby: (lobby: CreateLobbyRequest) => Promise<void>;
  updateLobby: (lobby: Lobby) => Promise<void>;
  removeLobby: (id: string) => Promise<void>;
}

const initialState: State = {
  lobbies: [],
};

export const useLobbyStore = create<State & Actions>((set, get) => ({
  ...initialState,
  fetchLobbies: async () => {
    const lobbies = await lobbyService.getLobbies();
    set({ lobbies });
  },
  fetchLobby: async (id) => {
    const lobby = await lobbyService.getLobby(id);
    set({ lobby });
  },
  createLobby: async (data) => {
    const lobby = await lobbyService.createLobby(data);
    set((state) => ({ lobby, lobbies: [lobby, ...state.lobbies] }));
  },
  updateLobby: async (lobby) => {
    const updatedLobby = await lobbyService.updateLobby(lobby);
    const lobbyIndex = get().lobbies.findIndex((item) => item.id === lobby.id);
    const lobbies = get().lobbies.splice(lobbyIndex, 1, updatedLobby);
    set({ lobby: updatedLobby, lobbies });
  },
  removeLobby: async (id) => {
    await lobbyService.removeLobby(id);
    set((state) => ({ lobbies: state.lobbies.filter((item) => item.id !== id) }));
  },
}));
