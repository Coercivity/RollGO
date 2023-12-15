import { useState } from 'react';
import { useParams } from 'react-router-dom';
import { Box, Container, Typography } from '@mui/material';

import MovieList from '../components/MovieList';
import MovieSearch from '../components/MovieSearch';
import UsersList from '../components/UsersList/UsersList';
import { Movie } from '../models/Movie';

type LobbyParams = {
  lobbyId: string;
};

const LobbyPage = () => {
  const [movies, setMovies] = useState<Movie[]>([]);

  const { lobbyId } = useParams<LobbyParams>();
  return (
    <Box>
      <Container maxWidth="lg" sx={{ textAlign: 'center', mt: 6 }}>
        <Typography variant="h3">Комната {lobbyId}.</Typography>
        <MovieSearch movies={movies} setMovies={setMovies} />
      </Container>
      <Container sx={{ display: 'flex' }}>
        <MovieList movies={movies} setMovies={setMovies} />
        <Box sx={{ display: 'flex', justifyContent: 'flex-end' }}>
          <UsersList />
        </Box>
      </Container>
    </Box>
  );
};

export default LobbyPage;
