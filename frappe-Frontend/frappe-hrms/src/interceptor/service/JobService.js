import axiosInstance from '../config/axiosConfig';

export const jobApplicantApi = () => {
    return axiosInstance.get('/Employee/GetAllJobApplicants');
};