import { Input, Box, Typography, Button, Card } from '@mui/material';
import { NavLink } from 'react-router-dom';
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
        <Input placeholder="Введите ваш e-mail" />
        <Input placeholder="Введите пароль" type="password" />
        <Box sx={{ mt: 1, display: 'flex', justifyContent: 'space-between' }}>
          <Typography>
            Нет аккаунта?
            <NavLink to={Route.REGISTRATION}> Зарегистрируйся! </NavLink>
          </Typography>
          <Button variant="outlined">Войти</Button>
        </Box>
      </Card>
    </Box>
  );
};

export default LogIn;
