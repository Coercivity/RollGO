import { TextField, Box, Typography, Button, Card, Link } from '@mui/material';
import { Route } from '../enums/Route';

import { LocalizationNamespace } from '../enums/LocalizationNamespace';
import { useTranslation } from 'react-i18next';

const LogIn = () => {
  const { t } = useTranslation(LocalizationNamespace.AUTH);

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
        <TextField margin="dense" label={t('enterEmail')} variant="standard" />
        <TextField margin="dense" type="password" label={t('enterPassword')} variant="standard" />
        <Box sx={{ mt: 2, display: 'flex', justifyContent: 'space-between' }}>
          <Typography>
            {t('dontHaveAccount')}
            <Link underline="none" to={Route.REGISTRATION}>
              {' '}
              {t('registrate')}{' '}
            </Link>
          </Typography>
          <Button variant="outlined">{t('logIn')}</Button>
        </Box>
      </Card>
    </Box>
  );
};

export default LogIn;
