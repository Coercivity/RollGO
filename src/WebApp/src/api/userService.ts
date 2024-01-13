import axios from 'axios';

import { User, UserRequest } from '@models/User';

class UserService {
  update(data: UserRequest): Promise<User> {
    return axios.put<UserRequest, User>('api/user', data);
  }
}

export const userService = new UserService();
