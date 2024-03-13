import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { Box, Card, CardMedia, Drawer, List, Typography } from '@mui/material';

import { Movie } from '@entities/movie';
import { MovieData } from '@entities/movie/__mock__/movieData';
import { LocalizationNamespace } from '@shared/enums';

interface LobbyHistoryProps {
  drawerOpen: boolean;
  setDrawerOpen: (open: boolean) => void;
}

interface MockDataInterface {
  winner: string;
  date: string;
  movie: Movie;
}

const LobbyHistory: FC<LobbyHistoryProps> = ({ drawerOpen, setDrawerOpen }) => {
  const mockWinnerData: MockDataInterface[] = [
    { winner: 'serpens', date: '12.01.2024', movie: MovieData[0] },
    { winner: 'slavoyar', date: '10.01.2024', movie: MovieData[1] },
    { winner: 'serpens', date: '13.01.2024', movie: MovieData[2] },
    { winner: 'slavoyar', date: '14.01.2024', movie: MovieData[3] },
  ];

  const { t } = useTranslation(LocalizationNamespace.LOBBY);

  const toggleDrawer = () => {
    setDrawerOpen(!drawerOpen);
  };

  const rollList = () => (
    <>
      <Typography variant="h5" sx={{ direaction: 'flex', m: 2 }}>
        {t('lobbyHistory')}
      </Typography>
      {mockWinnerData.map((data) => (
        <Box sx={{ width: 500 }} key={Math.random()} role="presentation">
          <List>
            {data && (
              <Card sx={{ m: 2, mt: 1, display: 'flex', alignItems: 'center' }}>
                <Box sx={{ display: 'flex', flexDirection: 'row', alignItems: 'center' }}>
                  <CardMedia
                    component="img"
                    sx={{ width: 100 }}
                    image={data.movie.posterUrl}
                    alt="src image"
                  />
                  <Box sx={{ m: 2, mt: 1 }}>
                    <Typography sx={{ mb: 1 }} variant="h6">
                      {t('rolled')}
                      {data.date}
                    </Typography>
                    <Box>
                      <Typography sx={{ mr: 1 }} fontWeight={200} component="span">
                        {t('winner')}
                      </Typography>
                      <Typography fontWeight={500} component="span">
                        {data.winner}
                      </Typography>
                    </Box>
                    <Box>
                      <Typography sx={{ mr: 1 }} fontWeight={100} component="span">
                        {t('selectedMovie')}
                      </Typography>
                      <Typography fontWeight={500} component="span">
                        {data.movie.nameRu}
                      </Typography>
                    </Box>
                  </Box>
                </Box>
              </Card>
            )}
          </List>
        </Box>
      ))}
    </>
  );

  return (
    <Drawer anchor="right" open={drawerOpen} onClose={() => toggleDrawer()}>
      {rollList()}
    </Drawer>
  );
};

export default LobbyHistory;
