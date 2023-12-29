export interface Movie {
  kinopoiskId: number;
  nameOriginal: string;
  nameRu: string;
  nameEn: string | null;
  posterUrl: string;
  ratingImdb: number;
  ratingKinopoisk: number;
  year: number;
  filmLength: number;
  webUrl: string;
  imdbId: string;
}

export interface MovieGenre {
  genre: string;
}

export interface MovieCountry {
  country: string;
}
