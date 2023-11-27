module.exports = {
    root: true,
    env: {browser: true, es2020: true},
    extends: [
        'plugin:@typescript-eslint/recommended',
        'plugin:react-hooks/recommended',
        'plugin:react/recommended',
        'airbnb-typescript'],
    parserOptions: {
        project: './tsconfig.json'
    },
    ignorePatterns: ['dist', '.eslintrc.cjs', '*.config.*'],
    parser: '@typescript-eslint/parser',
    plugins: ['react-refresh'],
    rules: {
        'react-refresh/only-export-components': [
            'warn',
            {allowConstantExport: true},
        ],
        'import/extensions': 'off',
        "import/no-extraneous-dependencies": 'off',
        semi: 'error',
        'react/button-has-type': 'off',
        'eol-last': 'error',
    },
}
