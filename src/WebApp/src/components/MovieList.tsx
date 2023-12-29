import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { Box, Typography } from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';

import { Movie } from '../models/Movie';

import MovieView from './MovieView';

interface MoviesListProps {
  movies: Movie[];
  setMovies: (movies: Movie[]) => void;
}

const MovieList: FC<MoviesListProps> = ({ setMovies, movies }) => {
  const { t } = useTranslation(LocalizationNamespace.MOVIE);
  const remove = (m: Movie) => {
    setMovies(movies.filter((movie: Movie) => movie.kinopoiskId !== m.kinopoiskId));
  };

  if (!movies.length) {
    return (
      <Typography
        variant="h6"
        component="div"
        sx={{ flexGrow: 1, display: 'flex', alignItems: 'center', justifyContent: 'center' }}
      >
        {t('moviesAreNotAddedYet')}
      </Typography>
    );
  }

  return (
    <Box>
      {movies.map((movie: Movie, index: number) => (
        <MovieView remove={remove} number={index + 1} movie={movie} key={movie.kinopoiskId} />
      ))}
    </Box>
  );
};

export default MovieList;
