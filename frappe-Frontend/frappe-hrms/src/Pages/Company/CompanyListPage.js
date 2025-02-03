import React, { useEffect } from 'react';
import CommonTable from '../../Components/Common/CommonTable';
import { getCompanyList } from '../../redux/actions/CompanyAction';
import { useDispatch, useSelector } from 'react-redux';

const CompanyListPage = () => {
  const columns = [    
    { key: 'companyName', header: 'ID' },
    { key: 'country', header: 'Country' },
    { key: 'parentCompany', header: 'Parent Company' },
    { key: 'action', header: 'Actions' },
  ];
  const dispatch = useDispatch();
  const companyList = useSelector((state) => state.Company.CompanyModel);

  const handleAdd = () => {
    console.log('Add Employee Clicked');
  };

  const handleFilter = () => {
    console.log('Filter Clicked');
  };

  useEffect(() => {
    dispatch(getCompanyList());
  }, [dispatch]);

  console.log(companyList);
  

  return <CommonTable data={companyList} columns={columns} title={'Company'}/>;
};

export default CompanyListPage;
