import React from 'react';
import CommonTable from '../../Components/Common/CommonTable';

const EmployeeListPage = () => {
  const columns = [    
    { key: 'id', header: 'ID' },
    { key: 'country', header: 'Country' },
    { key: 'parentCompany', header: 'Parent Company' },
    { key: 'action', header: 'Actions' },
  ];

  const data = [
    { fullName: 'SARAN', status: 'Active', designation: 'HR', id: 'HR-EMP-00001' },
    // Add more rows as needed
  ];

  const handleAdd = () => {
    console.log('Add Employee Clicked');
  };

  const handleFilter = () => {
    console.log('Filter Clicked');
  };

  return <CommonTable data={data} columns={columns} title={'Company'}/>;
};

export default EmployeeListPage;
