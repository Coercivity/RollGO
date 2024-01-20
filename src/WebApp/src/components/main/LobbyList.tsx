import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { Box, Paper, Typography } from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { Lobby } from '@models/Lobby';

import LobbyView from '../lobby/LobbyView';

interface LobbyListProps {
  lobbies: Lobby[];
  remove: (lobbyId: string) => void;
}

const LobbyList: FC<LobbyListProps> = ({ lobbies, remove }) => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);
  if (!lobbies.length) {
    return (
      <Box sx={{ borderRadius: 3, p: 2, borderColor: 'grey.500' }}>
        <Typography
          variant="h6"
          component="div"
          sx={{ flexGrow: 1, color: 'primary.contrastText', textAlign: 'center' }}
        >
          {t('noLobbiesYet')}
        </Typography>
      </Box>
    );
  }

  return (
    <Paper sx={{ borderRadius: 3, p: 2, bgcolor: 'grey.900' }}>
      {lobbies.map((lobby) => (
        <LobbyView remove={() => remove(lobby.id)} lobby={lobby} key={lobby.id} />
      ))}
    </Paper>
  );
};

export default LobbyList;
