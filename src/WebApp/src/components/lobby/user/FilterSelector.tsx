import { FC } from 'react';
import { MenuItem, Select, SelectChangeEvent } from '@mui/material';

import { User } from '@models/User';

interface SelectorOptions {
  value: string;
  name: string;
}
type UserKeys = keyof User;
interface FilterSelectorProps {
  value: string;
  options: SelectorOptions[];
  defaultValue: string;
  onChange: (event: UserKeys) => void;
}

const FilterSelector: FC<FilterSelectorProps> = ({ value, options, defaultValue, onChange }) => {
  const handleChange = (event: SelectChangeEvent) => {
    onChange(event.target.value as UserKeys);
  };
  return (
    <Select value={value} label={defaultValue} onChange={handleChange} sx={{ color: 'white' }}>
      {options.map((option) => (
        <MenuItem key={option.value} value={option.value}>
          {option.name}
        </MenuItem>
      ))}
    </Select>
  );
};

export default FilterSelector;
