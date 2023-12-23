import { useEffect, useState } from 'react';
import { useTranslation } from 'react-i18next';
import { useNavigate } from 'react-router-dom';
import { useParams } from 'react-router-dom';
import ExitToAppIcon from '@mui/icons-material/ExitToApp';
import {
  Box,
  Container,
  IconButton,
  ToggleButton,
  ToggleButtonGroup,
  Typography,
} from '@mui/material';

import LobbyNicknameModal from '@components/LobbyNicknameModal';
import MovieList from '@components/MovieList';
import MovieSearch from '@components/MovieSearch';
import SpinningWheel from '@components/SpiningWheel';
import UsersList from '@components/UsersList/UsersList';
import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { Route } from '@enums/Route';
import { Movie } from '@models/Movie';
import { useUserStore } from '@store/userStore';

type LobbyParams = {
  lobbyId: string;
};

const LobbyPage = () => {
  const [movies, setMovies] = useState<Movie[]>([]);
  const [isWheelVisible, setIsWheelVisible] = useState(false);
  const { t } = useTranslation(LocalizationNamespace.MOVIE);

  const [openModal, setOpenModal] = useState(false);
  const [isAnonymous, setUser] = useUserStore((state) => [state.isAnonymous, state.setUser]);

  useEffect(() => {
    if (isAnonymous) setOpenModal(true);
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
    <Container maxWidth="lg">
      <Box sx={{ textAlign: 'center', mt: 6 }}>
        <Box sx={{ display: 'flex', textAlign: 'left', justifyContent: 'left' }}>
          <IconButton color="primary" onClick={exitLobby}>
            <ExitToAppIcon />
          </IconButton>
          <Typography variant="h4">{t('room')}</Typography>
          <Typography sx={{ ml: 3 }} variant="h4" color="text.secondary">
            {lobbyId}
          </Typography>
        </Box>
      </Box>
      <Box sx={{ display: 'flex', justifyContent: 'space-between' }}>
        {!isWheelVisible ? (
          <Box sx={{ mt: 3 }}>
            <Box sx={{ display: 'flex', justifyContent: 'flex-start' }}>
              <MovieSearch movies={movies} setMovies={setMovies} />
            </Box>
            <MovieList movies={movies} setMovies={setMovies} />
          </Box>
        ) : (
          <Box sx={{ m: 3 }}>
            <SpinningWheel movies={movies} />
          </Box>
        )}

        <Box sx={{ mt: 4 }}>
          <ToggleButtonGroup
            fullWidth
            size="small"
            color="primary"
            value={isWheelVisible}
            onChange={(_, value) => handleChange(value)}
            exclusive
            aria-label="Platform"
          >
            <ToggleButton value={false}>Список фильмов</ToggleButton>
            <ToggleButton value={true}>Колесо</ToggleButton>
          </ToggleButtonGroup>
          <UsersList />
        </Box>
      </Box>
      <LobbyNicknameModal open={openModal} setOpen={setOpenModal} />
    </Container>
  );
};

export default LobbyPage;
