import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { Input } from '@mui/material';

import { LocalizationNamespace } from '@shared/enums';

interface SearchProps {
  movie: string;
  setMovie: (id: string) => void;
}

const MovieSearch: FC<SearchProps> = ({ movie, setMovie }) => {
  const { t } = useTranslation(LocalizationNamespace.MOVIE);

  return (
    <Input
      sx={{ minWidth: 10, width: '100%' }}
      value={movie}
      onChange={(e) => setMovie(e.target.value)}
      placeholder={t('movieSearch')}
    />
  );
};

export default MovieSearch;
