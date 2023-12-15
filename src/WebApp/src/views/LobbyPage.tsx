import { Container, Typography, Box } from '@mui/material';
import { useParams } from 'react-router-dom';
import MovieList from '../components/MovieList';
import { Movie } from '../models/Movie';
import UsersList from '../components/UsersList';
import { useState } from 'react';
import MovieSearch from '../components/MovieSearch';

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
