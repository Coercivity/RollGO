import { SearchType } from '../enums/SearchType';

export const booleanSort = (a: boolean, b: boolean) => Number(b) - Number(a);

export const stringSort = (a: string, b: string) => a.localeCompare(b);

export const generalSort = (a?: boolean | string, b?: boolean | string): number => {
  if (typeof a === 'boolean' && typeof b === 'boolean') return booleanSort(a, b);
  if (typeof a === 'string' && typeof b === 'string') return stringSort(a, b);
  return 0;
};

const PRE_ID_TOKENS = ['film', 'series'];

export const getIdFromUrl = (url: string): number => {
  const arr = url.split('/');
  const index = arr.findIndex((x) => PRE_ID_TOKENS.includes(x));
  return Number(arr[index + 1] ?? '');
};

export const getTypeByValue = (value: string) => {
  if (!Number.isNaN(Number(value))) return SearchType.ID;
  const expression =
    /https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)/;
  if (value.match(expression)) return SearchType.LINK;
  return SearchType.NAME;
};
