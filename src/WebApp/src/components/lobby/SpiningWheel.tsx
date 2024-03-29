import React, { FC, useEffect, useState } from 'react';
import { Wheel } from 'react-custom-roulette';
import { useTranslation } from 'react-i18next';
import { Box, TextField, ToggleButton, ToggleButtonGroup } from '@mui/material';

import WinnerModal from '@components/lobby/WinnerModal';
import { LocalizationNamespace } from '@enums/LocalizationNamespace';
import { Movie } from '@models/Movie';

const colorMap = new Map();
const backgroundColors = [
  '#6495ed',
  'purple',
  '#df3428',
  '#3bb08f',
  'darkblue',
  'orange',
  '#8ccb5e',
  'red',
  '#003153',
  'darkgreen',
  '#d5713f',
  'lightblue',
  'violet',
  'brown',
];
interface WheelProps {
  movies: Movie[];
}

export interface IWheelData {
  option: string;
  backgroundColor: string;
}

const SpinningWheel: FC<WheelProps> = ({ movies }) => {
  const [mustSpin, setMustSpin] = useState(false);
  const [prizeNumber, setPrizeNumber] = useState(0);
  const [spinDuration, setSpinDuration] = useState(5);
  const [wheelData, setWheelData] = useState<IWheelData[]>([
    { option: '', backgroundColor: '#6495ed' },
  ]);
  const [alignment, setAlignment] = useState('standart');

  const { t } = useTranslation(LocalizationNamespace.WHEEL);

  const [modal, setModal] = useState(false);

  useEffect(() => {
    if (movies.length) {
      movies.forEach((movie: Movie) => {
        const randomIndex = Math.ceil(Math.random() * (backgroundColors.length - 1));
        let color = colorMap.get(movie.kinopoiskId);
        if (!color) {
          color = backgroundColors[randomIndex];
          colorMap.set(movie.kinopoiskId, color);
        }
      });
      const newData = movies.map((movie: Movie) => ({
        option: movie.nameRu,
        backgroundColor: colorMap.get(movie.kinopoiskId),
      }));
      setWheelData(newData);
    } else setWheelData([{ option: '', backgroundColor: '#6495ed' }]);
  }, [movies]);

  const toggleChange = (newAlignment: string) => {
    if (newAlignment !== null) setAlignment(newAlignment);
  };

  const handleSpinClick = () => {
    if (!mustSpin) {
      const newPrizeNumber = Math.floor(Math.random() * wheelData.length);
      setPrizeNumber(newPrizeNumber);
      setMustSpin(true);
    }
  };

  const speedChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    event.preventDefault();
    const newValue = Number(event.target.value);
    setSpinDuration(newValue < 1 ? 1 : newValue);
  };

  const onStopSpinning = () => {
    setMustSpin(false);
    if (alignment === 'dropout' && wheelData.length > 1) {
      setWheelData(wheelData.filter((x) => x !== wheelData[prizeNumber]));
      if (wheelData.length <= 1) setModal(true);
    } else setModal(true);
  };

  const colors = () => {
    return wheelData.map((item) => item.backgroundColor);
  };

  return (
    <Box>
      <Box>
        <ToggleButtonGroup
          color="primary"
          value={alignment}
          exclusive
          onChange={(_, value) => toggleChange(value)}
          aria-label="Platform"
        >
          <ToggleButton value="standart">{t('regular')}</ToggleButton>
          <ToggleButton value="dropout">{t('elimination')}</ToggleButton>
        </ToggleButtonGroup>
        <Box>
          <TextField
            type="number"
            margin="dense"
            label="Время прокрутки"
            value={spinDuration}
            variant="standard"
            onChange={speedChange}
          />
        </Box>
      </Box>
      <Box onClick={handleSpinClick} sx={{ cursor: 'pointer', mt: 4 }}>
        <Wheel
          mustStartSpinning={mustSpin}
          prizeNumber={prizeNumber}
          textColors={['#ffffff']}
          backgroundColors={colors()}
          data={wheelData}
          fontSize={15}
          textDistance={55}
          outerBorderWidth={2}
          innerBorderWidth={10}
          radiusLineWidth={2}
          outerBorderColor="black"
          spinDuration={spinDuration / 10}
          onStopSpinning={onStopSpinning}
        />
      </Box>

      <WinnerModal
        username={'Yaroslav'}
        wheelData={wheelData}
        modal={modal}
        prizeNumber={prizeNumber}
        setOpen={setModal}
      />
    </Box>
  );
};
export default SpinningWheel;
