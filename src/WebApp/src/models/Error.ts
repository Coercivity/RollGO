import { ErrorCode } from '@enums/ErrorCode';

export interface ValidationError {
  errors: Record<string, unknown>;
  status: number;
  title: string;
}

export interface CustomError {
  code: ErrorCode;
  description: string;
}
