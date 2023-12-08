export const booleanSort = (a: boolean, b: boolean) => Number(b) - Number(a);

export const stringSort = (a: string, b: string) => a.localeCompare(b);

export const generalSort = (a?: boolean | string, b?: boolean | string): number => {
  if (typeof a === 'boolean' && typeof b === 'boolean') return booleanSort(a, b);
  if (typeof a === 'string' && typeof b === 'string') return stringSort(a, b);
  return 0;
};
