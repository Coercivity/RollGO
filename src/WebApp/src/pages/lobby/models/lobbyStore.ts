import { create } from 'zustand';

import { Movie } from '@entities/movie';
import { User } from '@entities/user';

interface LobbyStoreState {
  users: User[];
  movies: Movie[];
  addUser: (user: User) => void;
  removeUser: (userId: string) => void;
  addMovie: (movie: Movie) => void;
  removeMovie: (movieId: number) => void;
  getRemovedMovies: () => Movie[];
  leaveLobby: () => void;
  joinLobby: (users: User[], movies: Movie[]) => void;
  setMovies: (movies: Movie[]) => void;
}

export const useLobbyStore = create<LobbyStoreState>((set, get) => ({
  users: [],
  movies: [],
  addUser: (user) => {
    set((state) => ({ users: [...state.users, user] }));
  },
  removeUser: (userId) => {
    set((state) => ({ users: state.users.filter((u) => u.id !== userId) }));
  },
  addMovie: (movie) => {
    set((state) => {
      const removedMovie = state.movies.find((m) => m.kinopoiskId === movie.kinopoiskId);
      if (removedMovie) {
        removedMovie.isRemoved = false;
        return state;
      }
      return {
        movies: [...state.movies, movie],
      };
    });
  },
  removeMovie: (movieId) => {
    set((state) => ({
      movies: state.movies.map((m) => ({ ...m, isRemoved: m.kinopoiskId === movieId })),
    }));
  },
  getRemovedMovies: (): Movie[] => {
    return get().movies.filter((m) => m.isRemoved);
  },
  joinLobby(users, movies) {
    set((state) => {
      state.setMovies(movies);
      return { users };
    });
  },
  leaveLobby: () => {
    set((state) => ({ users: [], movies: state.movies.map((m) => ({ ...m, isRemoved: true })) }));
  },
  setMovies: (movies) => {
    set((state) => {
      const movieIds = state.movies.map((m) => m.kinopoiskId);
      const additionalMovies = movies.filter((m) => !movieIds.includes(m.kinopoiskId));
      const updatedMovies = [
        ...state.movies.map((m) => ({ ...m, isRemoved: !movieIds.includes(m.kinopoiskId) })),
        ...additionalMovies,
      ];
      return { movies: updatedMovies };
    });
  },
}));
