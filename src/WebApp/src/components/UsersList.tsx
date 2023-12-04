import { Box, Card } from '@mui/material';
import UserView from './UserView';

const nickname = 'Yaroslav';

const UsersList = () => {
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
