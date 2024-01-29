import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import HistoryIcon from '@mui/icons-material/History';
import { Box, Button, Card, CardMedia, Drawer, List, Typography } from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';

interface LobbyHistoryProps {
  drawerOpen: boolean;
  setDrawerOpen: (open: boolean) => void;
}

const LobbyHistory: FC<LobbyHistoryProps> = ({ drawerOpen, setDrawerOpen }) => {
import { Movie } from '@models/Movie';

import { MovieData } from '../../mockAPI/MovieData';

interface MockDataInterface {
  winner: string;
  date: string;
  movie: Movie;
}

const LobbyHistory = () => {
  const mockWinnerData: MockDataInterface[] = [
    { winner: 'serpens', date: '12.01.2024', movie: MovieData[0] },
    { winner: 'slavoyar', date: '10.01.2024', movie: MovieData[1] },
    { winner: 'serpens', date: '13.01.2024', movie: MovieData[2] },
    { winner: 'slavoyar', date: '14.01.2024', movie: MovieData[3] },
  ];

  const [drawerOpen, setDrawerOpen] = useState(false);
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
