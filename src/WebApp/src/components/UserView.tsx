import { forwardRef } from 'react';
import { Avatar, IconButton } from '@mui/material';

interface UserViewProps {
  nickname: string;
  onClick: () => void;
}

const UserView = forwardRef<HTMLElement, UserViewProps>(({ nickname, onClick }, _) => {
  return (
    <IconButton sx={{ p: 1, borderRadius: 2, m: 1, color: 'white' }} onClick={() => onClick()}>
      <Avatar sx={{ margin: 1 }} />
      {nickname}
    </IconButton>
  );
});

export default UserView;
