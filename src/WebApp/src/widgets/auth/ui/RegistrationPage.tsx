import React, { useState } from 'react';
import { useTranslation } from 'react-i18next';
import { useNavigate } from 'react-router-dom';
import ErrorOutlineIcon from '@mui/icons-material/ErrorOutline';
import { Box, Button, Card, Link, TextField, Typography } from '@mui/material';

import { useUserStore } from '@entities/user';
import { ErrorCode, LocalizationNamespace, Route } from '@shared/enums';
import { EMAIL_ERRORS, PASSWORD_ERRORS } from '@shared/enums/ErrorCode';
import { handleError } from '@shared/utils/validationUtils';

import { authService, useAuthStore } from '..';

const RegistrationPage = () => {
  const { t } = useTranslation([LocalizationNamespace.AUTH, LocalizationNamespace.VALIDATIONS]);
  const [email, setEmail] = useState<string>('');
  const [username, setUsername] = useState<string>('');
  const [password, setPassword] = useState<string>('');
  const [confirmPassword, setConfirmPassword] = useState<string>();

  const [error, setError] = useState<ErrorCode>();

  const setTokenPair = useAuthStore((state) => state.setTokenPair);
  const setUser = useUserStore((state) => state.setUser);
  const navigate = useNavigate();

  const onEmailChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    if (error && EMAIL_ERRORS.includes(error) && !e.target.validationMessage) {
      setError(undefined);
    }
    setEmail(e.target.value);
  };

  const onEmailBlur = (e: React.FocusEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    if (e.target.validationMessage) {
      setError(ErrorCode.EmailValidation);
    }
  };

  const onPasswordChange = (value: string, callback: (value: string) => void) => {
    callback(value);
    if (error && ErrorCode.PasswordsNotMatch && (password === value || confirmPassword === value)) {
      setError(undefined);
    }
  };

  const onPasswordBlur = (value: string) => {
    if (value !== password || value !== confirmPassword) setError(ErrorCode.PasswordsNotMatch);
  };

  const onRegister = async () => {
    try {
      const data = await authService.register({
        email,
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

  const isRegisterDisabled = (): boolean => {
    return !email || !username || !password || !confirmPassword || !!error;
  };

  return (
    <Box
      sx={{
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
        height: '89%',
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
        <Typography variant="h6">{t('registration')}</Typography>
        <TextField
          margin="dense"
          autoFocus
          label={t('enterEmail')}
          type="email"
          variant="standard"
          autoComplete="off"
          error={error && EMAIL_ERRORS.includes(error)}
          onChange={onEmailChange}
          onBlur={onEmailBlur}
        />
        <TextField
          margin="dense"
          label={t('enterLogin')}
          variant="standard"
          autoComplete="off"
          onChange={(e) => setUsername(e.target.value)}
          error={error === ErrorCode.UsernameExists}
        />
        <TextField
          margin="dense"
          label={t('enterPassword')}
          error={error && PASSWORD_ERRORS.includes(error)}
          type="password"
          variant="standard"
          autoComplete="new-password"
          onChange={(e) => onPasswordChange(e.target.value, setPassword)}
          onBlur={(e) => onPasswordBlur(e.target.value)}
        />
        <TextField
          margin="dense"
          label={t('confirmPassword')}
          error={error && PASSWORD_ERRORS.includes(error)}
          type="password"
          variant="standard"
          onChange={(e) => onPasswordChange(e.target.value, setConfirmPassword)}
          onBlur={(e) => onPasswordBlur(e.target.value)}
        />
        {error && (
          <Box sx={{ display: 'flex', alignItems: 'center', mt: 1 }}>
            {<ErrorOutlineIcon color="error" />}
            <Typography color="error" sx={{ fontSize: 14, fontWeight: 'light', ml: 0.5 }}>
              {t(error, { ns: LocalizationNamespace.VALIDATIONS })}
            </Typography>
          </Box>
        )}
        <Box sx={{ mt: 1, display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
          <Typography>
            {t('haveAccount')}
            <Link sx={{ ml: 0.5 }} underline="none" href={Route.LOGIN}>
              {t('logIn!')}
            </Link>
          </Typography>
          <Button
            variant="contained"
            color="primary"
            disabled={isRegisterDisabled()}
            onClick={onRegister}
          >
            {t('register')}
          </Button>
        </Box>
      </Card>
    </Box>
  );
};

export default RegistrationPage;
