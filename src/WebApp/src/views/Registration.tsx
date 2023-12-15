import { useTranslation } from 'react-i18next';
import {
  Box,
  Button,
  Card,
  Checkbox,
  FormControlLabel,
  FormGroup,
  Link,
  TextField,
  Typography,
} from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { Route } from '@enums/Route';

const Registration = () => {
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
        <Typography variant="h6">{t('registration')}</Typography>
        <TextField margin="dense" label={t('enterEmail')} variant="standard" />
        <TextField margin="dense" label={t('enterLogin')} variant="standard" />
        <TextField margin="dense" label={t('enterPassword')} variant="standard" />
        <TextField margin="dense" label={t('confirmPassword')} variant="standard" />
        <FormGroup sx={{ mt: 1 }}>
          <FormControlLabel
            control={<Checkbox />}
            required
            label={
              <Typography>
                {t('iAcceptThe')}{' '}
                <Link underline="none" href={Route.RULES}>
                  {t('rules')}
                </Link>{' '}
                RollGO
              </Typography>
            }
          />
        </FormGroup>
        <Box sx={{ mt: 1, display: 'flex', justifyContent: 'space-between' }}>
          <Typography>
            {t('haveAccount')}
            <Link underline="none" href={Route.LOGIN}>
              {' '}
              {t('logIn!')}{' '}
            </Link>
          </Typography>
          <Button variant="outlined">{t('registration')}</Button>
        </Box>
      </Card>
    </Box>
  );
};

export default Registration;
