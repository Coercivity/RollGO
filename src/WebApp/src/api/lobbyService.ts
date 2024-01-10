import axios from 'axios';

import { Lobby } from '@models/Lobby';

class LobbyService {
  async createLobby(name: string): Promise<Lobby> {
    return axios.post<Lobby, Lobby>('/api/lobbies', { name });
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
}

export default new LobbyService();
