import React, { useEffect, useState } from 'react';
import { useTranslation } from 'react-i18next';
import CloudUploadIcon from '@mui/icons-material/CloudUpload';
import ErrorOutlineIcon from '@mui/icons-material/ErrorOutline';
import { Avatar, Box, Button, Card, Stack, TextField, Typography } from '@mui/material';
import { styled } from '@mui/material/styles';

import { userService } from '@api/userService';
import { EMAIL_ERRORS, ErrorCode, PASSWORD_ERRORS, USERNAME_ERRORS } from '@enums/ErrorCode';
import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { useUserStore } from '@store/userStore';

import { handleError } from '../utils/validationUtils';

const VisuallyHiddenInput = styled('input')({
  clip: 'rect(0 0 0 0)',
  clipPath: 'inset(50%)',
  height: 1,
  overflow: 'hidden',
  position: 'absolute',
  bottom: 0,
  left: 0,
  whiteSpace: 'nowrap',
  width: 1,
});

const UserSettingsPage = () => {
  const { t } = useTranslation([
    LocalizationNamespace.USER_SETTINGS,
    LocalizationNamespace.VALIDATIONS,
  ]);
  const [previousUsername, mail, setUser, id] = useUserStore((state) => [
    state.username,
    state.email,
    state.setUser,
    state.id,
  ]);

  const [email, setEmail] = useState(mail);
  const [username, setUsername] = useState<string>(previousUsername);
  const [oldPassword, setOldPassword] = useState<string>();
  const [password, setPassword] = useState<string>();
  const [confirmPassword, setConfirmPassword] = useState<string>();
  const [error, setError] = useState<ErrorCode>();

  const [success, setSuccess] = useState(false);

  useEffect(() => {
    if (error !== ErrorCode.EmailValidation && !password && !confirmPassword && !oldPassword)
      setError(undefined);
  }, [oldPassword, password, confirmPassword]);

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

  const onUsernameChange = (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    if (error && USERNAME_ERRORS.includes(error)) {
      setError(undefined);
    }
    setUsername(e.target.value);
  };

  const onPasswordChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>,
    callback: (value: string) => void
  ) => {
    callback(e.target.value);
    if (
      error &&
      PASSWORD_ERRORS.includes(error) &&
      (password === e.target.value || confirmPassword === e.target.value)
    ) {
      setError(undefined);
    }
  };

  const onPasswordBlur = (value: string) => {
    if (value !== password || value !== confirmPassword) setError(ErrorCode.PasswordsNotMatch);
  };

  const confirmChanges = async () => {
    try {
      const data = await userService.update({
        email,
        username,
        id,
        password: password === '' ? undefined : password,
        currentPassword: oldPassword,
      });
      setUser(data);

      setSuccess(true);
      setTimeout(() => setSuccess(false), 5000);
    } catch (e) {
      handleError(e, setError);
    }
  };

  const isConfirmDisabled = (): boolean => {
    return (
      !!error ||
      (!!password && !confirmPassword) ||
      (!!password && !oldPassword) ||
      (!password && !!oldPassword)
    );
  };

  return (
    <Box
      sx={{
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
        height: `calc(100vh - 64px)`,
        overflow: 'auto',
      }}
    >
      <Card
        sx={{
          display: 'flex',
          justifyContent: 'center',
          flexDirection: 'column',
          width: 700,
          p: 5,
        }}
      >
        <Typography sx={{ mb: 2 }} variant="h6">
          {t('accountSettings')}
        </Typography>
        <Box
          sx={{
            display: 'flex',
            flexDirection: 'column',
            border: 0.5,
            borderRadius: 3,
            p: 3,
            borderColor: 'grey.500',
          }}
        >
          <Typography sx={{ mb: 2, color: 'grey.500' }}>{t('commonSettings')}</Typography>
          <Stack direction="row" spacing={2}>
            <Avatar sx={{ width: 75, height: 75 }} src="/broken-image.jpg"></Avatar>
            <Button component="label" variant="text" startIcon={<CloudUploadIcon />}>
              {t('uploadFile')}
              <VisuallyHiddenInput type="file" />
            </Button>
          </Stack>

          <TextField
            margin="dense"
            required
            autoFocus
            label={t('changeEmail')}
            type="email"
            variant="standard"
            error={error && EMAIL_ERRORS.includes(error)}
            onChange={onEmailChange}
            value={email}
            onBlur={onEmailBlur}
          />
          <TextField
            margin="dense"
            label={t('changeLogin')}
            variant="standard"
            value={username}
            required
            error={error && USERNAME_ERRORS.includes(error)}
            onChange={onUsernameChange}
          />
        </Box>
        <Box
          sx={{
            display: 'flex',
            flexDirection: 'column',
            border: 0.5,
            borderRadius: 3,
            p: 3,
            borderColor: 'grey.500',
            mt: 2,
          }}
        >
          <Typography sx={{ color: 'grey.500' }}>{t('passwordChange')}</Typography>
          <TextField
            margin="dense"
            label={t('oldPassword')}
            error={error === ErrorCode.WrongPassword}
            type="password"
            variant="standard"
            onChange={(e) => setOldPassword(e.target.value)}
          />
          <TextField
            margin="dense"
            label={t('newPassword')}
            disabled={!oldPassword && !password}
            error={error && PASSWORD_ERRORS.includes(error)}
            type="password"
            variant="standard"
            onChange={(e) => onPasswordChange(e, setPassword)}
            onBlur={(e) => onPasswordBlur(e.target.value)}
          />
          <TextField
            margin="dense"
            disabled={!password && !confirmPassword}
            label={t('confirmNewPassword')}
            error={error && PASSWORD_ERRORS.includes(error)}
            type="password"
            variant="standard"
            onChange={(e) => onPasswordChange(e, setConfirmPassword)}
            onBlur={(e) => onPasswordBlur(e.target.value)}
          />
        </Box>
        <Box
          sx={{
            mt: 2,
            display: 'flex',
            alignItems: 'center',
            justifyContent: 'space-between',
          }}
        >
          <Box
            sx={{ display: 'flex', justifyContent: 'flex-start', alignItems: 'center' }}
            color="error"
          >
            {error && (
              <Box sx={{ display: 'flex', alignItems: 'center' }}>
                {<ErrorOutlineIcon color="error" />}
                <Typography color="error" sx={{ fontWeight: 'light', ml: 0.5, maxWidth: 400 }}>
                  {t(error, { ns: LocalizationNamespace.VALIDATIONS })}
                </Typography>
              </Box>
            )}
            {success && !error && <Typography color="green"> {t('success')}</Typography>}
          </Box>
          <Button
            sx={{ display: 'flex', justifyContent: 'flex-end', alignItems: 'center' }}
            variant="contained"
            disabled={isConfirmDisabled()}
            onClick={confirmChanges}
          >
            {t('confirm')}
          </Button>
        </Box>
      </Card>
    </Box>
  );
};

export default UserSettingsPage;
