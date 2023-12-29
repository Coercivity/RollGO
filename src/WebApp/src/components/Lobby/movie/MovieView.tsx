import { FC, useEffect, useState } from 'react';
import { useTranslation } from 'react-i18next';
import ClearIcon from '@mui/icons-material/Clear';
import StarBorderIcon from '@mui/icons-material/StarBorder';
import { Box, Card, Grid, IconButton, Link, List, Skeleton, Typography } from '@mui/material';
import ImageListItem from '@mui/material/ImageListItem';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { Movie } from '@models/Movie';

interface MovieViewProps {
  remove: (m: Movie) => void;
  number: number;
  movie: Movie;
}

const MovieView: FC<MovieViewProps> = ({ remove, movie }) => {
  const [data, setData] = useState<Movie>();

  useEffect(() => {
    setData(movie);
  }, [movie]);

  const { t } = useTranslation(LocalizationNamespace.MOVIE);
  return (
    <>
      {data ? (
        <Card>
          <Grid container spacing={1}>
            <Grid item xs={2}>
              <img width="100%" src={data.posterUrl} />
            </Grid>
            <Grid item xs={10}>
              <Grid container>
                <Grid item xs={11}>
                  <Link
                    href={data.webUrl}
                    underline="none"
                    color="inherit"
                    target="_blank"
                    rel="noopener noreferrer"
                  >
                    <Typography variant="h4">{data && data.nameRu}</Typography>
                  </Link>
                </Grid>
                <Grid item xs={1}>
                  <IconButton size="small" onClick={() => remove(data)} color="secondary">
                    <ClearIcon />
                  </IconButton>
                </Grid>
              </Grid>
              <Grid container>
                <Grid item xs={6}>
                  <List>
                    <Typography sx={{ display: 'flex' }}>
                      {data ? (data.nameEn ? data.nameEn : data.nameOriginal) : ''},{' '}
                      {data && data.year}, {data ? data.filmLength : ''} {t('minute')}
                    </Typography>
                    <Typography sx={{ color: 'text.secondary' }}>{t('movieGenre')}</Typography>
                    <Typography sx={{ color: 'text.secondary' }}> {t('country')}</Typography>
                    <Typography sx={{ color: 'text.secondary' }}> {t('director')}</Typography>
                    <Typography sx={{ color: 'text.secondary' }}> {t('mainActors')}</Typography>
                  </List>
                </Grid>
                <Grid item xs={6}>
                  <List>
                    <Typography sx={{ display: 'flex', alignItems: 'center' }}>
                      {t('ratingKinopoisk')}: {data ? data.ratingKinopoisk : ''}
                      <StarBorderIcon />
                    </Typography>
                    <Typography sx={{ display: 'flex', alignItems: 'center' }}>
                      {t('ratingIMDb')}: {data ? data.ratingImdb : ''}
                      <StarBorderIcon />
                    </Typography>
                  </List>
                </Grid>
              </Grid>
            </Grid>
          </Grid>
        </Card>
      ) : (
        <Card>
          <Box flexGrow={1} sx={{ display: 'flex', flexDirection: 'row', gap: 35 }}>
            <Box sx={{ display: 'flex', flexDirection: 'row', m: 1 }}>
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
        </Card>
      )}
    </>
  );
};

export default MovieView;
