import { Suspense } from 'react';
import { Route } from './enums/Route';
import { Outlet, createBrowserRouter } from 'react-router-dom';
import MainPage from './views/MainPage';
import LobbyPage from './views/LobbyPage';
import Navbar from './components/Navbar';
import TermsOfUse from './components/TermsOfUse';

import LogIn from './views/LogIn';
import Registration from './views/Registration';
import MoviePage from './views/MoviePage';

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
        element: <LogIn />,
      },
      {
        path: Route.REGISTRATION,
        element: <Registration />,
      },
      {
        path: Route.RULES,
        element: <TermsOfUse />,
      },
      {
        path: Route.MOVIE,
        element: <MoviePage />,
      },
    ],
  },
]);
