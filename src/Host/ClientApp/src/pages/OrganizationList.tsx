import * as React from 'react';
import AppTable, { AppTableColumn, AppTableRow } from '../shared/AppTable';
import { Box } from '@mui/material';

export interface Organization {
  id: number;
  name: string;
  user: string;
}

const OrganizationList: React.FC = () => {
  const data : Organization[] = 
    [
      { id: 1, name: 'ТестовоеПервое', user: '-' },
      { id: 2, name: 'ТестовоеВторое', user: '-' },
      { id: 2, name: 'ТестовоеДлинное', user: 'ТестовоеДлинное' },
    ];

  const render = () => {
    return (<React.Fragment>
        <div style={{textAlign: 'center'}}>
          <h1>Список владений</h1>
        </div>
        <Box sx={{ maxWidth: '500px', margin: 'auto' }}>
          {renderOrganizationsTable()}
        </Box>
      </React.Fragment>
    )
  }

  const renderOrganizationsTable = () => {
    const columnList: AppTableColumn[] = [
      { title: 'Владение', sx: { maxWidth: { xs: '50%', sm: '40%' } } },
      { title: 'Игрок', sx: { maxWidth: { xs: '50%', sm: '40%' } } }
    ]
    const rowList: AppTableRow[] = data?.map((organization: Organization) => {
      return {
        key: organization.id.toString(),
        cells: [
          organization.name,
          organization.user
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
