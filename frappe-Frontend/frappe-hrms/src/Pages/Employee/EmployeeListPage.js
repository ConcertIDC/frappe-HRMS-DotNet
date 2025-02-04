import React, { useEffect } from 'react';
import CommonTable from '../../Components/Common/CommonTable';
import { getEmployeeList } from '../../redux/actions/EmployeeAction';
import { useDispatch, useSelector } from 'react-redux';

const EmployeeListPage = () => {
  const columns = [    
    { key: 'fullName', header: 'Full Name' },
    { key: 'status', header: 'Status' },
    { key: 'Designation.DesignationName', header: 'Designation' },
    { key: 'series', header: 'ID' },
    { key: 'action', header: 'Actions' },
  ];
  const dispatch = useDispatch();
  const EmployeeList = useSelector((state) => state.Employee.EmployeeModel);
  
  useEffect(() => {
    dispatch(getEmployeeList());
  }, [dispatch]);

  console.log(EmployeeList);
  

  return <CommonTable data={EmployeeList} columns={columns} title={'Employee'} searchTitle={'Full Name'}/>;
};

export default EmployeeListPage;
