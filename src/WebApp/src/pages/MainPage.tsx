import { useState } from 'react';
import { useTranslation } from 'react-i18next';
import { useNavigate } from 'react-router-dom';
import { Box, Button, Container } from '@mui/material';

import LobbyCreationModal from '@components/lobby/LobbyCreationModal';
import LobbyList from '@components/lobby/LobbyList';
import { Route } from '@enums/Route';

const MainPage = () => {
  const { t } = useTranslation();
  const [open, setOpen] = useState(false);
  const [lobbies, setLobbies] = useState<string[]>([]);
  const navigate = useNavigate();

  const addNewLobby = (lobby: string) => {
    setLobbies([...lobbies, lobby]);
    setOpen(false);
    navigate(`${Route.LOBBY}/${lobby}`);
  };

  const remove = (name: string) => {
    setLobbies(lobbies.filter((p) => p !== name));
  };

  return (
    <Container maxWidth="lg">
      <Box sx={{ m: 2, textAlign: 'center' }}>
        <Button onClick={() => setOpen(true)} variant="contained" size="large">
          {t('createLobby')}
        </Button>
      </Box>
      <LobbyList remove={remove} lobbies={lobbies} />
      <LobbyCreationModal open={open} setOpen={setOpen} addNewLobby={addNewLobby} />
    </Container>
  );
};
export default MainPage;
