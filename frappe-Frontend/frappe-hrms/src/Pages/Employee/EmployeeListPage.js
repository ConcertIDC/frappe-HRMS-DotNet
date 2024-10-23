import React from 'react';
import CommonTable from '../../Components/Common/CommonTable';

const EmployeeListPage = () => {
  const columns = [
    { key: 'fullName', header: 'Full Name' },
    { key: 'status', header: 'Status' },
    { key: 'designation', header: 'Designation' },
    { key: 'id', header: 'ID' },
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

  return <CommonTable columns={columns} data={data} onAdd={handleAdd} onFilter={handleFilter} />;
};

export default EmployeeListPage;
