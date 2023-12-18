import React, { FC, useState } from 'react';
import SearchIcon from '@mui/icons-material/Search';
import { Button, Container } from '@mui/material';
import InputBase from '@mui/material/InputBase';
import { alpha, styled } from '@mui/material/styles';

import { MovieData } from '../api/MovieData';
import { Movie } from '../models/Movie';

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

const SearchIconWrapper = styled('div')(({ theme }) => ({
  padding: theme.spacing(0, 2),
  height: '100%',
  position: 'absolute',
  pointerEvents: 'none',
  display: 'flex',
  alignItems: 'center',
  justifyContent: 'center',
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
      const film = MovieData.find((f) => f.webUrl === value);
      if (film) setMovies([...movies, film]);
      else noFilm();
      setValue('');
    }
  };

  const onClick = (): void => {
    searchFilm();
  };

  return (
    <Container sx={{ display: 'flex' }}>
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

      <Button onClick={onClick}>
        <SearchIconWrapper>
          <SearchIcon />
        </SearchIconWrapper>
      </Button>
    </Container>
  );
};

export default SearchAppBar;
