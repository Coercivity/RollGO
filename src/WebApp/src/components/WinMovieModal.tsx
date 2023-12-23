import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { Box, Modal, Typography } from '@mui/material';

import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { useUserStore } from '@store/userStore';

import { IWheelData } from './SpiningWheel';

const style = {
  position: 'absolute',
  bgcolor: 'background.paper',
  top: '50%',
  left: '50%',
  transform: 'translate(-50%, -50%)',
  width: 400,
  border: '2px solid #000',
  boxShadow: 24,
  p: 4,
};

interface WinModalProps {
  modal: boolean;
  setModal: (modal: boolean) => void;
  wheelData: IWheelData[];
  prizeNumber: number;
}

const WinModal: FC<WinModalProps> = ({ modal, setModal, wheelData, prizeNumber }) => {
  const username = useUserStore((state) => state.username);
  const { t } = useTranslation(LocalizationNamespace.WHEEL);

  return (
    <Modal
      open={modal}
      onClose={() => setModal(false)}
      aria-labelledby="modal-modal-title"
      aria-describedby="modal-modal-description"
    >
      <Box sx={style}>
        <Typography id="modal-modal-description" sx={{ mt: 2, mb: 2 }}>
          {t('won', { username })}
        </Typography>

        <Typography id="modal-modal-description">{t('todayWeWatch')}</Typography>

        <Typography id="modal-modal-title" variant="h5" component="h2">
          {wheelData[prizeNumber]?.option}!
        </Typography>
      </Box>
    </Modal>
  );
};
export default WinModal;
