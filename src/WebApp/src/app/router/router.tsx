import { Container } from '@mui/system';
import { Suspense } from 'react';
import { createBrowserRouter, Outlet } from 'react-router-dom';

import { MainPage } from '@pages/lobbies';
import { LobbyPage } from '@pages/lobby';
import { NotFound } from '@pages/notFound';
import { UserSettingsPage } from '@pages/userSettings';

import { LoginPage, RegistrationPage, useAuthStore } from '@widgets/auth';
import { Navbar } from '@widgets/navbar';

import { useLobbyStore } from '@entities/lobby';
import { userService, useUserStore } from '@entities/user';

import { NotFoundType, Route } from '@shared/enums';

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
    errorElement: <NotFound errorType={NotFoundType.GENERAL} />,
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
            const authState = useAuthStore.getState();
            lobbyHubService.setToken(authState.accessToken);
          } catch (e) {
            console.error(e);
            userState.setAnonymous();
          } finally {
            return null;
          }
        },
        children: [
          {
            path: Route.ROOT,
            element: <MainPage />,
            loader: async () => useLobbyStore.getState().fetchLobbies(),
          },
          {
            path: `${Route.LOBBY}/:lobbyId`,
            element: <LobbyPage />,
            loader: async ({ params }) => {
              if (!params.lobbyId) {
                throw new Error('Lobby is not provided');
              }
              await useLobbyStore.getState().fetchLobby(params.lobbyId);
            },
            errorElement: <NotFound errorType={NotFoundType.LOBBY} />,
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
