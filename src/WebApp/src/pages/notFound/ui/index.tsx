import { Box, Button, Typography } from '@mui/material';
import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { useNavigate } from 'react-router-dom';

import { LocalizationNamespace, Route } from '@shared/enums';

interface NotFoundProps {
  errorType: string;
}

const NotFound: FC<NotFoundProps> = ({ errorType }) => {
  const { t } = useTranslation(LocalizationNamespace.VALIDATIONS);
  const navigate = useNavigate();

  return (
    <Box
      sx={{
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
        flexDirection: 'column',
        height: '89%',
      }}
    >
      <Typography variant="h1" style={{ color: 'white' }}>
        404
      </Typography>
      <Typography variant="h6" style={{ color: 'white' }}>
        {t(errorType)}
      </Typography>
      <Button sx={{ mt: 3 }} variant="contained" onClick={() => navigate(Route.ROOT)}>
        {t('goMain')}
      </Button>
    </Box>
  );
};

export default NotFound;
