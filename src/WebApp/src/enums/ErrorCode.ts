export enum ErrorCode {
  EmailExists = 'EmailExists',
  PasswordsNotMatch = 'PasswordsNotMatch',
  IncorrectEmail = 'IncorrectEmail',
  UsernameExists = 'UsernameExists',
  WrongPasswordOrUsername = 'WrongPasswordOrUsername',
}

export const EMAIL_ERRORS = [ErrorCode.EmailExists, ErrorCode.IncorrectEmail];
export const USERNAME_ERRORS = [ErrorCode.UsernameExists];
export const PASSWORD_ERRORS = [ErrorCode.PasswordsNotMatch, ErrorCode.WrongPasswordOrUsername];
