module.exports = {
  root: true,
  env: { browser: true, es2020: true },
  extends: [
    'plugin:@typescript-eslint/recommended',
    'plugin:react-hooks/recommended',
    'plugin:react/recommended',
    'airbnb-typescript',
    'plugin:prettier/recommended',
    'plugin:promise/recommended',
    'plugin:i18next/recommended', 
    '@feature-sliced',
  ],
  settings: {
    'import/resolver': {
      typescript: {},
      alias: {
        extensions: ['.ts', '.tsx'],
        map: [['@', '.']],
      },
    },
  },
  parserOptions: {
    project: './tsconfig.json',
    tsconfigRootDir: './',
    ecmaFeatures: {
      jsx: true,
    },
    ecmaVersion: 12,
    sourceType: 'module',
  },
  ignorePatterns: ['node_modules/', 'dist', '.eslintrc.cjs', '*.config.*'],
  parser: '@typescript-eslint/parser',
  plugins: [
    'react-refresh',
    'promise',
    'import',
    '@typescript-eslint',
    'prettier',
    'i18next',
  ],
  rules: {
    'react-refresh/only-export-components': ['warn', { allowConstantExport: true }],
    'import/extensions': 'off',
    'import/no-extraneous-dependencies': 'off',
    semi: 'error',
    'react/button-has-type': 'off',
    'eol-last': 'error',
    'react/react-in-jsx-scope': 'off',
    'react/display-name': 'off',
    '@typescript-eslint/no-unused-vars': ['error', { argsIgnorePattern: '^_' }],
    'import/first': 'error',
    'import/newline-after-import': 'error',
    'import/no-duplicates': 'off',
    'linebreak-style': ['error', 'windows'],
    'prettier/prettier': [
      'error',
      {
        endOfLine: 'crlf',
        jsxSingleQuote: false,
        printWidth: 100,
        proseWrap: 'never',
        quoteProps: 'as-needed',
        semi: true,
        singleQuote: true,
        tabWidth: 2,
        trailingComma: 'es5',
        useTabs: false,
      },
    ],
  },
};
