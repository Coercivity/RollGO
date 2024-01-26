import { FC, KeyboardEvent } from 'react';
import { useTranslation } from 'react-i18next';
import { Autocomplete, TextField } from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { Movie } from '@models/Movie';

import { MovieData } from '../../../mockAPI/MovieData';

interface SearchProps {
  movies: Movie[];
  setMovies: (movies: Movie[]) => void;
}

const SearchAppBar: FC<SearchProps> = ({ movies, setMovies }) => {
  const { t } = useTranslation(LocalizationNamespace.MOVIE);

  const onKeyDown = (
    event: KeyboardEvent<HTMLDivElement> & { defaultMuiPrevented?: boolean | undefined }
  ) => {
    if (event.key === 'Enter') {
      console.error(event);
    }
  };

  return (
    <Autocomplete
      multiple
      limitTags={3}
      sx={{ minWidth: 10 }}
      getOptionLabel={(option) => option.nameRu}
      renderInput={(params) => <TextField {...params} label={t('movieSearch')} />}
      options={MovieData}
      onKeyDown={onKeyDown}
      value={movies}
      onChange={(_, value) => setMovies(value)}
    />
  );
};

export default SearchAppBar;
