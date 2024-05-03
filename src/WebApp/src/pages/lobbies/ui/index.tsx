import { Box, Button, Container } from '@mui/material';
import Popover from '@mui/material/Popover';
import { useRef, useState } from 'react';
import { useTranslation } from 'react-i18next';

import { LobbyList } from '@widgets/lobbyList';

import { CreateLobby } from '@features/createLobby';

import { useLobbyStore } from '@entities/lobby';
import { LocalizationNamespace } from '@shared/enums';

const MainPage = () => {
  const { t } = useTranslation(LocalizationNamespace.MAIN_PAGE);
  const [popoverOpen, setPopoverOpen] = useState(false);

  const [lobbies, removeLobby] = useLobbyStore((state) => [state.lobbies, state.removeLobby]);

  const anchorEl = useRef<HTMLButtonElement | null>(null);

  const remove = async (lobbyId: string) => {
    await removeLobby(lobbyId);
  };

  return (
    <Container maxWidth="lg">
      <Box sx={{ m: 2, textAlign: 'center' }}>
        <CreateLobby />
        <Button
          sx={{ ml: 3 }}
          ref={anchorEl}
          onClick={() => setPopoverOpen(true)}
          variant="contained"
          size="large"
        >
          {t('myLobbies')}
        </Button>
      </Box>
      <Box>
        {!popoverOpen ? null : (
          <Popover
            sx={{ width: '100%' }}
            open={popoverOpen}
            anchorEl={anchorEl.current}
            onClose={() => setPopoverOpen(false)}
            anchorOrigin={{
              vertical: 'bottom',
              horizontal: 'right',
            }}
          >
            <LobbyList remove={remove} lobbies={lobbies} />
          </Popover>
        )}
      </Box>
    </Container>
  );
};
export default MainPage;
