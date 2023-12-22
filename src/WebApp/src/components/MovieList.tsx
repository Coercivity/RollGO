import { FC } from 'react';
import { Box, Typography } from '@mui/material';

import { Movie } from '../models/Movie';

import MovieView from './MovieView';

interface MoviesListProps {
  movies: Movie[];
  setMovies: (movies: Movie[]) => void;
}

const MovieList: FC<MoviesListProps> = ({ setMovies, movies }) => {
  const remove = (m: Movie) => {
    setMovies(movies.filter((movie: Movie) => movie.kinopoiskId !== m.kinopoiskId));
  };

  if (!movies.length) {
    return (
      <Box sx={{ display: 'flex', justifyContent: 'center', m: 3 }}>
        <Typography
          variant="h6"
          component="div"
          sx={{ flexGrow: 1, display: 'flex', alignItems: 'center', justifyContent: 'center' }}
        >
          Пока не добавлено ни одного фильма!
        </Typography>
      </Box>
    );
  }

  return (
    <Box sx={{ m: 3 }}>
      {movies.map((movie: Movie, index: number) => (
        <MovieView remove={remove} number={index + 1} movie={movie} key={movie.kinopoiskId} />
      ))}
    </Box>
  );
};

export default MovieList;
