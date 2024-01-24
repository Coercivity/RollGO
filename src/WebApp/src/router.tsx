import { Suspense } from 'react';
import { createBrowserRouter, Outlet } from 'react-router-dom';
import { Container } from '@mui/material';

import lobbyService from '@api/lobbyService';
import Navbar from '@components/common/Navbar';
import PageNotFoundComponent from '@components/lobby/PageNotFoundComponent';
import { NotFoundType } from '@enums/NotFoundType';
import { Route } from '@enums/Route';
import UserSettingsPage from '@pages/UserSettingsPage';

import LobbyPage from './pages/LobbyPage';
import LoginPage from './pages/LoginPage';
import MainPage from './pages/MainPage';
import RegistrationPage from './pages/RegistrationPage';

const SuspenseWrapper = () => {
  return (
    <Suspense>
      <Outlet />
    </Suspense>
  );
};

// eslint-disable-next-line react-refresh/only-export-components
const NavbarWrapper = () => {
  return (
    <Container maxWidth={false} disableGutters sx={{ height: '100%' }}>
      <Navbar />
      <Outlet />
    </Container>
  );
};

export const router = createBrowserRouter([
  {
    path: Route.ROOT,
    element: <SuspenseWrapper />,
    errorElement: <PageNotFoundComponent errorType={NotFoundType.GENERAL} />,
    children: [
      {
        path: Route.ROOT,
        element: <NavbarWrapper />,
        children: [
          {
            path: Route.ROOT,
            element: <MainPage />,
            loader: async () => lobbyService.getLobbies(),
          },
          {
            path: `${Route.LOBBY}/:lobbyId`,
            element: <LobbyPage />,
            loader: async ({ params }) => lobbyService.getLobby(params.lobbyId ?? ''),
            errorElement: <PageNotFoundComponent errorType={NotFoundType.LOBBY} />,
          },
          {
            path: Route.USER_SETTINGS,
            element: <UserSettingsPage />,
          },
          {
            path: Route.LOGIN,
            element: <LoginPage />,
          },
          {
            path: Route.REGISTRATION,
            element: <RegistrationPage />,
          },
        ],
      },
    ],
  },
]);
