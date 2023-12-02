import { FC } from 'react';
import { Button, Box } from '@mui/material';

interface LobbyViewProps {
  remove: (lobby: string) => void;
  number: number;
  lobby: string;
}

const LobbyView: FC<LobbyViewProps> = ({ remove, number, lobby }) => {
  return (
    <Box
      sx={{
        display: 'flex',
        justifyContent: 'space-between',
        flexDirection: 'row',
        m: 1,
        gap: 1,
      }}
    >
      {number}. {lobby}
      <Button variant="outlined" color="error" onClick={() => remove(lobby)}>
        Удалить
      </Button>
    </Box>
  );
};

export default LobbyView;
