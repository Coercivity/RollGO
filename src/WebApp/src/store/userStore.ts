import { create } from 'zustand';

import { User } from '@models/User';

interface UserStoreState {
  user: User;
  setUser: (user: User) => void;
}

export const useUserStore = create<UserStoreState>((set) => ({
  user: { username: 'Anonymous', isOnline: true, isAnonymous: true },
  setUser: (user) => set({ user }),
}));
