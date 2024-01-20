import { forwardRef } from 'react';
import { Avatar, IconButton, Typography, Box } from '@mui/material';
import Badge from '@mui/material/Badge';
import { styled } from '@mui/material/styles';

interface UserViewProps {
  nickname: string;
  onClick?: (event: React.MouseEvent<HTMLButtonElement | null>) => void;
  isOnline?: boolean;
  isInNavbar: boolean;
}

const StyledBadgeOnline = styled(Badge)(({ theme }) => ({
  '& .MuiBadge-badge': {
    backgroundColor: '#44b700',
    color: '#44b700',
    boxShadow: `0 0 0 2px ${theme.palette.background.paper}`,
    '&::after': {
      position: 'absolute',
      top: -1,
      left: -1,
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

const UserView = forwardRef<HTMLButtonElement, UserViewProps>(
  ({ nickname, isOnline = true, onClick, isInNavbar }, ref) => {
    return (
      <Box>
        {isInNavbar ? (
          <IconButton sx={ButtonStyle} onClick={onClick} ref={ref}>
            {isOnline ? (
              <StyledBadgeOnline
                overlap="circular"
                anchorOrigin={{ vertical: 'bottom', horizontal: 'right' }}
                variant="dot"
              >
                <Avatar />
              </StyledBadgeOnline>
            ) : (
              <StyledBadgeOffline
                overlap="circular"
                anchorOrigin={{ vertical: 'bottom', horizontal: 'right' }}
                variant="dot"
              >
                <Avatar />
              </StyledBadgeOffline>
            )}
            <Typography variant="h6" noWrap sx={{ m: 0.5, ml: 1 }}>
              {nickname}
            </Typography>
          </IconButton>
        ) : (
          <Box sx={{ display: 'flex', m: 1, alignItems: 'center' }}>
            {isOnline ? (
              <StyledBadgeOnline
                overlap="circular"
                anchorOrigin={{ vertical: 'bottom', horizontal: 'right' }}
                variant="dot"
              >
                <Avatar sx={{ width: 34, height: 34 }} />
              </StyledBadgeOnline>
            ) : (
              <StyledBadgeOffline
                overlap="circular"
                anchorOrigin={{ vertical: 'bottom', horizontal: 'right' }}
                variant="dot"
              >
                <Avatar sx={{ width: 34, height: 34 }} />
              </StyledBadgeOffline>
            )}
            <Typography noWrap sx={{ m: 0.5, ml: 1 }}>
              {nickname}
            </Typography>
          </Box>
        )}
      </Box>
    );
  }
);

export default UserView;
