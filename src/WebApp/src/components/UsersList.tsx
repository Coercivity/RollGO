import { Box, Card } from '@mui/material';
import { FC } from 'react';
import UserView from './UserView';

interface UsersListProps {
  nickname: string;
}

const UsersList: FC<LobbyListProps> = ({ nickname }) => {
  return (
    <Card
      sx={{
        display: 'flex',
        justifyContent: 'flex-end',
        flexDirection: 'column',
        width: 200,
        p: 1,
      }}
    >
      <Box
        sx={{
          display: 'flex',
          justifyContent: 'center',
          flexDirection: 'column',
          width: 200,
        }}
      >
        <Box>
          Игроков в лобби {}/{}{' '}
        </Box>
        <UserView nickname={nickname} />
      </Box>
    </Card>
  );
};

export default UsersList;
