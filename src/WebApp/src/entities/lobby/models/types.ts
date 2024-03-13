export interface Lobby {
  id: string;
  name: string;
  adminId: string;
  minimalRating: number;
  moviesPerUser: number;
  withCoefficient: boolean;
}
