import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { Close } from '@mui/icons-material';
import ExpandMoreIcon from '@mui/icons-material/ExpandMore';
import {
  Accordion,
  AccordionDetails,
  AccordionSummary,
  Box,
  Button,
  Dialog,
  DialogActions,
  DialogContent,
  DialogTitle,
  FormControl,
  IconButton,
  TextField,
  Typography,
} from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { SettingsProps, useLobbySettings } from '@hooks/useLobbySettings';
import { LobbySettings as LobbySettingsType } from '@models/Lobby';

import LobbySettings from '../common/LobbySettings';

interface LobbyCreationDialogProps {
  setOpen: (value: boolean) => void;
  addNewLobby: (lobby: string, settings: LobbySettingsType) => void;
  open: boolean;
}
const INITIAL_SETTINGS = {
  moviesPerUser: 1,
  minimalRating: 5,
  lobbyName: '',
  withKoefficient: true,
} as SettingsProps;

const LobbyCreationDialog: FC<LobbyCreationDialogProps> = ({ setOpen, addNewLobby, open }) => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);

  const [
    lobbyName,
    moviesPerUser,
    rating,
    withKoefficient,
    setLobbyName,
    setMoviesPerUser,
    setRating,
    setWithKoefficient,
  ] = useLobbySettings(INITIAL_SETTINGS);

  const onCreate = () => {
    addNewLobby(lobbyName, {
      moviesPerUser,
      minimalRating: rating,
      withKoefficient,
    });
    setLobbyName('');
    setOpen(false);
  };

  return (
    <Dialog open={open} onClose={() => setOpen(false)} keepMounted fullWidth={true}>
      <DialogTitle sx={{ mt: 1 }}>{t('createLobby')}</DialogTitle>
      <DialogContent>
        <TextField
          sx={{ color: 'grey.800' }}
          autoFocus
          margin="dense"
          id="name"
          label={t('lobbyName')}
          fullWidth
          variant="standard"
          inputProps={{ maxLength: 20 }}
          onChange={(e) => setLobbyName(e.target.value)}
        />

        <IconButton
          aria-label="close"
          onClick={() => setOpen(false)}
          sx={{
            position: 'absolute',
            right: 8,
            top: 8,
            color: (theme) => theme.palette.grey[500],
          }}
        >
          <Close />
        </IconButton>
        <Box sx={{ mt: 3 }}>
          <FormControl sx={{ width: '100%' }}>
            <Accordion>
              <AccordionSummary
                sx={{ width: '100%' }}
                expandIcon={<ExpandMoreIcon />}
                aria-controls="panel1-content"
                id="panel1-header"
              >
                <Typography>{t('custom')}</Typography>
              </AccordionSummary>
              <AccordionDetails>
                <Box>
                  <LobbySettings
                    lobbyName={lobbyName}
                    moviesPerUser={moviesPerUser}
                    rating={rating}
                    withKoefficient={withKoefficient}
                    setLobbyName={setLobbyName}
                    setRating={setRating}
                    setMoviesPerUser={setMoviesPerUser}
                    setWithKoefficient={setWithKoefficient}
                    withName={false}
                  />
                </Box>
              </AccordionDetails>
            </Accordion>
          </FormControl>
        </Box>
      </DialogContent>
      <DialogActions>
        <Button sx={{ mr: 1, mb: 2 }} variant="text" onClick={() => setOpen(false)}>
          {t('cancel')}
        </Button>
        <Button sx={{ mr: 2, mb: 2 }} disabled={!lobbyName} variant="contained" onClick={onCreate}>
          {t('create')}
        </Button>
      </DialogActions>
    </Dialog>
  );
};

export default LobbyCreationDialog;
