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
} from '@mui/material';

interface LobbyCreationModalProps {
  setOpen: (value: boolean) => void;
  addNewLobby: (lobby: string) => void;
  open: boolean;
}

const LobbyCreationModal: FC<LobbyCreationModalProps> = ({ setOpen, addNewLobby, open }) => {
  const { t } = useTranslation();
  const [lobby, setLobby] = useState<string>('');

  const onCreate = () => {
    addNewLobby(lobby);
    setLobby('');
    setOpen(false);
  };

  return (
    <Dialog open={open} onClose={() => setOpen(false)} maxWidth="sm" fullWidth={true}>
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
      </DialogContent>
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
      <DialogActions>
        <Button sx={{ mr: 1, mb: 2 }} variant="text" onClick={() => setOpen(false)}>
          {t('cancel')}
        </Button>
        <Button sx={{ mr: 2, mb: 2 }} disabled={!lobby} variant="outlined" onClick={onCreate}>
          {t('save')}
        </Button>
      </DialogActions>
    </Dialog>
  );
};

export default LobbyCreationModal;
