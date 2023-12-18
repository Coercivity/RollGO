import { useState } from 'react';
import { useTranslation } from 'react-i18next';
import { useNavigate } from 'react-router-dom';
import { Box, Button, Card, Link, TextField, Typography } from '@mui/material';

import { authService } from '@api/authService';
import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { Route } from '@enums/Route';
import { useAuthStore } from '@store/authStore';
import { useUserStore } from '@store/userStore';

const LogIn = () => {
  const { t } = useTranslation(LocalizationNamespace.AUTH);
  const setTokenPair = useAuthStore((state) => state.setTokenPair);
  const setUser = useUserStore((state) => state.setUser);
  const navigate = useNavigate();

  const [username, setUsername] = useState<string>('');
  const [password, setPassword] = useState<string>('');

  const onLogin = async () => {
    const data = await authService.login({
      username,
      password,
    });
    setTokenPair({ accessToken: data.accessToken, refreshToken: data.refreshToken });
    setUser(data.user, false);
    navigate(Route.ROOT);
  };

  return (
    <Box sx={{ display: 'flex', justifyContent: 'center', alignContent: 'center', mt: 20 }}>
      <Card
        sx={{
          display: 'flex',
          justifyContent: 'center',
          flexDirection: 'column',
          width: 500,
          p: 5,
        }}
      >
        <Typography variant="h6">{t('authorisation')}</Typography>
        <TextField
          margin="dense"
          label={t('enterLogin')}
          variant="standard"
          onChange={(e) => setUsername(e.target.value)}
        />
        <TextField
          margin="dense"
          type="password"
          label={t('enterPassword')}
          variant="standard"
          onChange={(e) => setPassword(e.target.value)}
        />
        <Box sx={{ mt: 2, display: 'flex', justifyContent: 'space-between' }}>
          <Typography>
            {t('dontHaveAccount')}
            <Link underline="none" href={Route.REGISTRATION}>
              {' '}
              {t('registrate')}{' '}
            </Link>
          </Typography>
          <Button variant="outlined" onClick={onLogin}>
            {t('logIn')}
          </Button>
        </Box>
      </Card>
    </Box>
  );
};

export default LogIn;
