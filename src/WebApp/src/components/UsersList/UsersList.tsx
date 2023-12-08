import { useState } from 'react';
import { useTranslation } from 'react-i18next';
import { Box, Card, Typography } from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { User } from '@models/User';

import UserView from '../UserView';

import UsersFilter from './UsersFilter';

const UsersList = () => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);

  const [users, setUsers] = useState<User[]>([
    { nickname: 'Yaroslav', isOnline: true },
    { nickname: 'Evgeniy', isOnline: false },
    { nickname: 'Alexander', isOnline: true },
  ]);
  const [filter, setFilter] = useState('');

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
          {t('playersInTheLobby')} {users.filter((x) => x.isOnline === true).length}/{users.length}{' '}
        </Typography>
        <UsersFilter filter={filter} setFilter={setFilter} users={users} setUsers={setUsers} />
        <Box>
          {users.map(({ nickname, isOnline }) => (
            <UserView
              key={nickname}
              nickname={nickname}
              onClick={() => console.log('user view clicked')}
              isOnline={isOnline}
            />
          ))}
        </Box>
      </Box>
    </Card>
  );
};

export default UsersList;
