import { Suspense } from 'react';
import { createBrowserRouter, Outlet } from 'react-router-dom';
import { Paper } from '@mui/material';

import Navbar from '@components/Navbar';
import TermsOfUse from '@components/TermsOfUse';
import { Route } from '@enums/Route';

import LobbyPage from './pages/LobbyPage';
import LoginPage from './pages/LoginPage';
import MainPage from './pages/MainPage';
import RegistrationPage from './pages/RegistrationPage';
// eslint-disable-next-line react-refresh/only-export-components
const SuspenseWrapper = () => {
  return (
    <Suspense>
      <Paper sx={{ height: '100%', backgroundColor: '#212121' }}>
        <Outlet />
      </Paper>
    </Suspense>
  );
};

// eslint-disable-next-line react-refresh/only-export-components
const NavbarWrapper = () => {
  return (
    <>
      <Navbar />
      <Outlet />
    </>
  );
};

export const router = createBrowserRouter([
  {
    path: Route.ROOT,
    element: <SuspenseWrapper />,
    children: [
      {
        path: Route.ROOT,
        element: <NavbarWrapper />,
        children: [
          {
            path: Route.ROOT,
            element: <MainPage />,
          },
          {
            path: `${Route.LOBBY}/:lobbyId`,
            element: <LobbyPage />,
          },
        ],
      },
      {
        path: Route.LOGIN,
        element: <LoginPage />,
      },
      {
        path: Route.REGISTRATION,
        element: <RegistrationPage />,
      },
      {
        path: Route.RULES,
        element: <TermsOfUse />,
      },
    ],
  },
]);
