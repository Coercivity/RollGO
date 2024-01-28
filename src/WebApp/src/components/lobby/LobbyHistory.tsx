import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { Box, Drawer, List, Typography } from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';

interface LobbyHistoryProps {
  drawerOpen: boolean;
  setDrawerOpen: (open: boolean) => void;
}

const LobbyHistory: FC<LobbyHistoryProps> = ({ drawerOpen, setDrawerOpen }) => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);

  const toggleDrawer = () => {
    setDrawerOpen(!drawerOpen);
  };

  const list = () => (
    <Box sx={{ width: 350 }} role="presentation">
      <List>
        <Typography> {t('lobbyHistory')}</Typography>
      </List>
    </Box>
  );

  return (
    <Drawer anchor="right" open={drawerOpen} onClose={() => toggleDrawer()}>
      {list()}
    </Drawer>
  );
};

export default LobbyHistory;
