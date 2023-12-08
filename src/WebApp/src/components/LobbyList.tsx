import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { Box, Typography } from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';

import LobbyView from './LobbyView';

interface LobbyListProps {
  lobbies: string[];
  remove: (lobby: string) => void;
}

const LobbyList: FC<LobbyListProps> = ({ lobbies, remove }) => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);
  if (!lobbies.length) {
    return (
      <Box sx={{ border: 0.5, borderRadius: 3, p: 2, borderColor: 'grey.500' }}>
        <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
          {t('noLobbiesYet')}
        </Typography>
      </Box>
    );
  }

  return (
    <Box sx={{ border: 0.5, borderRadius: 3, p: 2, borderColor: 'primary.main' }}>
      {lobbies.map((lobby, index: number) => (
        <LobbyView remove={remove} number={index + 1} lobby={lobby} key={lobby} />
      ))}
    </Box>
  );
};

export default LobbyList;
