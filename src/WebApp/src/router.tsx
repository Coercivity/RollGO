import { Route } from './enums/Route';
import { Outlet, createBrowserRouter } from 'react-router-dom';
import MainPage from './views/MainPage';
import LobbyPage from './views/LobbyPage';
import Navbar from './components/Navbar';
import AuthPage from './views/AuthPage';

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
      {
        path: Route.LOGIN,
        element: <AuthPage />,
      },
      {
        path: Route.REGISTRATION,
        element: <AuthPage />,
      },
    ],
  },
]);
