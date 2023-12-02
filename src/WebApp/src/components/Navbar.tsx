import { FC } from 'react';
import { AppBar, Box, IconButton, Toolbar, Tooltip, Typography } from '@mui/material';
import { useTranslation } from 'react-i18next';
import UserView from './UserView';
import { LocalizationNamespace } from '../enums/LocalizationNamespace';

const Navbar: FC = () => {
  const { t } = useTranslation(LocalizationNamespace.NAVBAR);
  const nickname = 'Slavoyar';

  const onUserViewClick = () => {
    console.log('go to user settings');
  };
  return (
    <Box sx={{ flexGrow: 1 }}>
      <AppBar>
        <Toolbar>
          <IconButton size="large" edge="start" color="inherit" aria-label="menu" sx={{ mr: 2 }} />
          <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
            RollGO
          </Typography>
          <Tooltip title={t('openProfile')}>
            <UserView nickname={nickname} onClick={onUserViewClick} />
          </Tooltip>
        </Toolbar>
      </AppBar>
    </Box>
  );
};

export default Navbar;
