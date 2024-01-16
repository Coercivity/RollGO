import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { Button, Dialog, DialogActions, DialogContent, DialogTitle } from '@mui/material';
//import LobbySettings from './LobbySettings';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';

interface LobbySettingsProps {
  setSettingsOpen: (x: boolean) => void;
  settingsOpen: boolean;
  lobbyName: string | undefined;
}

const LobbySettingsModal: FC<LobbySettingsProps> = ({
  settingsOpen,
  setSettingsOpen,
  //lobbyName,
}) => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);

  const saveSettings = () => {
    setSettingsOpen(false);
  };

  return (
    <Dialog open={settingsOpen} onClose={() => setSettingsOpen(false)} keepMounted fullWidth={true}>
      <DialogTitle sx={{ m: 1, ml: 0 }}> {t('lobbySettings')}</DialogTitle>
      <DialogContent></DialogContent>

      <DialogActions>
        <Button sx={{ mr: 1, mb: 2 }} variant="text" onClick={() => setSettingsOpen(false)}>
          {t('cancel')}
        </Button>
        <Button sx={{ mr: 2, mb: 2 }} variant="contained" onClick={saveSettings}>
          {t('apply')}
        </Button>
      </DialogActions>
    </Dialog>
  );
};

export default LobbySettingsModal;
