import { Box, Typography } from '@mui/material';
import React, { FC } from 'react';
import LobbyView from './LobbyView';

interface LobbyListProps {
  lobbys: string[];
  remove: (lobby: string) => void;
}

const LobbyList: FC<LobbyListProps> = ({ lobbys, remove }) => {
  if (!lobbys.length) {
    return (
      <Box sx={{ border: 0.5, borderRadius: 3, p: 2, borderColor: 'grey.500' }}>
        <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
          Пока не созданно ни одного лобби
        </Typography>
      </Box>
    );
  }

  return (
    <Box sx={{ border: 0.5, borderRadius: 3, p: 2, borderColor: 'primary.main' }}>
      {lobbys.map((lobby, index: number) => (
        <LobbyView remove={remove} number={index + 1} lobby={lobby} key={lobby} />
      ))}
    </Box>
  );
};

export default LobbyList;
