import axios from 'axios';

import { Login } from '@models/Login';
import { Register } from '@models/Register';
import { TokenPair } from '@models/TokenPair';
import { User } from '@models/User';

interface LoginResponse {
  user: User;
  accessToken: string;
  refreshToken: string;
}

class AuthService {
  login(data: Login): Promise<LoginResponse> {
    return axios.post<Login, LoginResponse>('api/auth/login', data);
  }

  register(data: Register): Promise<LoginResponse> {
    return axios.post<Register, LoginResponse>('api/auth/register', data);
  }

  refreshToken(data: TokenPair): Promise<TokenPair> {
    return axios.post<TokenPair, TokenPair>('api/auth/refreshToken', data);
  }
}

export const authService = new AuthService();
