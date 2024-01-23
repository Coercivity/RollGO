import axios from 'axios';

import { Lobby, LobbySettings } from '@models/Lobby';

class LobbyService {
  async createLobby(name: string, lobbySettings: LobbySettings): Promise<Lobby> {
    return axios.post<Lobby, Lobby>('/api/lobbies', { name, settings: lobbySettings });
  }

  async getLobby(id: string): Promise<Lobby> {
    return axios.get(`/api/lobbies/${id}`);
  }

  async getLobbies(): Promise<Lobby[]> {
    return axios.get('/api/lobbies');
  }

  async removeLobby(id: string): Promise<string> {
    return axios.delete(`/api/lobbies/${id}`);
  }

  async updateLobby(lobby: Lobby): Promise<Lobby> {
    return axios.put<Lobby, Lobby>(`/api/lobbies/${lobby.id}`, {
      name: lobby.name,
      settings: lobby.lobbySettings,
    });
  }
}

export default new LobbyService();
