import { forwardRef } from 'react';
import { Avatar, Box, IconButton, SvgIcon, Typography } from '@mui/material';
import Badge from '@mui/material/Badge';
import { styled } from '@mui/material/styles';

interface UserViewProps {
  nickname: string;
  onClick?: (event: React.MouseEvent<HTMLButtonElement | null>) => void;
  isOnline?: boolean;
  isInNavbar: boolean;
  id?: string;
  adminId?: string;
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
  ({ nickname, isOnline = true, onClick, isInNavbar, id, adminId }, ref) => {
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
            {id === adminId && (
              <SvgIcon>
                <svg fill="none" viewBox="0 0 24 24" strokeWidth={1.5} stroke="currentColor">
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    d="M4 8L6 20H18L20 8M4 8L5.71624 9.37299C6.83218 10.2657 7.39014 10.7121 7.95256 10.7814C8.4453 10.8421 8.94299 10.7173 9.34885 10.4314C9.81211 10.1051 10.0936 9.4483 10.6565 8.13476L12 5M4 8C4.55228 8 5 7.55228 5 7C5 6.44772 4.55228 6 4 6C3.44772 6 3 6.44772 3 7C3 7.55228 3.44772 8 4 8ZM20 8L18.2838 9.373C17.1678 10.2657 16.6099 10.7121 16.0474 10.7814C15.5547 10.8421 15.057 10.7173 14.6511 10.4314C14.1879 10.1051 13.9064 9.4483 13.3435 8.13476L12 5M20 8C20.5523 8 21 7.55228 21 7C21 6.44772 20.5523 6 20 6C19.4477 6 19 6.44772 19 7C19 7.55228 19.4477 8 20 8ZM12 5C12.5523 5 13 4.55228 13 4C13 3.44772 12.5523 3 12 3C11.4477 3 11 3.44772 11 4C11 4.55228 11.4477 5 12 5ZM12 4H12.01M20 7H20.01M4 7H4.01"
                  />
                </svg>
              </SvgIcon>
            )}
          </Box>
        )}
      </Box>
    );
  }
);

export default UserView;
