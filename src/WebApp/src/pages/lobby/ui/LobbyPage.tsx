import ExitToAppIcon from '@mui/icons-material/ExitToApp';
import HistoryIcon from '@mui/icons-material/History';
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
import { useEffect, useRef, useState } from 'react';
import { useTranslation } from 'react-i18next';
import { useNavigate } from 'react-router-dom';

import { LobbyHistory } from '@widgets/lobbyHistory';
import { MovieList } from '@widgets/movieList';
import { UsersList } from '@widgets/usersList';

import { EditLobby } from '@features/editLobby';
import { MovieSearch } from '@features/searchMovie';
import { LobbyNicknameDialog } from '@features/setUsername';
import { SpinningWheel } from '@features/spinMovies';

import { Movie } from '@entities/movie';
import { useUserStore } from '@entities/user';

import { LocalizationNamespace, Route, SearchType } from '@shared/enums';
import { useDebounce } from '@shared/hooks';
import { getIdFromUrl, getTypeByValue } from '@shared/utils';

import { lobbyHubService, useLobbyStore } from '..';

const LobbyPage = () => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);
  const theme = useTheme();

  const [isAnonymous] = useUserStore((state) => [state.isAnonymous]);
  const [lobby] = useLobbyStore((state) => [state.lobby]);

  const [drawerOpen, setDrawerOpen] = useState(false);
  const [movies, setMovies] = useState<Movie[]>([]);
  const [isWheelVisible, setIsWheelVisible] = useState(false);
  const [openModal, setOpenModal] = useState(false);
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
    // TODO: refactor using store
    lobbyHubService.moviesChanged((value) => {
      setMovies(value);
      setMovie('');
    });
    if (!lobby) return;
    lobbyHubService.joinLobbyAnonymous(lobby.id, 'test');
    if (isAnonymous) setOpenModal(true); // выставил ! что б не вылазило при каждом сохранении
  }, []);

  const exitLobby = () => {
    navigate(Route.ROOT);
  };

  const handleChange = (newState: boolean) => {
    if (newState !== null) setIsWheelVisible(newState);
  };
  const handleMovieValue = (newMovie: string) => {
    switch (getTypeByValue(newMovie)) {
      case SearchType.ID: {
        lobbyHubService.addMovie(Number(newMovie));
        break;
      }
      case SearchType.NAME: {
        break;
      }
      case SearchType.LINK: {
        const id = getIdFromUrl(newMovie);
        if (!id || Number.isNaN(id)) {
          console.error('wrong url');
          break;
        }
        lobbyHubService.addMovie(id);
        break;
      }
    }
  };
  const debounce = useDebounce(handleMovieValue, 1000, true);

  const onMovieSet = (newMovie: string) => {
    setMovie(newMovie);
    debounce(newMovie);
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

            <EditLobby />
            <Button fullWidth variant="outlined" onClick={() => setDrawerOpen(true)}>
              {<HistoryIcon />} {t('lobbyHistory')}
            </Button>
            <LobbyHistory drawerOpen={drawerOpen} setDrawerOpen={setDrawerOpen} />
          </Box>
        </Grid>
      </Grid>
      <LobbyNicknameDialog open={openModal} setOpen={setOpenModal} />
    </Container>
  );
};

export default LobbyPage;
