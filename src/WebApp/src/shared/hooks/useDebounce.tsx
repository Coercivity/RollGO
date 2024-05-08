import { useEffect, useRef } from 'react';

export const useDebounce = (func: (newMovie: string) => void, delay: number, cleanUp = false) => {
  const timeoutRef = useRef<number>();
  function clearTimer() {
    if (timeoutRef.current) {
      clearTimeout(timeoutRef.current);
      timeoutRef.current = undefined;
    }
  }

  useEffect(() => (cleanUp ? clearTimer : undefined), [cleanUp]);
  return (newMovie: string) => {
    clearTimer();
    timeoutRef.current = setTimeout(() => func(newMovie), delay) as unknown as number;
  };
};
