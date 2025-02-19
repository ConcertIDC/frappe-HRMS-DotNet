import React, { useEffect } from 'react';
import CommonTable from '../../components/common/CommonTable';
import { getDepartmentList } from '../../redux/actions/CompanyAction';
import { useDispatch, useSelector } from 'react-redux';

const DepartmentListPage = () => {
  const columns = [    
    { key: 'departmentName', header: 'ID' },
    { key: 'disabled', header: 'Status' },
    { key: 'departmentName', header: 'Department' },
    { key: 'action', header: 'Actions' },
  ];
  const dispatch = useDispatch();
  const departmentList = useSelector((state) => state.Company.CompanyModel);

  useEffect(() => {
    dispatch(getDepartmentList());
  }, [dispatch]);

  console.log(departmentList);
  

  return <CommonTable data={departmentList} columns={columns} title={'Department'} searchTitle={'ID'}/>;
};

export default DepartmentListPage;
