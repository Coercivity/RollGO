import React, { useState } from 'react';
import { useTranslation } from 'react-i18next';
import HistoryIcon from '@mui/icons-material/History';
import { Box, Button, Drawer, List } from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';

export default function TemporaryDrawer() {
  const [drawerOpen, setDrawerOpen] = useState(false);
  const { t } = useTranslation(LocalizationNamespace.LOBBY);

  const toggleDrawer = () => {
    setDrawerOpen(!drawerOpen);
  };

  const list = () => (
    <Box sx={{ width: 350 }} role="presentation">
      <List>list</List>
    </Box>
  );

  return (
    <React.Fragment>
      <Button fullWidth variant="outlined" onClick={() => toggleDrawer()}>
        {<HistoryIcon />} {t('lobbyHistory')}
      </Button>
      <Drawer anchor="right" open={drawerOpen} onClose={() => toggleDrawer()}>
        {list()}
      </Drawer>
    </React.Fragment>
  );
}
