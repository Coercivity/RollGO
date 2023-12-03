import { Container, Typography } from '@mui/material';
import { useParams } from 'react-router-dom';

type LobbyParams = {
  lobbyId: string;
};

const LobbyPage = () => {
  const { lobbyId } = useParams<LobbyParams>();
  return (
    <Container maxWidth="lg" sx={{ textAlign: 'center', mt: 2 }}>
      <Typography variant="h3">LobbyPage</Typography>
      <Typography variant="h4">{lobbyId}</Typography>
    </Container>
  );
};

export default LobbyPage;
