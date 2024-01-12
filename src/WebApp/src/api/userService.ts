import axios from 'axios';

import { User } from '@models/User';

class UserService {
  settingsChange(data: User): Promise<User> {
    return axios.put<User, User>('api/user', data);
  }
}

export const userService = new UserService();
