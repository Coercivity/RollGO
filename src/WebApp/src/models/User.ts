export interface User {
  id: string;
  username: string;
  email?: string;
  isOnline: boolean;
  icon?: string;
  isAnonymous?: boolean;
}
