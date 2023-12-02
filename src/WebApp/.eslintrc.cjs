module.exports = {
    root: true,
    env: {browser: true, es2020: true},
    extends: [
        'plugin:@typescript-eslint/recommended',
        'plugin:react-hooks/recommended',
        'plugin:react/recommended',
        'airbnb-typescript',
        "plugin:prettier/recommended",
    ],
    parserOptions: {
        project: './tsconfig.json',
        ecmaFeatures: {
            jsx: true,
        },
        ecmaVersion: 12,
        sourceType: 'module',
    },
    ignorePatterns: ['node_modules/', 'dist', '.eslintrc.cjs', '*.config.*'],
    parser: '@typescript-eslint/parser',
    plugins: ['react-refresh', 'simple-import-sort'],
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
        'react/react-in-jsx-scope': 'off',
        'react/display-name': 'off',
        '@typescript-eslint/no-unused-vars': ["error", { "argsIgnorePattern": "^_" }]
    },
}
