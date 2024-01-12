import { forwardRef } from 'react';
import { Avatar, IconButton, Typography } from '@mui/material';
import Badge from '@mui/material/Badge';
import { styled } from '@mui/material/styles';

interface UserViewProps {
  nickname: string;
  onClick?: (event: React.MouseEvent<HTMLButtonElement | null>) => void;
  isOnline?: boolean;
}

const StyledBadgeOnline = styled(Badge)(({ theme }) => ({
  '& .MuiBadge-badge': {
    backgroundColor: '#44b700',
    color: '#44b700',
    boxShadow: `0 0 0 2px ${theme.palette.background.paper}`,
    '&::after': {
      position: 'absolute',
      top: 0,
      left: 0,
      width: '100%',
      height: '100%',
      borderRadius: '50%',
      animation: 'ripple 1.2s infinite ease-in-out',
      border: '1px solid currentColor',
      content: '""',
    },
  },
  '@keyframes ripple': {
    '0%': {
      transform: 'scale(.8)',
      opacity: 1,
    },
    '100%': {
      transform: 'scale(2.4)',
      opacity: 0,
    },
  },
}));

const StyledBadgeOffline = styled(Badge)(({ theme }) => ({
  '& .MuiBadge-badge': {
    backgroundColor: 'grey',
    color: 'grey',
    boxShadow: `0 0 0 1px ${theme.palette.background.paper}`,
  },
}));

const ButtonStyle = {
  p: 1,
  borderRadius: 2,
  m: 1,
  color: 'white',
  width: '100%',
  display: 'flex',
  justifyContent: 'start',
};

const UserView = forwardRef<HTMLElement, UserViewProps>(
  ({ nickname, isOnline = true, onClick }, _) => {
    return isOnline ? (
      <IconButton sx={ButtonStyle} onClick={onClick}>
        <StyledBadgeOnline
          overlap="circular"
          anchorOrigin={{ vertical: 'bottom', horizontal: 'right' }}
          variant="dot"
        >
          <Avatar />
        </StyledBadgeOnline>
        <Typography sx={{ m: 0.5 }}>{nickname}</Typography>
      </IconButton>
    ) : (
      <IconButton sx={ButtonStyle}>
        <StyledBadgeOffline
          overlap="circular"
          anchorOrigin={{ vertical: 'bottom', horizontal: 'right' }}
          variant="dot"
        >
          <Avatar />
        </StyledBadgeOffline>
        <Typography sx={{ m: 0.5 }}>{nickname}</Typography>
      </IconButton>
    );
  }
);

export default UserView;
