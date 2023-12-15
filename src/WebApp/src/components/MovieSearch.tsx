import React, { FC, useState } from 'react';
import { styled, alpha } from '@mui/material/styles';
import { Container, Button } from '@mui/material';
import SearchIcon from '@mui/icons-material/Search';
import InputBase from '@mui/material/InputBase';
import { MovieData } from '../API/MovieData';
import { Movie } from '../models/Movie';

const Search = styled('div')(({ theme }) => ({
  position: 'relative',
  borderRadius: theme.shape.borderRadius,
  backgroundColor: alpha(theme.palette.common.white, 0.15),

  marginLeft: 0,
  width: '100%',
  [theme.breakpoints.up('sm')]: {
    marginLeft: theme.spacing(1),
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
    padding: theme.spacing(1, 0, 1, 0),
    // vertical padding + font size from searchIcon
    paddingLeft: `calc(1em + ${theme.spacing(4)})`,
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
  const onKeyPress = (event: React.KeyboardEvent<HTMLDivElement>): void => {
    console.log(event.code);
    if (event.code === 'Enter') searchFilm();
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

      <Button onClick={onClick} onSubmit={onKeyPress}>
        <SearchIconWrapper>
          <SearchIcon />
        </SearchIconWrapper>
      </Button>
    </Container>
  );
};

export default SearchAppBar;
