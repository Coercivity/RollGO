import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { Box, Button } from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';

interface LobbyViewProps {
  remove: (lobby: string) => void;
  number: number;
  lobby: string;
}

const LobbyView: FC<LobbyViewProps> = ({ remove, number, lobby }) => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);
  return (
    <Box
      sx={{
        display: 'flex',
        justifyContent: 'space-between',
        flexDirection: 'row',
        m: 1,
        gap: 1,
      }}
    >
      {number}. {lobby}
      <Button variant="outlined" color="error" onClick={() => remove(lobby)}>
        {t('delete')}
      </Button>
    </Box>
  );
};

export default LobbyView;
