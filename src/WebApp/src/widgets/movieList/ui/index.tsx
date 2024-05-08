import { Box, Divider, Stack, Typography } from '@mui/material';
import { FC } from 'react';
import { useTranslation } from 'react-i18next';

import { Movie, MovieView } from '@entities/movie';

import { LocalizationNamespace } from '@shared/enums';

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
        color="primary.contrastText"
        sx={{ flexGrow: 1, display: 'flex', alignItems: 'center', justifyContent: 'center' }}
      >
        {t('moviesAreNotAddedYet')}
      </Typography>
    );
  }

  return (
    <Stack spacing={2} sx={{ height: '100%' }}>
      {movies.map((movie: Movie, index: number) => (
        <Box key={movie.kinopoiskId}>
          <MovieView remove={remove} number={index + 1} movie={movie} />
          <Divider sx={{ mt: 1 }} light={false} />
        </Box>
      ))}
    </Stack>
  );
};

export default MovieList;
