import axios from 'axios';

import { Lobby } from '@models/Lobby';

type CreateLobbyRequest = Omit<Lobby, 'id' | 'adminId'>;

class LobbyService {
  async createLobby(data: CreateLobbyRequest): Promise<Lobby> {
    return axios.post<Lobby, Lobby>('/api/lobbies', data);
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
      minimalRating: lobby.minimalRating,
      moviesPerUser: lobby.moviesPerUser,
      withCoefficient: lobby.withCoefficient,
    } as CreateLobbyRequest);
  }
}

export default new LobbyService();
