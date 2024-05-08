import { ThemeProvider } from '@mui/material';
import ReactDOM from 'react-dom/client';
import { RouterProvider } from 'react-router-dom';

// eslint-disable-next-line import/no-internal-modules
import './config/i18n';
// eslint-disable-next-line import/no-internal-modules
import './config/middlewares';

import { router } from './router';
import { theme } from './theme';

import './index.css';
import '@fontsource/roboto/300.css';
import '@fontsource/roboto/400.css';
import '@fontsource/roboto/500.css';
import '@fontsource/roboto/700.css';

ReactDOM.createRoot(document.getElementById('root')!).render(
  <ThemeProvider theme={theme}>
    <RouterProvider router={router} />
  </ThemeProvider>
);
