import LogIn from '../components/LogIn';
import Registration from '../components/Registration';
import { Box } from '@mui/material';
import { useLocation } from 'react-router-dom';
import { Route } from '../enums/Route';

const Auth = () => {
  const location = useLocation();
  const isLogin = location.pathname === Route.LOGIN;

  return <Box>{isLogin ? <LogIn /> : <Registration />}</Box>;
};

export default Auth;
