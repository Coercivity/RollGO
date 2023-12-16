import React, { useState } from 'react';
import { useTranslation } from 'react-i18next';
import { Box, Button, Card, Link, TextField, Typography } from '@mui/material';

import { authService } from '@api/authService';
import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { Route } from '@enums/Route';

const Registration = () => {
  const { t } = useTranslation(LocalizationNamespace.AUTH);
  const [email, setEmail] = useState<string>('');
  const [emailError, setEmailError] = useState(false);
  const [username, setUsername] = useState<string>('');
  const [password, setPassword] = useState<string>('');
  const [confirmPassword, setConfirmPassword] = useState<string>();
  const [passwordError, setPasswordError] = useState(false);

  const onEmailChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    if (emailError && !e.target.validationMessage) {
      setEmailError(false);
    }
    setEmail(e.target.value);
  };

  const onEmailBlur = (e: React.FocusEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    if (e.target.validationMessage) {
      setEmailError(true);
    }
  };

  const onPasswordChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>,
    callback: (value: string) => void
  ) => {
    callback(e.target.value);
    if (passwordError && password == confirmPassword) {
      setPasswordError(false);
    }
  };

  const onConfirmBlur = () => {
    setPasswordError(password !== confirmPassword);
    // TODO: add custom message for password differ
  };

  const onRegister = async () => {
    const data = await authService.register({
      email,
      username,
      password,
    });
    console.log(data);
  };

  const isRegisterDisabled = (): boolean => {
    return !email || !username || !password || !confirmPassword || emailError || passwordError;
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
        <Typography variant="h6">{t('registration')}</Typography>
        <TextField
          margin="dense"
          autoFocus
          label={t('enterEmail')}
          type="email"
          variant="standard"
          error={emailError}
          onChange={onEmailChange}
          onBlur={onEmailBlur}
        />
        <TextField
          margin="dense"
          label={t('enterLogin')}
          variant="standard"
          onChange={(e) => setUsername(e.target.value)}
        />
        <TextField
          margin="dense"
          label={t('enterPassword')}
          error={passwordError}
          type="password"
          variant="standard"
          onChange={(e) => onPasswordChange(e, setPassword)}
        />
        <TextField
          margin="dense"
          label={t('confirmPassword')}
          error={passwordError}
          type="password"
          variant="standard"
          onChange={(e) => onPasswordChange(e, setConfirmPassword)}
          onBlur={() => onConfirmBlur()}
        />
        <Box sx={{ mt: 1, display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
          <Typography>
            {t('haveAccount')}
            <Link sx={{ ml: 0.5 }} underline="none" href={Route.LOGIN}>
              {t('logIn!')}{' '}
            </Link>
          </Typography>
          <Button variant="outlined" disabled={isRegisterDisabled()} onClick={onRegister}>
            {t('register')}
          </Button>
        </Box>
      </Card>
    </Box>
  );
};

export default Registration;
