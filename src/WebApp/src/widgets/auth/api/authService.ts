import axios from 'axios';

import { User } from '@entities/user';

import { Login, Register, TokenPair } from '../models/types';

interface LoginResponse {
  user: User;
  accessToken: string;
  refreshToken: string;
}

class AuthService {
  login(data: Login): Promise<LoginResponse> {
    return axios.post<Login, LoginResponse>('/api/auth/login', data);
  }

  register(data: Register): Promise<LoginResponse> {
    return axios.post<Register, LoginResponse>('/api/auth/register', data);
  }

  refreshToken(data: TokenPair): Promise<TokenPair> {
    return axios.post<TokenPair, TokenPair>('/api/auth/refreshToken', data);
  }
}

export const authService = new AuthService();
