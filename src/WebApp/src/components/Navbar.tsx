import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { AppBar, Link, Toolbar, Tooltip, Typography } from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { Route } from '@enums/Route';
import { useUserStore } from '@store/userStore';

import UserView from './UserView';

const Navbar: FC = () => {
  const { t } = useTranslation(LocalizationNamespace.NAVBAR);
  const username = useUserStore((state) => state.username);

  const onUserViewClick = () => {
    console.log('go to user settings');
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
            RollGO
          </Link>
          <Link href={Route.LOGIN} sx={{ color: 'red', fontWeight: 700, textDecoration: 'none' }}>
            Авторизация
          </Link>
        </Typography>
        <Tooltip title={t('openProfile')}>
          <UserView nickname={username} onClick={onUserViewClick} isOnline={true} />
        </Tooltip>
      </Toolbar>
    </AppBar>
  );
};

export default Navbar;
