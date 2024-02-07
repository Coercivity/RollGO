import { useEffect, useRef } from 'react';

export const useDebounce = (func: (smth: unknown) => void, delay: number, cleanUp = false) => {
  const timeoutRef = useRef<number>();
  function clearTimer() {
    if (timeoutRef.current) {
      clearTimeout(timeoutRef.current);
      timeoutRef.current = undefined;
    }
  }

  useEffect(() => (cleanUp ? clearTimer : undefined), [cleanUp]);
  return (...args: unknown[]) => {
    clearTimer();
    timeoutRef.current = setTimeout(() => func(...([args] as const)), delay) as unknown as number;
  };
};
