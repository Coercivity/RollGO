import { useParams } from 'react-router-dom';
import { Container, Typography } from '@mui/material';

import UsersList from '@components/UsersList';

type LobbyParams = {
  lobbyId: string;
};

const LobbyPage = () => {
  const { lobbyId } = useParams<LobbyParams>();
  return (
    <Container maxWidth="lg" sx={{ textAlign: 'center', mt: 2 }}>
      <Typography variant="h3">Комната {lobbyId}.</Typography>

      <UsersList />
    </Container>
  );
};

export default LobbyPage;
