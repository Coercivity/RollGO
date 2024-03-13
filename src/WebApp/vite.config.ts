import { defineConfig } from 'vite';
import { fileURLToPath, URL } from 'node:url';
import react from '@vitejs/plugin-react';
import viteTsconfigPaths from 'vite-tsconfig-paths';

export default defineConfig({
  plugins: [react(), viteTsconfigPaths()],
  resolve: {
    alias: [
      { find: '@app', replacement: fileURLToPath(new URL('./src/app', import.meta.url)) },
      { find: '@pages', replacement: fileURLToPath(new URL('./src/pages', import.meta.url)) },
      { find: '@widgets', replacement: fileURLToPath(new URL('./src/widgets', import.meta.url)) },
      {
        find: '@features',
        replacement: fileURLToPath(new URL('./src/features', import.meta.url)),
      },
      { find: '@entities', replacement: fileURLToPath(new URL('./src/entities', import.meta.url)) },
      { find: '@shared', replacement: fileURLToPath(new URL('./src/shared', import.meta.url)) },
    ],
  },
  server: {
    proxy: {
      '^/api/(auth|user)': {
        target: 'https://localhost:5282/',
        changeOrigin: true,
        secure: false,
      },
      '^(/lobbyHub|/api/lobbies)': {
        target: 'https://localhost:5228/',
        changeOrigin: true,
        secure: false,
        ws: true,
      },
    },
  },
});
