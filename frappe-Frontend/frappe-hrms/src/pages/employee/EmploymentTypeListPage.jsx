import React, { useEffect } from 'react';
import CommonTable from '../../components/common/CommonTable';
import { useDispatch, useSelector } from 'react-redux';
import { getEmploymentTypeList } from '../../redux/actions/CompanyAction';

const EmploymentTypeListPage = () => {
  const columns = [    
    { key: 'type', header: 'ID' },
    { key: 'type', header: 'Employment Type' },
  ];
  const dispatch = useDispatch();
  const EmploymentTypeList = useSelector((state) => state.company.employmentType);
  
  useEffect(() => {
    dispatch(getEmploymentTypeList());
  }, [dispatch]);

  return <CommonTable data={EmploymentTypeList} columns={columns} title={'Employment Type'} searchTitle={'ID'}/>;
};

export default EmploymentTypeListPage;
