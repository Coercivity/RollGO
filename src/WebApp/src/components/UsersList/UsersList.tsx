import { Box, Card, Typography } from '@mui/material';
import UserView from '../UserView';
import { useState } from 'react';
import UsersFilter from './UsersFilter';

const someBackEnd = [{ nickname: 'Yaroslav', isOnline: 'true' }];
const onClick = () => {};

const UsersList = () => {
  const [filter, setFilter] = useState({ sort: '', query: '' });

  return (
    <Card
      sx={{
        bgcolor: 'primary.main',
        display: 'flex',
        justifyContent: 'flex-end',
        flexDirection: 'column',
        width: 200,
        p: 1,
        bg: 'grey.500',
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
        <Typography variant="h6" color="white">
          Игроков в лобби {}/{}{' '}
        </Typography>
        <UsersFilter filter={filter} setFilter={setFilter} />
        <Box>
          {someBackEnd.map((nickname, isOnline) => (
            <UserView nickname={nickname} onClick={onClick} isOnline={isOnline} />
          ))}
        </Box>
      </Box>
    </Card>
  );
};

export default UsersList;
