import axios from 'axios';

import { authService } from '@widgets/auth';
import { useAuthStore } from '@widgets/auth';

import { useUserStore } from '@entities/user';

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
        const state = useAuthStore.getState();
        const tokenPair = await authService.refreshToken({
          accessToken: state.accessToken,
          refreshToken: state.refreshToken,
        });
        state.setTokenPair(tokenPair);
        axios.defaults.headers.common.Authorization = 'Bearer ' + tokenPair.accessToken;
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
