import "/UserView.css";
import React, { FC, ReactElement } from "react";
import { Avatar, IconButton } from "@mui/material";

interface UserViewProps {
  nickname: string; //задать тип User
  temp(): void;
}

const UserView: FC<UserViewProps> = ({ nickname, temp }) => {
  return (
    <IconButton className="navbar-btn" sx={{ p: 1 }} onClick={() => temp()}>
      <Avatar sx={{ margin: 1 }} />
      {nickname}
    </IconButton>
  );
};

export default UserView;
