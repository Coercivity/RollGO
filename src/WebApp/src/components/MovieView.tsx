import { FC, useEffect, useState } from 'react';
import { useTranslation } from 'react-i18next';
import ClearIcon from '@mui/icons-material/Clear';
import StarBorderIcon from '@mui/icons-material/StarBorder';
import { Box, Button, Card, Link, List, Skeleton, Typography } from '@mui/material';
import ImageListItem from '@mui/material/ImageListItem';

import { LocalizationNamespace } from '../enums/LocalizationNamespace';
import { Movie } from '../models/Movie';

interface MovieViewProps {
  remove: (m: Movie) => void;
  number: number;
  movie: Movie;
}

const MovieView: FC<MovieViewProps> = ({ remove, number, movie }) => {
  const [data, setData] = useState<Movie>();

  useEffect(() => {
    setData(movie);
  }, []);

  const { t } = useTranslation(LocalizationNamespace.MOVIE);
  return (
    <Card
      sx={{
        p: 1,
        display: 'flex',
        justifyContent: 'space-between',
        maxWidth: 1200,
        whiteSpace: 'nowrap',
      }}
    >
      <Typography sx={{ p: 1 }}> {number}.</Typography>
      {data ? (
        <Box flexGrow={1} sx={{ display: 'flex', flexDirection: 'row', gap: 35 }}>
          <Box sx={{ display: 'flex', flexDirection: 'row', m: 1, gap: 2 }}>
            <ImageListItem sx={{ width: 125, height: 150 }}>
              (
              <img src={data.posterUrlPreview} />)
            </ImageListItem>
            <List>
              <Link
                href={data.webUrl}
                underline="none"
                color="inherit"
                target="_blank"
                rel="noopener noreferrer"
              >
                <Typography
                  variant="h4"
                  sx={{
                    display: 'flex',
                    flexDirection: 'row',
                  }}
                >
                  {data && data.nameRu}
                </Typography>
              </Link>
              <Typography sx={{ display: 'flex' }}>
                {data ? (data.nameEn ? data.nameEn : data.nameOriginal) : ''}, {data && data.year},{' '}
                {data ? data.filmLength : ''} {t('minute')}, 16+
              </Typography>
              <Typography sx={{ color: 'text.secondary' }}>{t('movieGenre')}</Typography>
              <Typography sx={{ color: 'text.secondary' }}> {t('country')}</Typography>
              <Typography sx={{ color: 'text.secondary' }}> {t('director')}</Typography>
              <Typography sx={{ color: 'text.secondary' }}> {t('mainActors')}</Typography>
            </List>
          </Box>
          <Box
            sx={{
              display: 'flex',
              flexDirection: 'column',
              alignItems: 'center',
              justifyContent: 'center',
            }}
          >
            <Typography sx={{ display: 'flex' }}>
              {t('ratingKinopoisk')}:{data ? data.ratingKinopoisk : ''}
              <StarBorderIcon sx={{ maxWidth: 20 }} />
            </Typography>
            <Typography sx={{ display: 'flex' }}>
              {t('ratingIMDb')}: {data ? data.ratingImdb : ''}
              <StarBorderIcon
                sx={{
                  maxWidth: 20,
                }}
              />
            </Typography>
            <Button onClick={() => remove(data)} color="error">
              <ClearIcon />
            </Button>
          </Box>
        </Box>
      ) : (
        <Box flexGrow={1} sx={{ display: 'flex', flexDirection: 'row', gap: 35 }}>
          <Box sx={{ display: 'flex', flexDirection: 'row', m: 1, gap: 2 }}>
            <ImageListItem sx={{ maxWidth: 120 }}>
              <Skeleton animation="wave" variant="rectangular" width={120} height={160} />
            </ImageListItem>
            <List>
              <Skeleton animation="wave" height={30} width="9000%" />
              <Skeleton animation="wave" height={25} width="4000%" />
              <Skeleton animation="wave" height={25} width="3000%" />
              <Skeleton animation="wave" height={25} width="1000%" />
            </List>
          </Box>
        </Box>
      )}
    </Card>
  );
};

export default MovieView;
