import { Card, Grid, Typography } from '@mui/material';
import { FC, useEffect, useState } from 'react';
import { useTranslation } from 'react-i18next';

import { lobbyHubService } from '@entities/lobby';
import { User, UserView } from '@entities/user';

import { LocalizationNamespace } from '@shared/enums';

const UsersList: FC = () => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);

  const [users, setUsers] = useState<User[]>([]);

  useEffect(() => {
    lobbyHubService.onMessageReceive('UserJoined', (value) => setUsers(value as User[]));
  }, []);

  return (
    <Card sx={{ p: 1 }}>
      <Typography variant="h6" color="white">
        {t('playersInTheLobby')}: {users.filter((x) => x.isOnline).length}/{users.length}{' '}
      </Typography>
      <Grid container rowSpacing={1} columns={{ md: 12 }} sx={{ mt: 1 }}>
        {users.map(({ id, username, isOnline }) => (
          <Grid key={id} md={6} item>
            <UserView nickname={username} isOnline={isOnline} isInNavbar={false} />
          </Grid>
        ))}
      </Grid>
    </Card>
  );
};

export default UsersList;
