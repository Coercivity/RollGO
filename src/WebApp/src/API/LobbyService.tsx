import axios from 'axios';

export default class LobbyService {
  static async getAllParticipant() {
    const response = await axios.get('_', {
      params: {},
    });
    return response;
  }
}
