import { useParams } from 'react-router-dom';
import { Box, Container, Typography } from '@mui/material';

import UsersList from '@components/UsersList/UsersList';

type LobbyParams = {
  lobbyId: string;
};

const LobbyPage = () => {
  const { lobbyId } = useParams<LobbyParams>();
  return (
    <Container maxWidth="lg" sx={{ textAlign: 'center', mt: 2 }}>
      <Typography variant="h3">Комната {lobbyId}.</Typography>
      <Box sx={{ mt: 2, display: 'flex', justifyContent: 'flex-end' }}>
        <UsersList />
      </Box>
    </Container>
  );
};

export default LobbyPage;
