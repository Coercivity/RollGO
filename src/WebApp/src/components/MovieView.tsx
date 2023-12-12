import { Box, Card, Typography, List, Link } from '@mui/material';
import ImageListItem from '@mui/material/ImageListItem';
import { LocalizationNamespace } from '../enums/LocalizationNamespace';
import { useTranslation } from 'react-i18next';
import axios from 'axios';
import { useEffect, useState } from 'react';
import { Movie } from '../models/Movie';
import StarBorderIcon from '@mui/icons-material/StarBorder';

const src = 'https://kinopoiskapiunofficial.tech/api/v2.2/films/51078';

const MovieView = () => {
  const [data, setData] = useState<Movie>();

  useEffect(() => {
    const response = axios.get(src, {
      method: 'GET',
      headers: {
        'X-API-KEY': import.meta.env.VITE_KINOPOISK_API_KEY,
        'Content-Type': 'application/json',
      },
    });
    response.then((d) => {
      console.log(d.data);
      setData(d.data);
    });
  }, []);

  const { t } = useTranslation(LocalizationNamespace.MOVIE);
  return (
    <Card sx={{ display: 'flex', justifyContent: 'space-between', maxWidth: 900 }}>
      <Box flexGrow={1} sx={{ display: 'flex', flexDirection: 'row', gap: 35 }}>
        <Box sx={{ display: 'flex', flexDirection: 'row', m: 1, gap: 2 }}>
          <ImageListItem sx={{ maxWidth: 120 }}>
            <img src={data?.posterUrlPreview} alt="movie-img" />
          </ImageListItem>
          <List>
            <Link
              href={data ? data.webUrl : ''}
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
            <Typography>
              {data ? (data.nameEn ? data.nameEn : data.nameOriginal) : ''}, {data && data.year},
              {data ? data.filmLength : ''} {t('minute')}, 16+
            </Typography>
            <Typography sx={{ color: 'text.secondary' }}>{t('movieGenre')}</Typography>
            <Typography sx={{ color: 'text.secondary' }}> {t('country')}</Typography>
            <Typography sx={{ color: 'text.secondary' }}> {t('director')}</Typography>
            <Typography sx={{ color: 'text.secondary' }}> {t('mainActors')}</Typography>
          </List>
        </Box>
        <Typography
          sx={{
            display: 'flex',
            flexDirection: 'column',
            alignItems: 'center',
            justifyContent: 'center',
          }}
        >
          <Typography sx={{ display: 'flex' }}>
            {t('ratingKinopoisk')}:
            <Typography sx={{ display: 'flex' }}>{data ? data.ratingKinopoisk : ''}</Typography>
            <StarBorderIcon sx={{ maxWidth: 20 }} />
          </Typography>
          <Typography sx={{ display: 'flex' }}>
            {t('ratingIMDb')}:
            <Typography sx={{ display: 'flex' }}>{data ? data.ratingImdb : ''}</Typography>
            <StarBorderIcon
              sx={{
                maxWidth: 20,
              }}
            />
          </Typography>
        </Typography>
      </Box>
    </Card>
  );
};

export default MovieView;
