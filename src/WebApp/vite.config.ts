import { defineConfig } from 'vite';
import { fileURLToPath, URL } from 'node:url';
import react from '@vitejs/plugin-react';
import viteTsconfigPaths from 'vite-tsconfig-paths';

export default defineConfig({
  plugins: [react(), viteTsconfigPaths()],
  resolve: {
    alias: [
      { find: '@api', replacement: fileURLToPath(new URL('./src/api', import.meta.url)) },
      { find: '@enums', replacement: fileURLToPath(new URL('./src/enums', import.meta.url)) },
      { find: '@store', replacement: fileURLToPath(new URL('./src/store', import.meta.url)) },
      {
        find: '@components',
        replacement: fileURLToPath(new URL('./src/components', import.meta.url)),
      },
      { find: '@models', replacement: fileURLToPath(new URL('./src/models', import.meta.url)) },
      { find: '@pages', replacement: fileURLToPath(new URL('./src/pages', import.meta.url)) },
      { find: '@hooks', replacement: fileURLToPath(new URL('./src/hooks', import.meta.url)) },
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
