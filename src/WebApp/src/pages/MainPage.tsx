import { useState } from 'react';
import { useTranslation } from 'react-i18next';
import { useLoaderData, useNavigate } from 'react-router-dom';
import { Box, Button, Container } from '@mui/material';

import lobbyService from '@api/lobbyService';
import LobbyCreationModal from '@components/lobby/LobbyCreationModal';
import LobbyList from '@components/lobby/LobbyList';
import { Route } from '@enums/Route';
import { Lobby } from '@models/Lobby';

const MainPage = () => {
  const { t } = useTranslation();
  const [open, setOpen] = useState(false);
  const [lobbies, setLobbies] = useState<Lobby[]>(useLoaderData() as Lobby[]);
  const navigate = useNavigate();

  const addNewLobby = async (lobbyName: string) => {
    const lobby = await lobbyService.createLobby(lobbyName);
    setOpen(false);
    navigate(`${Route.LOBBY}/${lobby.id}`);
  };

  const remove = async (lobbyId: string) => {
    await lobbyService.removeLobby(lobbyId);
    setLobbies(lobbies.filter((lobby) => lobby.id !== lobbyId));
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
