import React, { useEffect } from 'react';
import CommonTable from '../../components/common/CommonTable';
import { useDispatch, useSelector } from 'react-redux';
import { getDesignationList } from '../../redux/actions/CompanyAction';

const DesignationListPage = () => {
  const columns = [    
    { key: 'designationName', header: 'ID' },
    { key: 'designationName', header: 'Designation' },
  ];
  const dispatch = useDispatch();
  const designationList = useSelector((state) => state.company.designation);

  useEffect(() => {
    dispatch(getDesignationList());
  }, [dispatch]);

  console.log(designationList);
  

  return <CommonTable data={designationList} columns={columns} title={'Designation'} searchTitle={'ID'}/>;
};

export default DesignationListPage;
