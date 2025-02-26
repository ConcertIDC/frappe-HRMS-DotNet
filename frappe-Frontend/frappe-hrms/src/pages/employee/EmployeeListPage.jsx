import React, { useEffect } from 'react';
import CommonTable from '../../components/common/CommonTable';
import { getEmployeeList } from '../../redux/actions/EmployeeAction';
import { useDispatch, useSelector } from 'react-redux';
import { useNavigate } from 'react-router-dom';

const EmployeeListPage = () => {
  const columns = [    
    { key: 'fullName', header: 'Full Name' },
    { key: 'status', header: 'Status' },
    { key: 'designation', header: 'Designation' },
    { key: 'series', header: 'ID' },
    { key: 'action', header: 'Actions' },
  ];
  const dispatch = useDispatch();
  const EmployeeList = useSelector((state) => state.Employee.EmployeeModel);
  
  useEffect(() => {
    dispatch(getEmployeeList());
  }, [dispatch]);

  console.log(EmployeeList);

  const navigate = useNavigate();
  const handleClick = () => {
    navigate('/add-employee');
  }

  return <CommonTable data={EmployeeList} columns={columns} title={'Employee'} searchTitle={'Full Name'} handleClick={handleClick}/>;
};

export default EmployeeListPage;
