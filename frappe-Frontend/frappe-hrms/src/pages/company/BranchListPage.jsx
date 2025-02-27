import React, { useEffect } from 'react';
import CommonTable from '../../components/common/CommonTable';
import { getBranchList } from '../../redux/actions/CompanyAction';
import { useDispatch, useSelector } from 'react-redux';

const BranchListPage = () => {
  const columns = [    
    { key: 'branchName', header: 'ID' },
    { key: 'branchName', header: 'Branch' },
  ];
  const dispatch = useDispatch();
  const branchList = useSelector((state) => state.company.branch);

  useEffect(() => {
    dispatch(getBranchList());
  }, [dispatch]);

  console.log(branchList);
  

  return <CommonTable data={branchList} columns={columns} title={'Branch'} searchTitle={'ID'}/>;
};

export default BranchListPage;
