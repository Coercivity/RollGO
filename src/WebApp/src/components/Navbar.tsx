import React, { ReactElement } from 'react';
import { AppBar, Avatar, IconButton, Toolbar, Tooltip, Typography } from '@mui/material';
import { useTranslation } from 'react-i18next';

const Navbar = (): ReactElement => {
  const { t } = useTranslation('navbar');
  return (
      <AppBar>
        <Toolbar>
          <IconButton
            size="large"
            edge="start"
            color="inherit"
            aria-label="menu"
            sx={{ mr: 2 }}
          >
          </IconButton>
          <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
            RollGO
          </Typography>
          <Tooltip title={t('openProfile')}>
            <IconButton sx={{ p: 0 }}>
              <Avatar/>
            </IconButton>
          </Tooltip>
        </Toolbar>
      </AppBar>
  );
};

export default Navbar;
