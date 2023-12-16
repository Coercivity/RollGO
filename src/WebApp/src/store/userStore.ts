import { create } from 'zustand';
import { persist } from 'zustand/middleware';

import { User } from '@models/User';

type UserStoreState = Omit<User, 'email'> & {
  setUser: (user: User) => void;
};

export const useUserStore = create(
  persist<UserStoreState>(
    (set) => ({
      isAnonymous: true,
      username: '',
      id: '',
      isOnline: true,
      setUser: (user) => {
        return set({ id: user.id, username: user.username, isOnline: true, isAnonymous: false });
      },
    }),
    {
      name: 'userInfo',
    }
  )
);
