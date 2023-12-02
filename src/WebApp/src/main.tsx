import React from 'react';
import ReactDOM from 'react-dom/client';
import Navbar from './components/Navbar';
import { Route } from './enums/Route';
import { createBrowserRouter, RouterProvider } from 'react-router-dom';
import MainPage from './views/MainPage';
import LobbyPage from './views/LobbyPage';
import './i18n/config';
import './index.css';
import '@fontsource/roboto/300.css';
import '@fontsource/roboto/400.css';
import '@fontsource/roboto/500.css';
import '@fontsource/roboto/700.css';

const router = createBrowserRouter([
  {
    path: Route.ROOT,
    element: <MainPage />,
  },
  {
    path: Route.LOBBY,
    element: <LobbyPage />,
  },
]);

ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <Navbar />
    <RouterProvider router={router} />
  </React.StrictMode>
);
