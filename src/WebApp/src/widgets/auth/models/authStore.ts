import { TokenPair } from '@models/TokenPair';
import { create } from 'zustand';
import { persist } from 'zustand/middleware';

type AuthStoreState = TokenPair & {
  isAuthorized: boolean;
  setTokenPair: (pair: TokenPair) => void;
};

export const useAuthStore = create(
  persist<AuthStoreState>(
    (set) => ({
      accessToken: '',
      refreshToken: '',
      isAuthorized: false,
      setTokenPair: (pair) => set({ ...pair, isAuthorized: pair.accessToken !== '' }),
    }),
    {
      name: 'tokens',
    }
  )
);
