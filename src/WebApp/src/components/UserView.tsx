import { FC } from 'react';
import { Avatar, IconButton } from '@mui/material';

interface UserViewProps {
  nickname: string;
  onClick: () => void;
}

const UserView: FC<UserViewProps> = ({ nickname, onClick }) => {
  return (
    <IconButton sx={{ p: 1, borderRadius: 2, m: 1 }} onClick={() => onClick()}>
      <Avatar sx={{ margin: 1 }} />
      {nickname}
    </IconButton>
  );
};

export default UserView;
