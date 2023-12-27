import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { useNavigate } from 'react-router-dom';
import LogoutIcon from '@mui/icons-material/Logout';
import {
  AppBar,
  Button,
  ButtonGroup,
  IconButton,
  Link,
  Toolbar,
  Tooltip,
  Typography,
} from '@mui/material';
import { Box } from '@mui/system';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { Route } from '@enums/Route';
import { useAuthStore } from '@store/authStore';
import { useUserStore } from '@store/userStore';

import UserView from './UserView';

const Navbar: FC = () => {
  const { t } = useTranslation(LocalizationNamespace.NAVBAR);
  const setTokenPair = useAuthStore((state) => state.setTokenPair);
  const [username, isAnonymous, setUser] = useUserStore((state) => [
    state.username,
    state.isAnonymous,
    state.setUser,
  ]);

  const navigate = useNavigate();

  const onLogout = async () => {
    setTokenPair({ accessToken: '', refreshToken: '' });
    setUser({ id: '', username: 'Anon', isOnline: false }, true);
    navigate(Route.ROOT);
  };

  const signUp = () => {
    navigate(Route.REGISTRATION);
  };

  const logIn = () => {
    navigate(Route.LOGIN);
  };

  const onUserViewClick = () => {
    console.log('go to user settings');
  }; //???

  return (
    <AppBar position="static">
      <Toolbar>
        <Typography
          variant="h6"
          noWrap
          flexGrow={1}
          sx={{
            mr: 2,
          }}
        >
          <Link href={Route.ROOT} sx={{ color: 'white', fontWeight: 700, textDecoration: 'none' }}>
            {t('RollGO')}
          </Link>
        </Typography>
        {isAnonymous ? (
          <ButtonGroup disableElevation variant="contained" aria-label="Disabled elevation buttons">
            <Button onClick={logIn}>{t('login')}</Button>
            <Button onClick={signUp}>{t('registration')}</Button>
          </ButtonGroup>
        ) : (
          <Box>
            <Tooltip title={t('openProfile')} sx={{ display: 'flex', flexDirection: 'row' }}>
              <UserView nickname={username} onClick={onUserViewClick} isOnline={true} />
            </Tooltip>
            <IconButton onClick={onLogout} sx={{ color: 'white' }}>
              <LogoutIcon />
            </IconButton>
          </Box>
        )}
      </Toolbar>
    </AppBar>
  );
};

export default Navbar;
