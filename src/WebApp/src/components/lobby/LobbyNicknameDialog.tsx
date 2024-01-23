import { FC, useState } from 'react';
import { useTranslation } from 'react-i18next';
import {
  Button,
  Dialog,
  DialogActions,
  DialogContent,
  DialogContentText,
  DialogTitle,
  TextField,
} from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { useUserStore } from '@store/userStore';

interface LobbyNicknameDialogProps {
  setOpen: (x: boolean) => void;
  open: boolean;
}

const LobbyNicknameDialog: FC<LobbyNicknameDialogProps> = ({ setOpen, open }) => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);
  const [name, setName] = useState<string>('');
  const setAnonymous = useUserStore((state) => state.setAnonymous);

  const onCreate = () => {
    setOpen(false);
    setAnonymous(name);
  };

  return (
    <Dialog open={open} keepMounted fullWidth={true}>
      <DialogTitle sx={{ mt: 2 }}>{t('nameChangerTitle')}</DialogTitle>
      <DialogContent>
        <DialogContentText>{t('nameChangerText')}</DialogContentText>
        <TextField
          autoFocus
          margin="dense"
          id="name"
          label={t('userNameInput')}
          fullWidth
          variant="standard"
          onChange={(e) => setName(e.target.value)}
        />
      </DialogContent>

      <DialogActions>
        <Button sx={{ mr: 2, mb: 2 }} variant="contained" disabled={!name} onClick={onCreate}>
          {t('apply')}
        </Button>
      </DialogActions>
    </Dialog>
  );
};

export default LobbyNicknameDialog;
