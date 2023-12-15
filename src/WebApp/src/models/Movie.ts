export interface Movie {
  kinopoiskId: number;
  nameOriginal: string;
  nameRu: string;
  nameEn: string | null;
  posterUrl: string;
  posterUrlPreview: string;
  ratingImdb: number;
  ratingKinopoisk: number;
  year: number;
  filmLength: number;
  webUrl: string;

  kinopoiskHDId: string | null;
  imdbId: string;
  coverUrl: string | null;
  logoUrl: string | null;
  reviewsCount: number;
  ratingGoodReview: number;
  ratingGoodReviewVoteCount: number;
  ratingKinopoiskVoteCount: number;
  ratingImdbVoteCount: number;
  ratingFilmCritics: number | null;
  ratingFilmCriticsVoteCount: number;
  ratingAwait: number | null;
  ratingAwaitCount: number;
  ratingRfCritics: number | null;
  ratingRfCriticsVoteCount: number;
  slogan: string;
  description: string;
  shortDescription: string | null;
  editorAnnotation: string | null;
  isTicketsAvailable: boolean;
  productionStatus: number | null;
  type: string;
  ratingMpaa: string | null;
  ratingAgeLimits: string;
  startYear: number | null;
  endYear: number | null;
  serial: boolean;
  shortFilm: boolean;
  completed: boolean;
  hasImax: boolean;
  has3D: boolean;
  lastSync: string;
}

export interface MovieGenre {
  genre: string;
}

export interface MovieCountry {
  country: string;
}
