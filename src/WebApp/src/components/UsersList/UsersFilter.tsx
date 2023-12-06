import React from 'react';
import { Box, FormControl, Select, MenuItem, InputLabel, SelectChangeEvent } from '@mui/material';
import ArrowDownwardRoundedIcon from '@mui/icons-material/ArrowDownwardRounded';

const UsersFilter = ({ filter, setFilter }) => {
  const handleChange = (event: SelectChangeEvent) => {
    setFilter(event.target.value as string);
  };

  return (
    <Box sx={{ color: 'white' }}>
      <FormControl variant="standard" fullWidth sx={{ mt: 1, minWidth: 100 }} size="small">
        <InputLabel>Сортировать</InputLabel>
        <Select value={filter} label="Сортировать" onChange={handleChange}>
          <MenuItem value={10}>По имени</MenuItem>
          <MenuItem value={20}>По статусу</MenuItem>
        </Select>
      </FormControl>
    </Box>
  );
};

export default UsersFilter;
