import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { Button, Dialog, DialogActions, DialogContent, DialogTitle } from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { useLobbySettings } from '@hooks/useLobbySettings';

import LobbySettings from '../common/LobbySettings';

interface LobbySettingsDialogProps {
  setSettingsOpen: (x: boolean) => void;
  settingsOpen: boolean;
  lobbyName: string | undefined;
}

const LobbySettingsDialog: FC<LobbySettingsDialogProps> = ({ settingsOpen, setSettingsOpen }) => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);

  const saveSettings = () => {
    setSettingsOpen(false);
  };
  const [lobbyName, numberOfSpins, rating, setLobbyName, setNumberOfSpins, setRating] =
    useLobbySettings({
      numberOfSpins: 1,
      rating: 5,
      lobbyName: '',
    });

  return (
    <Dialog open={settingsOpen} onClose={() => setSettingsOpen(false)} keepMounted fullWidth={true}>
      <DialogTitle sx={{ m: 1, ml: 0 }}> {t('lobbySettings')}</DialogTitle>
      <DialogContent>
        <LobbySettings
          lobbyName={lobbyName}
          setLobbyName={setLobbyName}
          numberOfSpins={numberOfSpins}
          rating={rating}
          setRating={setRating}
          setNumberOfSpins={setNumberOfSpins}
          withName={true}
        />
      </DialogContent>

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

export default LobbySettingsDialog;
