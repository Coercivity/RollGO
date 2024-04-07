import SettingsIcon from '@mui/icons-material/Settings';
import { Button, Dialog, DialogActions, DialogContent, DialogTitle } from '@mui/material';
import { FC, useState } from 'react';
import { useTranslation } from 'react-i18next';

import { useNavigate } from 'react-router-dom';
import { LobbySettings, useLobbySettings, useLobbyStore } from '@entities/lobby';

import { LocalizationNamespace, Route } from '@shared/enums';

const EditLobby: FC = () => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);
  const navigate = useNavigate();

  const [isOpen, setOpen] = useState(false);
  const [lobby, updateLobby] = useLobbyStore((state) => [state.lobby, state.updateLobby]);
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
    moviesPerUser: lobby?.moviesPerUser,
    minimalRating: lobby?.minimalRating,
    name: lobby?.name,
    withCoefficient: lobby?.withCoefficient,
  });

  const onSettingsSave = async () => {
    try {
      if (!lobby) {
        navigate(Route.ROOT);
        return;
      }
      await updateLobby({
        ...lobby,
        name: lobbyName,
        moviesPerUser,
        minimalRating: rating,
        withCoefficient,
      });
      setOpen(false);
    } catch {
      console.error('Failed to save lobby settings');
    }
  };

  return (
    <>
      <Button fullWidth variant="contained" onClick={() => setOpen(true)}>
        {<SettingsIcon />} {t('lobbySettings')}
      </Button>
      <Dialog open={isOpen} onClose={() => setOpen(false)} keepMounted fullWidth={true}>
        <DialogTitle sx={{ m: 1, ml: 0 }}> {t('lobbySettings')}</DialogTitle>
        <DialogContent>
          <LobbySettings
            lobbyName={lobbyName}
            moviesPerUser={moviesPerUser}
            rating={rating}
            withCoefficient={withCoefficient}
            setLobbyName={setLobbyName}
            setRating={setRating}
            setMoviesPerUser={setMoviesPerUser}
            setWithCoefficient={setWithCoefficient}
            withName={true}
          />
        </DialogContent>

        <DialogActions>
          <Button sx={{ mr: 1, mb: 2 }} variant="text" onClick={() => setOpen(false)}>
            {t('cancel')}
          </Button>
          <Button sx={{ mr: 2, mb: 2 }} variant="contained" onClick={onSettingsSave}>
            {t('apply')}
          </Button>
        </DialogActions>
      </Dialog>
    </>
  );
};

export default EditLobby;
