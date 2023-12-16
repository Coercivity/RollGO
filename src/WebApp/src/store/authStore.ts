import { create } from 'zustand';
import { persist } from 'zustand/middleware';

import { TokenPair } from '@api/authService';

type AuthStoreState = TokenPair & {
  setTokenPair: (pair: TokenPair) => void;
  isAuthorized: boolean;
};

export const useAuthStore = create(
  persist<AuthStoreState>(
    (set, get) => ({
      accessToken: '',
      refreshToken: '',
      setTokenPair: (pair) => set({ ...pair }),
      isAuthorized: !!get()?.accessToken,
    }),
    {
      name: 'tokens',
    }
  )
);
