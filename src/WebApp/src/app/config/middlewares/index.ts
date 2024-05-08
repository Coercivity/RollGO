import axios from 'axios';

import { lobbyHubService } from '@entities/lobby';
import { authService, useAuthStore, useUserStore } from '@entities/user';

axios.interceptors.request.use(
  (config) => {
    const accessToken = useAuthStore.getState().accessToken;
    if (accessToken) {
      config.headers.Authorization = `Bearer ${accessToken}`;
    }
    return config;
  },
  (error) => {
    return Promise.reject(error);
  }
);

const refreshTokens = async (): Promise<string> => {
  const state = useAuthStore.getState();
  const tokenPair = await authService.refreshToken({
    accessToken: state.accessToken,
    refreshToken: state.refreshToken,
  });
  state.setTokenPair(tokenPair);
  lobbyHubService.setToken(tokenPair.accessToken);
  return tokenPair.accessToken;
};

lobbyHubService.setUnauthorizedCallback(refreshTokens);

axios.interceptors.response.use(
  (response) => {
    return response.data;
  },
  async (error) => {
    if (!axios.isAxiosError(error)) {
      return Promise.reject(error);
    }
    if (error.response?.status == 401) {
      try {
        const token = await refreshTokens();
        axios.defaults.headers.common.Authorization = 'Bearer ' + token;
        return await axios.request(error?.config ?? {});
      } catch (err) {
        if (err && axios.isAxiosError(err) && err.response?.status === 403) {
          useAuthStore.getState().setTokenPair({ accessToken: '', refreshToken: '' });
          useUserStore.getState().setAnonymous();
        }
      }
    }
    return Promise.reject(error);
  }
);
