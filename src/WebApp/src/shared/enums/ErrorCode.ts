export enum ErrorCode {
  EmailExists = 'EmailExists',
  PasswordsNotMatch = 'PasswordsNotMatch',
  UsernameExists = 'UsernameExists',
  WrongPassword = 'WrongPassword',
  WrongUsernameOrPassword = 'WrongUsernameOrPassword',
  PasswordValidation = 'PasswordValidation',
  EmailValidation = 'EmailValidation',
}

export const EMAIL_ERRORS = [ErrorCode.EmailExists, ErrorCode.EmailValidation];
export const USERNAME_ERRORS = [ErrorCode.UsernameExists];
export const PASSWORD_ERRORS = [
  ErrorCode.PasswordsNotMatch,
  ErrorCode.WrongUsernameOrPassword,
  ErrorCode.WrongPassword,
  ErrorCode.PasswordValidation,
];
