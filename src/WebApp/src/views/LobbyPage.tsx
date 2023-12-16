import { useState } from 'react';
import { useTranslation } from 'react-i18next';
import { useParams } from 'react-router-dom';
import { Box, Container, Typography } from '@mui/material';

import MovieList from '@components/MovieList';
import MovieSearch from '@components/MovieSearch';
import UsersList from '@components/UsersList/UsersList';
import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { Movie } from '@models/Movie';

type LobbyParams = {
  lobbyId: string;
};

const LobbyPage = () => {
  const [movies, setMovies] = useState<Movie[]>([]);
  const { t } = useTranslation(LocalizationNamespace.MOVIE);
  const { lobbyId } = useParams<LobbyParams>();
  return (
    <Box>
      <Container maxWidth="lg" sx={{ textAlign: 'center', mt: 6 }}>
        <Box sx={{ display: 'flex', textAlign: 'center', justifyContent: 'center' }}>
          <Typography variant="h3">{t('room')}</Typography>
          <Typography sx={{ ml: 4 }} variant="h3">
            {lobbyId}
          </Typography>
        </Box>
        <Box sx={{ display: 'flex', justifyContent: 'flex-start', mt: 3 }}>
          <MovieSearch movies={movies} setMovies={setMovies} />
        </Box>
      </Container>
      <Container sx={{ display: 'flex', justifyContent: 'space-between' }}>
        <MovieList movies={movies} setMovies={setMovies} />
        <Box sx={{ mt: 4 }}>
          <UsersList />
        </Box>
      </Container>
    </Box>
  );
};

export default LobbyPage;
