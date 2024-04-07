import { create } from 'zustand';

import { Lobby } from '@entities/lobby';
import { Movie } from '@entities/movie';
import { User } from '@entities/user';
import { lobbyService } from '../api';
import { CreateLobbyRequest } from '../models';

interface LobbyStoreState {
  lobby?: Lobby;
  users: User[];
  movies: Movie[];

  fetchLobby: (id: string) => Promise<void>;
  createLobby: (lobby: CreateLobbyRequest) => Promise<void>;
  updateLobby: (lobby: Lobby) => Promise<void>;
  setLobby: (lobby: Lobby) => void;

  addUser: (user: User) => void;
  removeUser: (userId: string) => void;

  addMovie: (movie: Movie) => void;
  setMovies: (movies: Movie[]) => void;
  removeMovie: (movieId: number) => void;
  getRemovedMovies: () => Movie[];

  leaveLobby: () => void;
  joinLobby: (users: User[], movies: Movie[]) => void;
}

export const useLobbyStore = create<LobbyStoreState>((set, get) => ({
  users: [],
  movies: [],
  fetchLobby: async (id) => {
    const lobby = await lobbyService.getLobby(id);
    get().setLobby(lobby);
  },
  createLobby: async (data) => {
    const lobby = await lobbyService.createLobby(data);
    get().setLobby(lobby);
  },
  updateLobby: async (lobby) => {
    const updatedLobby = await lobbyService.updateLobby(lobby);
    get().setLobby(updatedLobby);
  },
  setLobby: (lobby) => {
    set(() => ({ lobby }));
  },
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
