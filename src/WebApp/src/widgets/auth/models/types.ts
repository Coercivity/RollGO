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
