import { Suspense } from 'react';
import { createBrowserRouter, Outlet } from 'react-router-dom';
import { Container } from '@mui/material';

import lobbyService from '@api/lobbyService';
import { userService } from '@api/userService';
import Navbar from '@components/common/Navbar';
import { Route } from '@enums/Route';
import UserSettingsPage from '@pages/UserSettingsPage';
import { useUserStore } from '@store/userStore';

import LobbyPage from './pages/LobbyPage';
import LoginPage from './pages/LoginPage';
import MainPage from './pages/MainPage';
import RegistrationPage from './pages/RegistrationPage';
// eslint-disable-next-line react-refresh/only-export-components
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
    children: [
      {
        path: Route.ROOT,
        element: <NavbarWrapper />,
        loader: async () => {
          const userState = useUserStore.getState();
          if (!userState.id) {
            return null;
          }
          try {
            const user = await userService.get(userState.id);
            userState.setUser(user);
          } catch (e) {
            console.error(e);
          } finally {
            return null;
          }
        },
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
