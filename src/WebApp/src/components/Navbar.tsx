import { FC } from 'react';
import { AppBar, Link, Toolbar, Tooltip, Typography } from '@mui/material';
import { useTranslation } from 'react-i18next';
import UserView from './UserView';
import { LocalizationNamespace } from '../enums/LocalizationNamespace';
import { Route } from '../enums/Route';

const Navbar: FC = () => {
  const { t } = useTranslation(LocalizationNamespace.NAVBAR);
  const nickname = 'Slavoyar';

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
          <Link href={Route.MOVIE} sx={{ color: 'white', fontWeight: 700, textDecoration: 'none' }}>
            MovieView
          </Link>
        </Typography>
        <Tooltip title={t('openProfile')}>
          <UserView nickname={nickname} onClick={onUserViewClick} />
        </Tooltip>
      </Toolbar>
    </AppBar>
  );
};

export default Navbar;
