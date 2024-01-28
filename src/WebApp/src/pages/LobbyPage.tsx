import { useEffect, useRef, useState } from 'react';
import { useTranslation } from 'react-i18next';
import { useLoaderData, useNavigate } from 'react-router-dom';
import ExitToAppIcon from '@mui/icons-material/ExitToApp';
import HistoryIcon from '@mui/icons-material/History';
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

import lobbyHubService from '@api/lobbyHubService';
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

import { getIdFromUrl } from '../utils/utils';

const LobbyPage = () => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);
  const theme = useTheme();
  const lobbyData = useLoaderData() as Lobby;

  const [lobby, setLobby] = useState<Lobby>(lobbyData);
  const [drawerOpen, setDrawerOpen] = useState(false);
  const [movies, setMovies] = useState<Movie[]>([]);
  const [isWheelVisible, setIsWheelVisible] = useState(false);
  const [openModal, setOpenModal] = useState(false);
  const [settingsOpen, setSettingsOpen] = useState(false);
  const [isAnonymous] = useUserStore((state) => [state.isAnonymous]);
  const [maxHeight, setMaxHeight] = useState(window.innerHeight);
  const [movie, setMovie] = useState('');
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
    lobbyHubService.moviesChanged((value) => {
      setMovies(value);
      setMovie('');
    });
    lobbyHubService.joinLobbyAnonymous(lobbyData.id, 'test');
    if (isAnonymous) setOpenModal(true); // выставил ! что б не вылазило при каждом сохранении
  }, []);

  const exitLobby = () => {
    navigate(Route.ROOT);
  };

  const handleChange = (newState: boolean) => {
    if (newState !== null) setIsWheelVisible(newState);
  };

  const onMovieSet = (newMovie: string) => {
    if (!Number.isNaN(Number(newMovie))) {
      lobbyHubService.addMovie(Number(newMovie));
      setMovie(newMovie);
      return;
    }
    const id = getIdFromUrl(newMovie);
    if (!id || Number.isNaN(id)) {
      console.error('wrong url');
      return;
    }
    lobbyHubService.addMovie(id);
    setMovie(id.toString());
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
                <MovieSearch movie={movie} setMovie={onMovieSet} />
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

            <Button fullWidth variant="outlined" onClick={() => setDrawerOpen(true)}>
              {<HistoryIcon />} {t('lobbyHistory')}
            </Button>
            <LobbySettingsDialog
              lobby={lobby}
              settingsOpen={settingsOpen}
              setSettingsOpen={setSettingsOpen}
              setLobby={setLobby}
            />
            <LobbyHistory drawerOpen={drawerOpen} setDrawerOpen={setDrawerOpen} />
          </Box>
        </Grid>
      </Grid>
      <LobbyNicknameDialog open={openModal} setOpen={setOpenModal} />
    </Container>
  );
};

export default LobbyPage;
