import React, { useEffect } from 'react';
import CommonTable from '../../Components/Common/CommonTable';
import { useDispatch, useSelector } from 'react-redux';
import { getJobApplicantList } from '../../redux/actions/JobAction';

const JobApplicantListPage = () => {
  const columns = [    
    { key: 'applicantName', header: 'Applicant Name' },
    { key: 'status', header: 'Status' },
    { key: 'designation', header: 'Job Opening' },
    { key: 'emailAddress', header: 'ID' },
    { key: 'action', header: 'Actions' },
  ];
  const dispatch = useDispatch();
  const JobApplicantList = useSelector((state) => state.Job.JobModel);
  
  useEffect(() => {
    dispatch(getJobApplicantList());
  }, [dispatch]);

  console.log(JobApplicantList);
  

  return <CommonTable data={JobApplicantList} columns={columns} title={'Job Applicant'} searchTitle={'Applicant Name'}/>;
};

export default JobApplicantListPage;
