import React, { useEffect } from 'react';
import CommonTable from '../../components/common/CommonTable';
import { getCompanyList } from '../../redux/actions/CompanyAction';
import { useDispatch, useSelector } from 'react-redux';
import { useNavigate } from 'react-router-dom';

const CompanyListPage = () => {
  const columns = [    
    { key: 'companyName', header: 'ID' },
    { key: 'country', header: 'Country' },
    { key: 'parentCompany', header: 'Parent Company' },
  ];
  const dispatch = useDispatch();
  const companyList = useSelector((state) => state.Company.CompanyModel);

  useEffect(() => {
    dispatch(getCompanyList());
  }, [dispatch]);

  console.log(companyList);
  const navigate = useNavigate();
  const handleClick = () => {
    navigate('/add-company');
  }

  return <CommonTable data={companyList} columns={columns} title={'Company'} searchTitle={'ID'} handleClick={handleClick}/>;
};

export default CompanyListPage;
