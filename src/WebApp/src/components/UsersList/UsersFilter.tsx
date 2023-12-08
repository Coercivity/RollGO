import { FC } from 'react';
import { Box, FormControl, InputLabel } from '@mui/material';
import FilterSelector from './FilterSelector';
import { LocalizationNamespace } from '../../enums/LocalizationNamespace';
import { useTranslation } from 'react-i18next';
import { generalSort } from '../../utils/utils';
import { User } from '../../models/User';

interface UsersFilterProps {
  filter: string;
  setFilter: (filter: string) => void;
  setUsers: (obj: User[]) => void;
  users: User[];
}

const UsersFilter: FC<UsersFilterProps> = ({ filter, setFilter, setUsers, users }) => {
  const { t } = useTranslation(LocalizationNamespace.LOBBY);

  const sortUsers = (sort: keyof User) => {
    setFilter(sort);
    setUsers([...users].sort((a, b) => generalSort(a[sort], b[sort])));
  };

  return (
    <Box sx={{ color: 'white' }}>
      <FormControl
        fullWidth
        sx={{ mt: 1, minWidth: 100, borderColor: 'white', color: 'error' }}
        size="small"
      >
        <InputLabel sx={{ color: 'white' }}>{t('sort')}</InputLabel>
        <FilterSelector
          defaultValue={t('sort')}
          value={filter}
          onChange={sortUsers}
          options={[
            { value: 'nickname', name: 'По имени' },
            { value: 'isOnline', name: 'По статусу' },
          ]}
        />
      </FormControl>
    </Box>
  );
};

export default UsersFilter;
