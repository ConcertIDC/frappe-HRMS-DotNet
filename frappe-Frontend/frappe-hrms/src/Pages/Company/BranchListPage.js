import React, { useEffect } from 'react';
import CommonTable from '../../Components/Common/CommonTable';
import { getBranchList } from '../../redux/actions/CompanyAction';
import { useDispatch, useSelector } from 'react-redux';

const BranchListPage = () => {
  const columns = [    
    { key: 'branchName', header: 'ID' },
    { key: 'branchName', header: 'Branch' },
    { key: 'action', header: 'Actions' },
  ];
  const dispatch = useDispatch();
  const branchList = useSelector((state) => state.Company.CompanyModel);

  useEffect(() => {
    dispatch(getBranchList());
  }, [dispatch]);

  console.log(branchList);
  

  return <CommonTable data={branchList} columns={columns} title={'Branch'} searchTitle={'ID'}/>;
};

export default BranchListPage;
