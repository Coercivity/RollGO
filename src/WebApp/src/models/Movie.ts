export interface Movie {
  kinopoiskId: number;
  name: string;
  nameOriginal: string;
  adminId: string;
  nameRu: string;
  nameEn: string;
  posterUrl: string;
  posterUrlPreview: string;
  ratingImdb: number;
  ratingKinopoisk: number;
  year: number;
  countries: MovieGenre[];
  filmLength: number;
  genres: MovieGenre[];
  webUrl: string;
}

export interface MovieGenre {
  genre: string;
}

export interface MovieCountry {
  country: string;
}
