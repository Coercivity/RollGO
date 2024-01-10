import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { Button, Link, Paper } from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { Route } from '@enums/Route';
import { Lobby } from '@models/Lobby';

interface LobbyViewProps {
  remove: () => void;
  lobby: Lobby;
}

const LobbyView: FC<LobbyViewProps> = ({ remove, lobby }) => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);
  return (
    <Paper
      sx={{
        display: 'flex',
        justifyContent: 'space-between',
        flexDirection: 'row',
        m: 1,
      }}
    >
      <Link
        sx={{ color: 'primary.contrastText', fontWeight: 700, textDecoration: 'none' }}
        href={`${Route.LOBBY}/${lobby.id}`}
      >
        {lobby.name}
      </Link>
      <Button variant="outlined" color="secondary" onClick={() => remove()}>
        {t('delete')}
      </Button>
    </Paper>
  );
};

export default LobbyView;
