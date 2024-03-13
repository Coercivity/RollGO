import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { Button, Dialog, DialogActions, DialogContent, DialogTitle } from '@mui/material';

import { Lobby, lobbyService, LobbySettings, useLobbySettings } from '@entities/lobby';
import { LocalizationNamespace } from '@shared/enums';

interface LobbySettingsDialogProps {
  setSettingsOpen: (x: boolean) => void;
  settingsOpen: boolean;
  lobby: Lobby;
  setLobby: (lobby: Lobby) => void;
}

const LobbySettingsDialog: FC<LobbySettingsDialogProps> = ({
  settingsOpen,
  setSettingsOpen,
  lobby,
  setLobby,
}) => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);

  const [
    lobbyName,
    moviesPerUser,
    rating,
    withCoefficient,
    setLobbyName,
    setMoviesPerUser,
    setRating,
    setWithCoefficient,
  ] = useLobbySettings({
    moviesPerUser: lobby.moviesPerUser,
    minimalRating: lobby.minimalRating,
    name: lobby.name,
    withCoefficient: lobby.withCoefficient,
  });

  const onSettignsSave = async () => {
    try {
      const lobbyResponse = await lobbyService.updateLobby({
        ...lobby,
        name: lobbyName,
        moviesPerUser,
        minimalRating: rating,
        withCoefficient,
      });
      setLobby(lobbyResponse);
      setSettingsOpen(false);
    } catch {
      console.error('Failed to save lobby settings');
    }
  };

  return (
    <Dialog open={settingsOpen} onClose={() => setSettingsOpen(false)} keepMounted fullWidth={true}>
      <DialogTitle sx={{ m: 1, ml: 0 }}> {t('lobbySettings')}</DialogTitle>
      <DialogContent>
        <LobbySettings
          lobbyName={lobbyName}
          moviesPerUser={moviesPerUser}
          rating={rating}
          withKoefficient={withCoefficient}
          setLobbyName={setLobbyName}
          setRating={setRating}
          setMoviesPerUser={setMoviesPerUser}
          setWithKoefficient={setWithCoefficient}
          withName={true}
        />
      </DialogContent>

      <DialogActions>
        <Button sx={{ mr: 1, mb: 2 }} variant="text" onClick={() => setSettingsOpen(false)}>
          {t('cancel')}
        </Button>
        <Button sx={{ mr: 2, mb: 2 }} variant="contained" onClick={onSettignsSave}>
          {t('apply')}
        </Button>
      </DialogActions>
    </Dialog>
  );
};

export default LobbySettingsDialog;
