import axios from 'axios';

import { User, UserRequest } from '../models/types';

class UserService {
  update(data: UserRequest): Promise<User> {
    return axios.put<UserRequest, User>('/api/user', data);
  }

  get(id: string): Promise<User> {
    return axios.get<User, User>(`/api/user/${id}`);
  }
}

export const userService = new UserService();
