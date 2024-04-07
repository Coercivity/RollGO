import i18next from 'i18next';
import HttpApi from 'i18next-http-backend';
import { initReactI18next } from 'react-i18next';

export const defaultNS = 'common';

i18next.use(initReactI18next).use(HttpApi).init({
  lng: 'ru', // if you're using a language detector, do not define the lng option
  debug: true,
  ns: defaultNS,
  defaultNS,
  fallbackLng: false,
});
