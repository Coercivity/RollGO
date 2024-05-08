export interface User {
  id: string;
  username: string;
  email?: string;
  isOnline: boolean;
  icon?: string;
  isAnonymous?: boolean;
}

export interface UserRequest {
  id: string;
  username: string;
  email?: string;
  password?: string;
  currentPassword?: string;
}
export interface Login {
  username?: string;
  email?: string;
  password: string;
}

export interface Register {
  email: string;
  username: string;
  password: string;
}

export interface TokenPair {
  accessToken: string;
  refreshToken: string;
}
