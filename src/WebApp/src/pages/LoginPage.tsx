import { useState } from 'react';
import { useTranslation } from 'react-i18next';
import { useNavigate } from 'react-router-dom';
import ErrorOutlineIcon from '@mui/icons-material/ErrorOutline';
import { Box, Button, Card, Link, TextField, Typography } from '@mui/material';

import { authService } from '@api/authService';
import { ErrorCode } from '@enums/ErrorCode';
import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { Route } from '@enums/Route';
import { useAuthStore } from '@store/authStore';
import { useUserStore } from '@store/userStore';

import { handleError } from '../utils/validationUtils';

const LoginPage = () => {
  const { t } = useTranslation([LocalizationNamespace.AUTH, LocalizationNamespace.VALIDATIONS]);
  const setTokenPair = useAuthStore((state) => state.setTokenPair);
  const setUser = useUserStore((state) => state.setUser);
  const navigate = useNavigate();

  const [username, setUsername] = useState<string>('');
  const [password, setPassword] = useState<string>('');

  const [error, setError] = useState<ErrorCode>();

  const onLogin = async () => {
    try {
      const data = await authService.login({
        username,
        password,
      });
      setTokenPair({ accessToken: data.accessToken, refreshToken: data.refreshToken });
      setUser(data.user);
      navigate(Route.ROOT);
    } catch (e) {
      handleError(e, setError);
    }
  };

  return (
    <Box
      sx={{
        display: 'flex',
        justifyContent: 'center',
        alignContent: 'center',
        alignItems: 'center',
        height: '100%',
      }}
    >
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
          error={error === ErrorCode.WrongUsernameOrPassword}
        />
        <TextField
          margin="dense"
          type="password"
          label={t('enterPassword')}
          variant="standard"
          onChange={(e) => setPassword(e.target.value)}
          error={error === ErrorCode.WrongUsernameOrPassword}
        />
        {error && (
          <Box sx={{ display: 'flex', alignItems: 'center' }}>
            {<ErrorOutlineIcon color="error" />}
            <Typography color="error" sx={{ fontSize: 14, fontWeight: 'light', ml: 0.5 }}>
              {t(error, { ns: LocalizationNamespace.VALIDATIONS })}
            </Typography>
          </Box>
        )}
        <Box sx={{ mt: 2, display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
          <Typography>
            {t('dontHaveAccount')}
            <Link underline="none" sx={{ ml: 0.5 }} href={Route.REGISTRATION}>
              {t('registrate')}
            </Link>
          </Typography>
          <Button variant="contained" color="primary" onClick={onLogin}>
            {t('logIn')}
          </Button>
        </Box>
      </Card>
    </Box>
  );
};

export default LoginPage;
