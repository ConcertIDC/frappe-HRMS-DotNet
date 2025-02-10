import React, { useEffect } from 'react';
import CommonTable from '../../Components/Common/CommonTable';
import { getEmployeeGroupList } from '../../redux/actions/EmployeeAction';
import { useDispatch, useSelector } from 'react-redux';

const EmployeeGroupListPage = () => {
  const columns = [    
    { key: 'name', header: 'ID' },
    { key: 'name', header: 'Name' },
    { key: 'action', header: 'Actions' },
  ];
  const dispatch = useDispatch();
  const EmployeeGroupList = useSelector((state) => state.Employee.EmployeeModel);
  
  useEffect(() => {
    dispatch(getEmployeeGroupList());
  }, [dispatch]);

  console.log(EmployeeGroupList);
  

  return <CommonTable data={EmployeeGroupList} columns={columns} title={'Employee Group'} searchTitle={'ID'}/>;
};

export default EmployeeGroupListPage;
