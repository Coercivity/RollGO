import { FC, useState } from 'react';
import { useTranslation } from 'react-i18next';
import { Close } from '@mui/icons-material';
import {
  Button,
  Dialog,
  DialogActions,
  DialogContent,
  DialogTitle,
  IconButton,
  TextField,
  FormControl,
  FormLabel,
  FormControlLabel,
  Radio,
  RadioGroup,
  Box,
} from '@mui/material';
import LobbySettings from './LobbySettings';
import { LocalizationNamespace } from '@enums/LocalizationNamespace';

interface LobbyCreationModalProps {
  setOpen: (value: boolean) => void;
  addNewLobby: (lobby: string) => void;
  open: boolean;
}

const LobbyCreationModal: FC<LobbyCreationModalProps> = ({ setOpen, addNewLobby, open }) => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);
  const [lobby, setLobby] = useState<string>('');

  const [radioValue, setRadioValue] = useState<string>('');

  const [spinCount, setSpinCount] = useState(1);
  const [rating, setRating] = useState<number | null>(6);

  const onCreate = () => {
    addNewLobby(lobby);
    setLobby('');
    setOpen(false);
  };

  const handleChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    setRadioValue((event.target as HTMLInputElement).value);
  };

  return (
    <Dialog open={open} onClose={() => setOpen(false)} keepMounted fullWidth={true}>
      <DialogTitle sx={{ mt: 1 }}>{t('createLobby')}</DialogTitle>
      <DialogContent>
        <TextField
          autoFocus
          margin="dense"
          id="name"
          label={t('lobbyName')}
          fullWidth
          variant="standard"
          onChange={(e) => setLobby(e.target.value)}
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
          <FormControl>
            <FormLabel>{t('lobbySettings')}</FormLabel>
            <RadioGroup row defaultValue="default" onChange={handleChange}>
              <FormControlLabel value="default" control={<Radio />} label={t('default')} />
              <FormControlLabel value="custom" control={<Radio />} label={t('custom')} />
            </RadioGroup>
          </FormControl>
          {!!(radioValue === 'custom') && (
            <Box sx={{ mt: 1, border: 0.5, borderRadius: 3, p: 3, borderColor: 'grey.500' }}>
              <LobbySettings
                lobbyName={lobby}
                setLobbyName={setLobby}
                spinCount={spinCount}
                rating={rating}
                setRating={setRating}
                setSpinCount={setSpinCount}
              />
            </Box>
          )}
        </Box>
      </DialogContent>
      <DialogActions>
        <Button sx={{ mr: 1, mb: 2 }} variant="text" onClick={() => setOpen(false)}>
          {t('cancel')}
        </Button>
        <Button sx={{ mr: 2, mb: 2 }} disabled={!lobby} variant="contained" onClick={onCreate}>
          {t('create')}
        </Button>
      </DialogActions>
    </Dialog>
  );
};

export default LobbyCreationModal;
