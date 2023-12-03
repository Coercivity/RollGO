import {
  Input,
  Box,
  Typography,
  Button,
  Card,
  FormGroup,
  Checkbox,
  FormControlLabel,
} from '@mui/material';
import { NavLink } from 'react-router-dom';
import { Route } from '../enums/Route';

import { LocalizationNamespace } from '../enums/LocalizationNamespace';
import { useTranslation } from 'react-i18next';

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
        <Input placeholder="Введите ваш e-mail" />
        <Input placeholder="Введите имя пользователя" />
        <Input placeholder="Введите пароль" type="password" />
        <Input placeholder="Подтвердите пароль" type="password" />
        <Typography>
          <FormGroup>
            <FormControlLabel
              control={<Checkbox />}
              required
              label={
                <Typography>
                  Я согласен(на) с <NavLink to={Route.RULES}> правилами</NavLink> RollGo.
                </Typography>
              }
            />
          </FormGroup>
        </Typography>

        <Box sx={{ mt: 1, display: 'flex', justifyContent: 'space-between' }}>
          <Typography>
            Есть аккаунт?
            <NavLink to={Route.LOGIN}> Войдите! </NavLink>
          </Typography>
          <Button variant="outlined">Регистрация</Button>
        </Box>
      </Card>
    </Box>
  );
};

export default Registration;
