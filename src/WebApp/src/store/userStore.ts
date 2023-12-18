import { create } from 'zustand';
import { persist } from 'zustand/middleware';

import { User } from '@models/User';

type UserStoreState = Omit<User, 'email'> & {
  setUser: (user: User, isAnonymous: boolean) => void;
};

export const useUserStore = create(
  persist<UserStoreState>(
    (set) => ({
      isAnonymous: true,
      username: 'Anon',
      id: '',
      isOnline: true,
      setUser: (user, isAnonymous = false) => {
        return set({ id: user.id, username: user.username, isOnline: true, isAnonymous });
      },
    }),
    {
      name: 'userInfo',
    }
  )
);
