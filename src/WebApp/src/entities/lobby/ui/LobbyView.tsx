import { FC } from 'react';
import DeleteOutlineIcon from '@mui/icons-material/DeleteOutline';
import { IconButton, Link, Paper, Typography } from '@mui/material';

import { Route } from '@shared/enums';

import { Lobby } from '..';

interface LobbyViewProps {
  remove: () => void;
  lobby: Lobby;
}

const LobbyView: FC<LobbyViewProps> = ({ remove, lobby }) => {
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
        <Typography
          sx={{ display: 'flex', alignItems: 'center', textAlign: 'center', ml: 2, mt: 1 }}
          noWrap
        >
          {lobby.name}
        </Typography>
      </Link>
      <IconButton color="error" onClick={() => remove()}>
        <DeleteOutlineIcon />
      </IconButton>
    </Paper>
  );
};

export default LobbyView;
