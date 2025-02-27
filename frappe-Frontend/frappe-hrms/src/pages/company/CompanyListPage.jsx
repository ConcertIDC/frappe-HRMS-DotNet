import React, { useEffect } from 'react';
import CommonTable from '../../components/common/CommonTable';
import { deleteCompany, getCompanyList } from '../../redux/actions/CompanyAction';
import { useDispatch, useSelector } from 'react-redux';
import { useNavigate } from 'react-router-dom';

const CompanyListPage = () => {
  const columns = [    
    { key: 'companyName', header: 'ID' },
    { key: 'country', header: 'Country' },
    { key: 'parentCompany', header: 'Parent Company' },
  ];
  const dispatch = useDispatch();
  const companyList = useSelector((state) => state.company.companyModel);

  useEffect(() => {
    dispatch(getCompanyList());
  }, [dispatch]);

  console.log(companyList);
  const navigate = useNavigate();
  const handleClick = () => {
    navigate('/add-company');
  }
  const handleDelete = (id) => {
    dispatch(deleteCompany(id));
  }

  return <CommonTable handleDelete={handleDelete} data={companyList} columns={columns} title={'Company'} deleteTitle='companyName' searchTitle={'ID'} handleClick={handleClick}/>;
};

export default CompanyListPage;
