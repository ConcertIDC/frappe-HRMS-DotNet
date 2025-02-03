import axiosInstance from '../cofig/axiosConfig';

export const companyApi = () => {
    return axiosInstance.get('/Company/GetAllCompanies');
};

