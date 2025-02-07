import axiosInstance from '../cofig/axiosConfig';

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

