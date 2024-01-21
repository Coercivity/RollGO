import { create } from 'zustand';
import { persist } from 'zustand/middleware';

import { User } from '@models/User';

type UserStoreState = User & {
  setUser: (user: User) => void;
  setAnonymous: () => void;
};

export const useUserStore = create(
  persist<UserStoreState>(
    (set) => ({
      isAnonymous: true,
      username: 'Anon',
      id: '',
      isOnline: true,
      email: '',
      setUser: (user) => {
        return set({
          id: user.id,
          username: user.username,
          email: user.email,
          isOnline: true,
          isAnonymous: user.isAnonymous,
        });
      },
      setAnonymous: () => {
        return set({
          id: '',
          username: 'Anon',
          email: '',
          isOnline: true,
          isAnonymous: true,
        });
      },
    }),
    {
      name: 'userInfo',
    }
  )
);
