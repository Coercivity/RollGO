import { useEffect, useState } from 'react';
import { useTranslation } from 'react-i18next';
import { useNavigate } from 'react-router-dom';
import { useParams } from 'react-router-dom';
import ExitToAppIcon from '@mui/icons-material/ExitToApp';
import SettingsIcon from '@mui/icons-material/Settings';
import {
  Box,
  Button,
  Container,
  IconButton,
  ToggleButton,
  ToggleButtonGroup,
  Typography,
} from '@mui/material';

import LobbyHistory from '@components/LobbyHistory';
import LobbyNicknameModal from '@components/LobbyNicknameModal';
import LobbySettings from '@components/LobbySettings';
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

  const { t } = useTranslation(LocalizationNamespace.LOBBY);

  const [openModal, setOpenModal] = useState(false);
  const [settingsOpen, setSettingsOpen] = useState(false);
  const [isAnonymous, setUser] = useUserStore((state) => [state.isAnonymous, state.setUser]);

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
    <Container maxWidth="lg">
      <Box>
        <Box sx={{ display: 'flex', textAlign: 'left', justifyContent: 'left' }}>
          <IconButton color="primary" onClick={exitLobby}>
            <ExitToAppIcon />
          </IconButton>
          <Typography variant="h4" color="text.secondary">
            {t('room')}
          </Typography>
          <Typography sx={{ ml: 2 }} variant="h4">
            {lobbyId}
          </Typography>
        </Box>
      </Box>
      <Box sx={{ display: 'flex', justifyContent: 'space-between' }}>
        {!isWheelVisible ? (
          <Box>
            <MovieSearch movies={movies} setMovies={setMovies} />
            <MovieList movies={movies} setMovies={setMovies} />
          </Box>
        ) : (
          <Box>
            <SpinningWheel movies={movies} />
          </Box>
        )}

        <Box>
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
            lobbyId={lobbyId}
            settingsOpen={settingsOpen}
            setSettingsOpen={setSettingsOpen}
          />
          <LobbyHistory />
        </Box>
      </Box>
      <LobbyNicknameModal open={openModal} setOpen={setOpenModal} />
    </Container>
  );
};

export default LobbyPage;
