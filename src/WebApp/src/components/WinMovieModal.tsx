import { FC } from 'react';
import { Box, Modal, Typography } from '@mui/material';

import { WheelData } from './SpiningWheel';

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
  data: WheelData[];
  prizeNumber: number;
}

const WinModal: FC<WinModalProps> = ({ modal, setModal, data, prizeNumber }) => {
  console.log(data.map((item) => item.option));
  return (
    <Modal
      open={modal}
      onClose={() => setModal(false)}
      aria-labelledby="modal-modal-title"
      aria-describedby="modal-modal-description"
    >
      <Box sx={style}>
        <Typography id="modal-modal-description" sx={{ mt: 2 }}>
          Сегодня все смотрят
        </Typography>

        <Typography id="modal-modal-title" variant="h5" component="h2">
          {data[prizeNumber]?.option}!
        </Typography>
      </Box>
    </Modal>
  );
};
export default WinModal;
