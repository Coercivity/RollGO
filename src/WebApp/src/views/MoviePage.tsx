import { Box } from '@mui/material';
import MovieView from '../components/MovieView';
import Navbar from '../components/Navbar';

const MoviePage = () => {
  return (
    <Box>
      <Navbar />
      <MovieView />
    </Box>
  );
};

export default MoviePage;
