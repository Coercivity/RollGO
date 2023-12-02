import { Button, Box } from '@mui/material';
import React, {  useState } from 'react';
import LobbyCreationModal from '../components/LobbyCreationModal';
import LobbyList from '../components/LobbyList';
import '../index.css';


const MainPage = () => {
  const [open, setOpen] = useState(false);
  const [lobbys, setLobbies] = useState<string[]>([]);


  const addNewLobby = (lobby: string) => {
    setLobbies([...lobbys, lobby]);
    setOpen(false);
  };


  const remove = (name: string) => {
    setLobbies(lobbys.filter((p) => p !== name));
  };

  return (
    <Box>
      <Box sx={{ m: 2 }}>
        <Button onClick={() => setOpen(true)} variant="outlined">
          Создать Лобби
        </Button>
      </Box>
      <LobbyList remove={remove} lobbys={lobbys} />
      <LobbyCreationModal
        open={open}
        setOpen={setOpen}
        addNewLobby={addNewLobby}

      />
    </Box>
  );
};
export default MainPage;
