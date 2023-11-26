import React, { ReactElement } from 'react';
import { AppBar, Avatar, Box, IconButton, Toolbar, Tooltip, Typography } from '@mui/material';

export default function Navbar(): ReactElement {
  return (
    <Box sx={{ flexGrow: 1 }}>
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
          <Tooltip title="Open settings">
            <IconButton sx={{ p: 0 }}>
              <Avatar/>
            </IconButton>
          </Tooltip>
        </Toolbar>
      </AppBar>
    </Box>
  );
}
