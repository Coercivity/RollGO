import { FC, useState } from 'react';
import { useTranslation } from 'react-i18next';
import { Box, Card, Typography } from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { User } from '@models/User';

import UserView from '../UserView';

import UsersFilter from './UsersFilter';

const UsersList: FC = () => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);

  const [users, setUsers] = useState<User[]>([
    { id: '1', username: 'Yaroslav', isOnline: true },
    { id: '2', username: 'Evgeniy', isOnline: false },
    { id: '3', username: 'Alexander', isOnline: true },
  ]);
  const [filter, setFilter] = useState('');

  return (
    <Card
      sx={{
        bgcolor: 'primary.main',

        p: 1,
        bg: 'grey.500',
      }}
    >
      <Typography variant="h6" color="white">
        {t('playersInTheLobby')} {users.filter((x) => x.isOnline === true).length}/{users.length}{' '}
      </Typography>
      <UsersFilter filter={filter} setFilter={setFilter} users={users} setUsers={setUsers} />
      <Box
        sx={{
          display: 'flex',
          flexDirection: 'column',
          justifyContent: 'left',
          alignItems: 'flex-start',
        }}
      >
        {users.map(({ id, username, isOnline }) => (
          <UserView
            key={id}
            nickname={username}
            onClick={() => console.log('user view clicked')}
            isOnline={isOnline}
          />
        ))}
      </Box>
    </Card>
  );
};

export default UsersList;
