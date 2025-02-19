import React, { useEffect } from 'react';
import CommonTable from '../../components/common/CommonTable';
import { useDispatch, useSelector } from 'react-redux';
import { getDesignationList } from '../../redux/actions/CompanyAction';

const DesignationListPage = () => {
  const columns = [    
    { key: 'designationName', header: 'ID' },
    { key: 'designationName', header: 'Designation' },
    { key: 'action', header: 'Actions' },
  ];
  const dispatch = useDispatch();
  const designationList = useSelector((state) => state.Company.CompanyModel);

  useEffect(() => {
    dispatch(getDesignationList());
  }, [dispatch]);

  console.log(designationList);
  

  return <CommonTable data={designationList} columns={columns} title={'Designation'} searchTitle={'ID'}/>;
};

export default DesignationListPage;
