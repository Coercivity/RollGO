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
import { FC, useState } from 'react';
import { useTranslation } from 'react-i18next';

import { useNavigate } from 'react-router-dom';
import { LobbySettings, useLobbySettings, useLobbyStore } from '@entities/lobby';

import { LocalizationNamespace, Route } from '@shared/enums';

const CreateLobby: FC = () => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);
  const navigate = useNavigate();

  const [isOpen, setOpen] = useState(false);
  const [lobby, createLobby] = useLobbyStore((state) => [state.lobby, state.createLobby]);

  const [
    lobbyName,
    moviesPerUser,
    rating,
    withCoefficient,
    setLobbyName,
    setMoviesPerUser,
    setRating,
    setWithCoefficient,
  ] = useLobbySettings();

  const onCreate = async () => {
    try {
      await createLobby({
        name: lobbyName,
        moviesPerUser,
        minimalRating: rating,
        withCoefficient,
      });
      navigate(`${Route.LOBBY}/${lobby?.id}`);
    } finally {
      setLobbyName('');
      setOpen(false);
    }
  };

  return (
    <>
      <Button onClick={() => setOpen(true)} variant="contained" size="large">
        {t('createLobby')}
      </Button>
      <Dialog open={isOpen} onClose={() => setOpen(false)} keepMounted fullWidth={true}>
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
                      withCoefficient={withCoefficient}
                      setLobbyName={setLobbyName}
                      setRating={setRating}
                      setMoviesPerUser={setMoviesPerUser}
                      setWithCoefficient={setWithCoefficient}
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
          <Button
            sx={{ mr: 2, mb: 2 }}
            disabled={!lobbyName}
            variant="contained"
            onClick={onCreate}
          >
            {t('create')}
          </Button>
        </DialogActions>
      </Dialog>
    </>
  );
};

export default CreateLobby;
