import React, { useState } from 'react';
import { useTranslation } from 'react-i18next';
import CloudUploadIcon from '@mui/icons-material/CloudUpload';
import { Avatar, Box, Button, Card, Stack, TextField, Typography } from '@mui/material';
import { styled } from '@mui/material/styles';

import { authService } from '@api/authService';
import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { useAuthStore } from '@store/authStore';
import { useUserStore } from '@store/userStore';

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
  const { t } = useTranslation(LocalizationNamespace.USER_SETTINGS);
  const [previousUsername, mail, setUser] = useUserStore((state) => [
    state.username,
    state.email,
    state.setUser,
  ]);

  const [email, setEmail] = useState(mail);
  const [emailError, setEmailError] = useState(false);
  const [username, setUsername] = useState<string>(previousUsername);
  const [oldPassword, setOldPassword] = useState<string>('');
  const [password, setPassword] = useState<string>('');
  const [confirmPassword, setConfirmPassword] = useState<string>();
  const [passwordError, setPasswordError] = useState(false);

  const setTokenPair = useAuthStore((state) => state.setTokenPair);

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

  const confirmChanges = async () => {
    if (email && username) {
      const data = await authService.register({
        email,
        username,
        password,
      });
      setTokenPair({
        accessToken: data.accessToken,
        refreshToken: data.refreshToken,
      });
      setUser(data.user, false);
    }
  };

  const isRegisterDisabled = (): boolean => {
    if (emailError) return false;
    if (password && !confirmPassword) return false;
    if (password && !oldPassword) return false;
    if (!password && oldPassword) return false;
    return true;
  };

  return (
    <Box
      sx={{
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
        mt: 8,
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
            autoFocus
            label={t('changeEmail')}
            type="email"
            variant="standard"
            error={emailError}
            onChange={onEmailChange}
            onBlur={onEmailBlur}
          />
          <TextField
            margin="dense"
            label={t('changeLogin')}
            variant="standard"
            onChange={(e) => setUsername(e.target.value)}
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
            error={passwordError}
            type="password"
            variant="standard"
            onChange={(e) => setOldPassword(e.target.value)}
          />
          <TextField
            margin="dense"
            label={t('newPassword')}
            error={passwordError}
            type="password"
            variant="standard"
            onChange={(e) => onPasswordChange(e, setPassword)}
          />
          <TextField
            margin="dense"
            label={t('confirmNewPassword')}
            error={passwordError}
            type="password"
            variant="standard"
            onChange={(e) => onPasswordChange(e, setConfirmPassword)}
            onBlur={() => onConfirmBlur()}
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
            {passwordError && <Typography color="error"> {t('error')}</Typography>}
          </Box>
          <Button
            sx={{ display: 'flex', justifyContent: 'flex-end', alignItems: 'center' }}
            variant="outlined"
            disabled={isRegisterDisabled()}
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
