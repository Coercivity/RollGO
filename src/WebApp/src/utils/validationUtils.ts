import { AxiosError } from 'axios';

import { ErrorCode } from '@enums/ErrorCode';
import { CustomError, ValidationError } from '@models/Error';

export const isValidationError = (error: unknown): error is ValidationError => {
  return (
    !!(error as ValidationError).errors &&
    typeof (error as ValidationError).errors === 'object' &&
    !!(error as ValidationError).status &&
    typeof (error as ValidationError).status === 'number' &&
    !!(error as ValidationError).title &&
    typeof (error as ValidationError).title === 'string'
  );
};

export const isCustomError = (error: unknown): error is CustomError => {
  return (error as CustomError).code !== undefined && (error as CustomError).message !== undefined;
};

export const handleError = (error: unknown, callback: (code: ErrorCode) => void): void => {
  if (!(error instanceof AxiosError) || !error.response) {
    console.error(error);
    return;
  }
  if (isCustomError(error.response.data)) {
    callback(error.response.data.code);
  } else if (isValidationError(error.response.data)) {
    const fields = Object.keys(error.response.data);
    callback(`${fields[0]}Validation` as ErrorCode);
  }
};
