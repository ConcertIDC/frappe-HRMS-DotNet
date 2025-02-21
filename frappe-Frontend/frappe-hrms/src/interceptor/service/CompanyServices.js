import axiosInstance from '../config/axiosConfig';

export const companyApi = () => {
    return axiosInstance.get('/Company/GetAllCompanies');
};
export const branchApi = () => {
    return axiosInstance.get('/Company/GetAllBranches');
};
export const departmentApi = () => {
    return axiosInstance.get('/Company/GetAllDepartments');
};
export const designationtApi = () => {
    return axiosInstance.get('/Company/GetAllDesignations');
};
export const employmentTypeApi = () => {
    return axiosInstance.get('/Company/GetAllemploymentTypes');
};
export const createCompanyApi = (payload) => {
    return axiosInstance.post('/Company/CreateCompany',payload);
};
export const getCompanyApi = (id) => {
    return axiosInstance.get(`/Company/GetCompanyById?id=${id}`);
};
export const updateCompanyApi = (payload) => {
    return axiosInstance.put('/Company/EditCompany',payload);
};

