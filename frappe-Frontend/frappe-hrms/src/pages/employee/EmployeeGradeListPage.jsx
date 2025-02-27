import React, { useEffect } from 'react';
import CommonTable from '../../components/common/CommonTable';
import { getEmployeeGradeList } from '../../redux/actions/EmployeeAction';
import { useDispatch, useSelector } from 'react-redux';

const EmployeeGradeListPage = () => {
  const columns = [    
    { key: 'grade', header: 'ID' },
  ];
  const dispatch = useDispatch();
  const EmployeeGradeList = useSelector((state) => state.employee.employeeGrade);
  
  useEffect(() => {
    dispatch(getEmployeeGradeList());
  }, [dispatch]);

  console.log(EmployeeGradeList);
  

  return <CommonTable data={EmployeeGradeList} columns={columns} title={'Employee Grade'} searchTitle={'ID'}/>;
};

export default EmployeeGradeListPage;
