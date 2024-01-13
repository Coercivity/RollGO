import { FC, useRef, useState } from 'react';
import { useTranslation } from 'react-i18next';
import { useNavigate } from 'react-router-dom';
import LogoutIcon from '@mui/icons-material/Logout';
import SettingsIcon from '@mui/icons-material/Settings';
import {
  AppBar,
  Button,
  ButtonGroup,
  Link,
  List,
  ListItem,
  ListItemButton,
  ListItemIcon,
  ListItemText,
  Toolbar,
  Typography,
} from '@mui/material';
import Popover from '@mui/material/Popover';
import { Box } from '@mui/system';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { Route } from '@enums/Route';
import { useAuthStore } from '@store/authStore';
import { useUserStore } from '@store/userStore';

import UserView from './UserView';

const Navbar: FC = () => {
  const { t } = useTranslation(LocalizationNamespace.NAVBAR);
  const setTokenPair = useAuthStore((state) => state.setTokenPair);
  const anchorEl = useRef<HTMLButtonElement | null>(null);
  const [open, setOpen] = useState(false);
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
    setOpen(false);
  };

  const goSettings = () => {
    navigate(Route.USER_SETTINGS);
    setOpen(false);
  };

  const signUp = () => {
    navigate(Route.REGISTRATION);
  };

  const logIn = () => {
    navigate(Route.LOGIN);
  };

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
          <ButtonGroup disableElevation variant="text" aria-label="Disabled elevation buttons">
            <Button onClick={logIn}>{t('login')}</Button>
            <Button onClick={signUp}>{t('registration')}</Button>
          </ButtonGroup>
        ) : (
          <Box>
            <Popover
              sx={{ width: '100%', minWidth: 360 }}
              open={open}
              anchorEl={anchorEl.current}
              onClose={() => setOpen(false)}
              anchorOrigin={{
                vertical: 'bottom',
                horizontal: 'left',
              }}
            >
              <List>
                <ListItem disablePadding>
                  <ListItemButton onClick={goSettings}>
                    <ListItemIcon>
                      <SettingsIcon />
                    </ListItemIcon>
                    <ListItemText primary={t('profileSettings')} />
                  </ListItemButton>
                </ListItem>
                <ListItem disablePadding>
                  <ListItemButton onClick={onLogout}>
                    <ListItemIcon>
                      <LogoutIcon />
                    </ListItemIcon>
                    <ListItemText primary={t('logout')} />
                  </ListItemButton>
                </ListItem>
              </List>
            </Popover>

            <UserView
              ref={anchorEl}
              nickname={username}
              onClick={() => setOpen(true)}
              isOnline={true}
            />
          </Box>
        )}
      </Toolbar>
    </AppBar>
  );
};

export default Navbar;
