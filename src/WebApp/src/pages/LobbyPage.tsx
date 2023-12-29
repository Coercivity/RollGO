import { useEffect, useRef, useState } from 'react';
import { useTranslation } from 'react-i18next';
import { useNavigate } from 'react-router-dom';
import { useParams } from 'react-router-dom';
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

import LobbyHistory from '@components/lobby/LobbyHistory';
import LobbyNicknameModal from '@components/lobby/LobbyNicknameModal';
import LobbySettings from '@components/lobby/LobbySettings';
import MovieList from '@components/lobby/movie/MovieList';
import MovieSearch from '@components/lobby/movie/MovieSearch';
import SpinningWheel from '@components/lobby/SpiningWheel';
import UsersList from '@components/lobby/user/UsersList';
import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { Route } from '@enums/Route';
import { Movie } from '@models/Movie';
import { useUserStore } from '@store/userStore';

type LobbyParams = {
  lobbyId: string;
};

const LobbyPage = () => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);
  const theme = useTheme();

  const [movies, setMovies] = useState<Movie[]>([]);
  const [isWheelVisible, setIsWheelVisible] = useState(false);
  const [openModal, setOpenModal] = useState(false);
  const [settingsOpen, setSettingsOpen] = useState(false);
  const [isAnonymous, setUser] = useUserStore((state) => [state.isAnonymous, state.setUser]);
  const [maxHeight, setMaxHeight] = useState(window.innerHeight);

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
  }, [movies]);

  useEffect(() => {
    if (!isAnonymous) setOpenModal(true); // выставил ! что б не вылазило при каждом сохранении
  }, [isAnonymous]);

  const { lobbyId } = useParams<LobbyParams>();

  const navigate = useNavigate();
  const exitLobby = () => {
    setUser({ id: '', username: 'Anon', isOnline: false }, true);

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
            {lobbyId}
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
            <LobbySettings
              lobbyName={lobbyId}
              settingsOpen={settingsOpen}
              setSettingsOpen={setSettingsOpen}
            />
            <LobbyHistory />
          </Box>
        </Grid>
      </Grid>
      <LobbyNicknameModal open={openModal} setOpen={setOpenModal} />
    </Container>
  );
};

export default LobbyPage;
