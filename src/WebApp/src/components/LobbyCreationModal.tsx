import React, { FC, useState } from 'react';
import { Button, Box, Modal, Typography, Input } from '@mui/material';

interface LobbyCreationModalProps {
  setOpen: (value: boolean) => void;
  addNewLobby: (lobby: string) => void;
  open: boolean;
}

const LobbyCreationModal: FC<LobbyCreationModalProps> = ({ setOpen, addNewLobby, open }) => {
  const [lobby, setLobby] = useState<string>('');

  const onCreate = () => {
    addNewLobby(lobby);
    setLobby('');
    setOpen(false);
  };

  const style = {
    position: 'absolute' as const,
    top: '50%',
    left: '50%',
    transform: 'translate(-50%, -50%)',
    width: 400,
    bgcolor: 'background.paper',
    border: '2px solid #000',
    boxShadow: 24,
    justifyContent: 'center',
    p: 4,
  };

  return (
    <Modal
      open={open}
      onClose={() => setOpen(false)}
      aria-labelledby="modal-modal-title"
      aria-describedby="modal-modal-description"
    >
      <Box sx={style}>
        <Typography id="modal-modal-title" variant="h6" component="h2">
          Имя лобби
        </Typography>
        <Input value={lobby} onChange={(e) => setLobby(e.target.value)} />
        <Box sx={{ justifyContent: 'center', flexWrap: 'wrap' }}>
          <Button variant="outlined" color="error" onClick={() => setOpen(false)}>
            Отмена
          </Button>
          <Button variant="outlined" onClick={onCreate}>
            Создать
          </Button>
        </Box>
      </Box>
    </Modal>
  );
};

export default LobbyCreationModal;
