import axios from 'axios';

import { useAuthStore } from '@store/authStore';

import { authService } from './authService';

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
    if (error.response.status == 401) {
      try {
        const state = useAuthStore.getState();
        const tokenPair = await authService.refreshToken({
          accessToken: state.accessToken,
          refreshToken: state.refreshToken,
        });
        state.setTokenPair(tokenPair);
        axios.defaults.headers.common.Authorization = 'Bearer ' + tokenPair.accessToken;
        const response = await axios.request(error.request);
        return response.data;
      } catch (err) {
        if (err && axios.isAxiosError(err) && err.response?.status === 403) {
          useAuthStore.getState().setTokenPair({ accessToken: '', refreshToken: '' });
        }
      }
    }
  }
);
