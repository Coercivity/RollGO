import {
  Box,
  FormControlLabel,
  Grid,
  Popover,
  Rating,
  Switch,
  TextField,
  Typography,
} from '@mui/material';
import { Stack } from '@mui/system';
import React, { FC, useState } from 'react';
import { useTranslation } from 'react-i18next';

import { LocalizationNamespace } from '@shared/enums';

interface LobbySettingsProps {
  lobbyName: string | undefined;
  rating: number;
  moviesPerUser: number;
  withName?: boolean;
  withCoefficient?: boolean;
  setLobbyName: (lobbyName: string) => void;
  setRating: (rating: number) => void;
  setMoviesPerUser: (moviesPerUser: number) => void;
  setWithCoefficient: (withCoefficient: boolean) => void;
}

const LobbySettings: FC<LobbySettingsProps> = ({
  lobbyName,
  moviesPerUser,
  rating,
  withCoefficient,
  setLobbyName,
  setMoviesPerUser,
  setRating,
  setWithCoefficient,
  withName = false,
}) => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);
  const [anchorEl, setAnchorEl] = useState<HTMLElement | null>(null);

  const moviesPerUserChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    event.preventDefault();
    const newValue = Number(event.target.value);
    setMoviesPerUser(newValue < 1 ? 1 : newValue);
  };

  const lobbyIdChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    event.preventDefault();
    setLobbyName(event.target.value);
  };

  const handlePopoverOpen = (event: React.MouseEvent<HTMLElement>) => {
    setAnchorEl(event.currentTarget);
  };

  const handlePopoverClose = () => {
    setAnchorEl(null);
  };

  const open = Boolean(anchorEl);

  return (
    <Stack>
      <Grid container spacing={1} sx={{ mb: 2 }}>
        {withName && (
          <Grid item xs={7}>
            <TextField
              fullWidth
              label={t('lobbyName')}
              variant="standard"
              value={lobbyName ?? ''}
              onChange={lobbyIdChange}
              inputProps={{ maxLength: 20 }}
            />
          </Grid>
        )}
        <Grid item xs={5}>
          <TextField
            required
            fullWidth
            variant="standard"
            label={t('moviesQuantity')}
            type="number"
            value={moviesPerUser}
            onChange={moviesPerUserChange}
          />
        </Grid>
      </Grid>

      <Box
        sx={{
          display: 'flex',
          mb: 1,
        }}
      >
        <Typography component="legend"> {t('minRating')}</Typography>
        <Rating
          sx={{ ml: 1 }}
          max={10}
          name="simple-controlled"
          value={rating}
          precision={0.5}
          onChange={(_, newValue) => setRating(newValue ?? 0)}
        />
      </Box>
      <Grid container spacing={0}>
        <Box
          sx={{
            display: 'flex',
            alignItems: 'center',
            justifyContent: 'left',
          }}
        >
          <FormControlLabel
            labelPlacement="end"
            control={
              <Switch
                defaultChecked
                value={withCoefficient}
                onChange={() => setWithCoefficient(!withCoefficient)}
              />
            }
            label={t('complexCoefficient')}
          />
          <Typography
            sx={{ cursor: 'pointer' }}
            aria-owns={open ? 'mouse-over-popover' : undefined}
            aria-haspopup="true"
            onMouseEnter={handlePopoverOpen}
            onMouseLeave={handlePopoverClose}
          >
            (?)
          </Typography>
          <Popover
            id="mouse-over-popover"
            sx={{
              pointerEvents: 'none',
            }}
            slotProps={{ paper: { style: { width: '500px' } } }}
            open={open}
            anchorEl={anchorEl}
            anchorOrigin={{
              vertical: 'bottom',
              horizontal: 'left',
            }}
            transformOrigin={{
              vertical: 'top',
              horizontal: 'center',
            }}
            onClose={handlePopoverClose}
            disableRestoreFocus
          >
            <Typography sx={{ p: 1 }}>{t('hoverText')}</Typography>
          </Popover>
        </Box>
      </Grid>
    </Stack>
  );
};

export default LobbySettings;
