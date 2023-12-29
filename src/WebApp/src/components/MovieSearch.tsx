import React, { FC, useState } from 'react';
import SearchIcon from '@mui/icons-material/Search';
import { Box, IconButton } from '@mui/material';
import InputBase from '@mui/material/InputBase';
import { alpha, styled } from '@mui/material/styles';

import { Movie } from '@models/Movie';

import { MovieData } from '../mockAPI/MovieData';

const Search = styled('div')(({ theme }) => ({
  position: 'relative',
  borderRadius: theme.shape.borderRadius,
  backgroundColor: alpha(theme.palette.common.white, 0.15),

  marginLeft: 0,
  width: '100%',
  [theme.breakpoints.up('sm')]: {
    marginLeft: theme.spacing(0),
    width: 'auto',
  },
}));

const StyledInputBase = styled(InputBase)(({ theme }) => ({
  color: 'black',
  width: '100%',
  '& .MuiInputBase-input': {
    padding: theme.spacing(1, 1, 1, 1),
    // vertical padding + font size from searchIcon
    paddingLeft: `calc( ${theme.spacing(2)})`,
    transition: theme.transitions.create('width'),
    [theme.breakpoints.up('sm')]: {
      width: '20ch',
      '&:focus': {
        width: '26ch',
      },
    },
  },
}));

interface SearchProps {
  movies: Movie[];
  setMovies: (movies: Movie[]) => void;
}

const SearchAppBar: FC<SearchProps> = ({ movies, setMovies }) => {
  const [value, setValue] = useState('');

  const noFilm = () => {}; //пока просто заглушка

  const searchFilm = () => {
    if (value.trim().length) {
      const film = MovieData[Number(value)];
      if (film) setMovies([...movies, film]);
      else noFilm();
      setValue('');
    }
  };

  const onClick = (): void => {
    searchFilm();
  };

  return (
    <Box sx={{ display: 'flex' }}>
      <Search
        sx={{
          backgroundColor: 'lightgrey',
          border: 0.1,
          borderRadius: 3,
          borderColor: 'lightgrey',
        }}
      >
        <StyledInputBase
          placeholder="Введите фильм"
          value={value}
          onChange={(e: React.ChangeEvent<HTMLInputElement>) => setValue(e.target.value)}
        />
      </Search>

      <IconButton color="primary" onClick={onClick}>
        <SearchIcon />
      </IconButton>
    </Box>
  );
};

export default SearchAppBar;
