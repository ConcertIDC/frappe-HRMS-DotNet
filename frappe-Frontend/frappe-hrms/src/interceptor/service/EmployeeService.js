import axiosInstance from '../cofig/axiosConfig';

export const employeeApi = () => {
    return axiosInstance.get('/Employee/GetAllEmployees');
};

