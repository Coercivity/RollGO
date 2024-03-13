import { useRef, useState } from 'react';
import { useTranslation } from 'react-i18next';
import { useLoaderData, useNavigate } from 'react-router-dom';
import { Box, Button, Container } from '@mui/material';
import Popover from '@mui/material/Popover';

import { Lobby, lobbyService } from '@entities/lobby';
import { LobbyCreationDialog } from '@features/updateLobby';
import { LocalizationNamespace, Route } from '@shared/enums';
import { LobbyList } from '@widgets/lobbyList';

const MainPage = () => {
  const { t } = useTranslation(LocalizationNamespace.MAIN_PAGE);
  const [open, setOpen] = useState(false);
  const [popoverOpen, setPopoverOpen] = useState(false);
  const [lobbies, setLobbies] = useState<Lobby[]>(useLoaderData() as Lobby[]);

  const anchorEl = useRef<HTMLButtonElement | null>(null);

  const navigate = useNavigate();

  const addNewLobby = async (
    name: string,
    minimalRating: number,
    moviesPerUser: number,
    withCoefficient: boolean
  ) => {
    const lobby = await lobbyService.createLobby({
      name,
      moviesPerUser,
      minimalRating,
      withCoefficient,
    });
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
        <Button
          sx={{ ml: 3 }}
          ref={anchorEl}
          onClick={() => setPopoverOpen(true)}
          variant="contained"
          size="large"
        >
          {t('myLobbies')}
        </Button>
      </Box>
      <Box>
        {!popoverOpen ? null : (
          <Popover
            sx={{ width: '100%' }}
            open={popoverOpen}
            anchorEl={anchorEl.current}
            onClose={() => setPopoverOpen(false)}
            anchorOrigin={{
              vertical: 'bottom',
              horizontal: 'right',
            }}
          >
            <LobbyList remove={remove} lobbies={lobbies} />
          </Popover>
        )}
      </Box>
      <LobbyCreationDialog open={open} setOpen={setOpen} addNewLobby={addNewLobby} />
    </Container>
  );
};
export default MainPage;
