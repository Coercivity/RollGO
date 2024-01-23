import { useEffect, useRef, useState } from 'react';
import { useTranslation } from 'react-i18next';
import { useLoaderData, useNavigate } from 'react-router-dom';
import ExitToAppIcon from '@mui/icons-material/ExitToApp';
import SettingsIcon from '@mui/icons-material/Settings';
import {
  Box,
  Button,
  Container,
  Grid,
  IconButton,
  Paper,
  ToggleButton,
  ToggleButtonGroup,
  Typography,
  useTheme,
} from '@mui/material';

import {
  LobbyHistory,
  LobbyNicknameDialog,
  LobbySettingsDialog,
  MovieList,
  MovieSearch,
  SpinningWheel,
  UsersList,
} from '@components/lobby';
import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { Route } from '@enums/Route';
import { Lobby } from '@models/Lobby';
import { Movie } from '@models/Movie';
import { useUserStore } from '@store/userStore';

const LobbyPage = () => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);
  const theme = useTheme();
  const lobbyData = useLoaderData() as Lobby;

  const [lobby, setLobby] = useState<Lobby>(lobbyData);
  const [movies, setMovies] = useState<Movie[]>([]);
  const [isWheelVisible, setIsWheelVisible] = useState(false);
  const [openModal, setOpenModal] = useState(false);
  const [settingsOpen, setSettingsOpen] = useState(false);
  const [isAnonymous] = useUserStore((state) => [state.isAnonymous]);
  const [maxHeight, setMaxHeight] = useState(window.innerHeight);
  const navigate = useNavigate();

  const movieListContainer = useRef<HTMLElement>();

  const handleResize = () => {
    const offsetTop = movieListContainer.current?.offsetTop ?? 0;
    const themeOffset = Number(theme.spacing().split('px')[0]) * 2;
    setMaxHeight(window.innerHeight - offsetTop - themeOffset);
  };

  useEffect(() => {
    handleResize();
    window.addEventListener('resize', handleResize);
    return () => {
      window.removeEventListener('resize', handleResize);
    };
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [movies]);

  useEffect(() => {
    if (isAnonymous) setOpenModal(true); // выставил ! что б не вылазило при каждом сохранении
  }, []);

  const exitLobby = () => {
    navigate(Route.ROOT);
  };

  const handleChange = (newState: boolean) => {
    if (newState !== null) setIsWheelVisible(newState);
  };

  return (
    <Container maxWidth="lg" sx={{ height: '100%', mt: 2 }}>
      <Paper sx={{ py: 2, bgcolor: 'grey.900', mb: 2 }}>
        <Box sx={{ display: 'flex', justifyContent: 'left' }}>
          <IconButton color="secondary" onClick={exitLobby}>
            <ExitToAppIcon />
          </IconButton>
          <Typography variant="h4" color="text.secondary">
            {t('room')}
          </Typography>
          <Typography sx={{ ml: 2 }} variant="h4">
            {lobby.name}
          </Typography>
        </Box>
      </Paper>
      <Grid container spacing={2}>
        <Grid item xs={8}>
          <Box sx={{ p: 2, height: '100%', bgcolor: 'grey.900' }}>
            {!isWheelVisible ? (
              <>
                <MovieSearch movies={movies} setMovies={setMovies} />
                <Box ref={movieListContainer} sx={{ mt: 2, maxHeight, overflow: 'auto' }}>
                  <MovieList movies={movies} setMovies={setMovies} />
                </Box>
              </>
            ) : (
              <SpinningWheel movies={movies} />
            )}
          </Box>
        </Grid>
        <Grid item xs={4}>
          <Box sx={{ maxWidth: '600px' }}>
            <ToggleButtonGroup
              fullWidth
              size="small"
              color="primary"
              value={isWheelVisible}
              onChange={(_, value) => handleChange(value)}
              exclusive
              aria-label="Platform"
            >
              <ToggleButton value={false}>{t('movieList')}</ToggleButton>
              <ToggleButton value={true}>{t('wheel')}</ToggleButton>
            </ToggleButtonGroup>
            <UsersList />
            <Button fullWidth variant="contained" onClick={() => setSettingsOpen(true)}>
              {<SettingsIcon />} {t('lobbySettings')}
            </Button>
            <LobbySettingsDialog
              lobby={lobby}
              settingsOpen={settingsOpen}
              setSettingsOpen={setSettingsOpen}
              setLobby={setLobby}
            />
            <LobbyHistory />
          </Box>
        </Grid>
      </Grid>
      <LobbyNicknameDialog open={openModal} setOpen={setOpenModal} />
    </Container>
  );
};

export default LobbyPage;
