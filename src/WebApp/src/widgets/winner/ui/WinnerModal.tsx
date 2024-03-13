import { FC } from 'react';
import { useTranslation } from 'react-i18next';
import { Dialog, DialogContent, DialogTitle, Typography } from '@mui/material';

import { IWheelData } from '@features/spinMovies/ui/SpiningWheel';
import { LocalizationNamespace } from '@shared/enums';

interface WinnerModalProps {
  username: string;
  modal: boolean;
  setOpen: (open: boolean) => void;
  wheelData: IWheelData[];
  prizeNumber: number;
}

const WinnerModal: FC<WinnerModalProps> = ({
  modal,
  setOpen,
  wheelData,
  prizeNumber,
  username,
}) => {
  const { t } = useTranslation(LocalizationNamespace.WHEEL);

  return (
    <Dialog open={modal} onClose={() => setOpen(false)}>
      <DialogTitle>
        <Typography>{t('won', { username })}</Typography>
      </DialogTitle>

      <DialogContent>
        <Typography>{t('todayWeWatch')}</Typography>
        <Typography>{wheelData[prizeNumber]?.option}!</Typography>
      </DialogContent>
    </Dialog>
  );
};
export default WinnerModal;
