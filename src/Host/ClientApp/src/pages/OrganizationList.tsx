import * as React from 'react';
import AppTable, { AppTableColumn, AppTableRow } from '../shared/AppTable';
import { Box } from '@mui/material';
import { OrganizationLine, useOrganizationQuery } from '../features/OrganizationsList';

const OrganizationList: React.FC = () => {

  const { data, isLoading } = useOrganizationQuery(undefined, { refetchOnFocus: true })
    
  const render = () => {
    return (<React.Fragment>
        <Box sx={{ maxWidth: '500px', margin: 'auto', textAlign: 'center' }}>
          <h1>Список владений</h1>
          {renderOrganizationsTable()}
          {isLoading && <span >Загрузка...</span>}
        </Box>
      </React.Fragment>
    )
  }

  const renderOrganizationsTable = () => {
    const columnList: AppTableColumn[] = [
      { title: 'Владение', sx: { maxWidth: { xs: '50%', sm: '40%' } } },
      { title: 'Игрок', sx: { maxWidth: { xs: '50%', sm: '40%' } } }
    ]
    const rowList: AppTableRow[] = data?.map((organization: OrganizationLine) => {
      return {
        key: organization.id.toString(),
        cells: [
          organization.name,
          organization.user?.name ?? '-'
        ]
      } as AppTableRow
    }) ?? []
    return (
      <AppTable columnList={columnList} rowList={rowList} />
    );
  }

  return render();
};

export default OrganizationList;
