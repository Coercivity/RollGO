import { FC, useEffect, useState } from 'react';
import { useTranslation } from 'react-i18next';
import { Card, Grid, Typography } from '@mui/material';

import UserView from '@components/common/UserView';
import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { User } from '@models/User';
import { useUserStore } from '@store/userStore';

import UsersFilter from './UsersFilter';

interface UserListProps {
  adminId: string;
}

const UsersList: FC<UserListProps> = ({ adminId }) => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);

  const [users, setUsers] = useState<User[]>([
    { id: '1', username: 'Yaroslav', isOnline: true },
    { id: '2', username: 'Evgeniy', isOnline: false },
    { id: '3', username: 'Alexander', isOnline: true },
  ]);
  const [filter, setFilter] = useState('');
  const [storeUsername, storeId] = useUserStore((state) => [state.username, state.id]);
  useEffect(() => {
    setUsers([...users, { id: storeId, username: storeUsername, isOnline: true }]);
  }, []);

  return (
    <Card sx={{ p: 1 }}>
      <Typography variant="h6" color="white">
        {t('playersInTheLobby')}: {users.filter((x) => x.isOnline === true).length}/{users.length}{' '}
      </Typography>
      <UsersFilter filter={filter} setFilter={setFilter} users={users} setUsers={setUsers} />
      <Grid container rowSpacing={1} columns={{ md: 12 }} sx={{ mt: 1 }}>
        {users.map(({ id, username, isOnline }) => (
          <Grid key={id} md={6} item>
            <UserView
              nickname={username}
              isOnline={isOnline}
              isInNavbar={false}
              isLeader={id === adminId}
            />
          </Grid>
        ))}
      </Grid>
    </Card>
  );
};

export default UsersList;
