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
  List,
  Popover,
  Rating,
  Switch,
  TextField,
  Typography,
} from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';

interface LobbySettingsProps {
  setSettingsOpen: (x: boolean) => void;
  settingsOpen: boolean;
  lobbyId: string | undefined;
}

const LobbySettings: FC<LobbySettingsProps> = ({ settingsOpen, setSettingsOpen, lobbyId }) => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);

  const [anchorEl, setAnchorEl] = useState<HTMLElement | null>(null);

  const saveSettings = () => {
    setSettingsOpen(false);
  };

  const [spinCount, setSpinCount] = useState(1);
  const [rating, setRating] = useState<number | null>(6);

  const spinCountChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    event.preventDefault();
    setSpinCount(Number(event.target.value));
  };

  const lobbyIdChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    event.preventDefault();
  };

  const handlePopoverOpen = (event: React.MouseEvent<HTMLElement>) => {
    setAnchorEl(event.currentTarget);
  };

  const handlePopoverClose = () => {
    setAnchorEl(null);
  };

  const open = Boolean(anchorEl);

  return (
    <Dialog open={settingsOpen} keepMounted fullWidth={true}>
      <DialogTitle sx={{ m: 1 }}> {t('lobbySettings')}</DialogTitle>
      <DialogContent>
        <List>
          <Box
            sx={{
              display: 'flex',
              flexDirection: 'column',
              justifyContent: 'left',
              alignItems: 'flex-start',
              ml: 1,
              mr: 1,
            }}
          >
            <Box sx={{ display: 'flex', alignItems: 'center', mb: 2 }}>
              <Typography>{t('lobbyName')}</Typography>
              <TextField
                sx={{ ml: 1, maxWidth: 300, display: 'flex' }}
                variant="standard"
                size="small"
                value={String(lobbyId)}
                onChange={lobbyIdChange}
              />
            </Box>
            <Box sx={{ display: 'flex', alignItems: 'center', mb: 2 }}>
              <Typography>{t('moviesQuantity')}</Typography>
              <TextField
                sx={{ ml: 1, maxWidth: 40, display: 'flex' }}
                variant="standard"
                type="number"
                size="small"
                value={spinCount}
                onChange={spinCountChange}
              />
            </Box>

            <Box
              sx={{
                mb: 2,
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
                sx={{ ml: -2, mb: 0 }}
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
                  width: 1500,
                }}
                open={open}
                anchorEl={anchorEl}
                anchorOrigin={{
                  vertical: 'bottom',
                  horizontal: 'left',
                }}
                transformOrigin={{
                  vertical: 'top',
                  horizontal: 'left',
                }}
                onClose={handlePopoverClose}
                disableRestoreFocus
              >
                <Typography sx={{ p: 1 }}>{t('hoverText')}</Typography>
              </Popover>
            </Box>
          </Box>
        </List>
      </DialogContent>

      <DialogActions>
        <Button sx={{ mr: 1, mb: 2 }} variant="text" onClick={() => setSettingsOpen(false)}>
          {t('cancel')}
        </Button>
        <Button
          sx={{ mr: 2, mb: 2 }}
          disabled={spinCount < 0}
          variant="outlined"
          onClick={saveSettings}
        >
          {t('apply')}
        </Button>
      </DialogActions>
    </Dialog>
  );
};

export default LobbySettings;
