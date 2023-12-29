import React, { FC, useState } from 'react';
import { useTranslation } from 'react-i18next';
import {
  Box,
  Button,
  Dialog,
  DialogActions,
  DialogContent,
  DialogTitle,
  FormControlLabel,
  Grid,
  Popover,
  Rating,
  Switch,
  TextField,
  Typography,
} from '@mui/material';
import { Stack } from '@mui/system';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';

interface LobbySettingsProps {
  setSettingsOpen: (x: boolean) => void;
  settingsOpen: boolean;
  lobbyName: string | undefined;
}

const LobbySettings: FC<LobbySettingsProps> = ({
  settingsOpen,
  setSettingsOpen,
  lobbyName: propLobbyName,
}) => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);
  const [anchorEl, setAnchorEl] = useState<HTMLElement | null>(null);

  const [lobbyName, setLobbyName] = useState(propLobbyName);
  const [spinCount, setSpinCount] = useState(1);
  const [rating, setRating] = useState<number | null>(6);

  const saveSettings = () => {
    setSettingsOpen(false);
  };

  const spinCountChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    event.preventDefault();
    const newValue = Number(event.target.value);
    setSpinCount(newValue < 0 ? 0 : newValue);
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
    <Dialog open={settingsOpen} onClose={() => setSettingsOpen(false)} keepMounted fullWidth={true}>
      <DialogTitle sx={{ m: 1 }}> {t('lobbySettings')}</DialogTitle>
      <DialogContent>
        <Stack spacing={2}>
          <Grid container spacing={1}>
            <Grid item xs={9}>
              <TextField
                fullWidth
                label={t('lobbyName')}
                variant="standard"
                value={lobbyName ?? ''}
                onChange={lobbyIdChange}
              />
            </Grid>
            <Grid item xs={3}>
              <TextField
                fullWidth
                variant="standard"
                label={t('moviesQuantity')}
                type="number"
                value={spinCount}
                onChange={spinCountChange}
              />
            </Grid>
          </Grid>

          <Box
            sx={{
              display: 'flex',
            }}
          >
            <Typography component="legend"> {t('minRating')}</Typography>
            <Rating
              sx={{ ml: 1 }}
              max={10}
              name="simple-controlled"
              value={rating}
              precision={0.5}
              onChange={(event, newValue) => {
                event.preventDefault();
                setRating(newValue);
              }}
            />
          </Box>

          <Box
            sx={{
              display: 'flex',
              alignItems: 'center',
              justifyContent: 'left',
            }}
          >
            <FormControlLabel
              labelPlacement="end"
              control={<Switch defaultChecked />}
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
        </Stack>
      </DialogContent>

      <DialogActions>
        <Button sx={{ mr: 1, mb: 2 }} variant="text" onClick={() => setSettingsOpen(false)}>
          {t('cancel')}
        </Button>
        <Button
          sx={{ mr: 2, mb: 2 }}
          disabled={spinCount < 0}
          variant="contained"
          onClick={saveSettings}
        >
          {t('apply')}
        </Button>
      </DialogActions>
    </Dialog>
  );
};

export default LobbySettings;
