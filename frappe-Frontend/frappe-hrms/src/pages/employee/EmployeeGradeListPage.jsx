import React, { useEffect } from 'react';
import CommonTable from '../../components/common/CommonTable';
import { getEmployeeGradeList } from '../../redux/actions/EmployeeAction';
import { useDispatch, useSelector } from 'react-redux';

const EmployeeGradeListPage = () => {
  const columns = [    
    { key: 'grade', header: 'ID' },
    { key: 'action', header: 'Actions' },
  ];
  const dispatch = useDispatch();
  const EmployeeGradeList = useSelector((state) => state.Employee.EmployeeModel);
  
  useEffect(() => {
    dispatch(getEmployeeGradeList());
  }, [dispatch]);

  console.log(EmployeeGradeList);
  

  return <CommonTable data={EmployeeGradeList} columns={columns} title={'Employee Grade'} searchTitle={'ID'}/>;
};

export default EmployeeGradeListPage;
