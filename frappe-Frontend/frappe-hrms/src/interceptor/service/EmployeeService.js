import axiosInstance from '../cofig/axiosConfig';

export const employeeApi = () => {
    return axiosInstance.get('/Employee/GetAllEmployees');
};

export const employeeGroupApi = () => {
    return axiosInstance.get('/Employee/GetAllGroups');
};

export const employeeGradeApi = () => {
    return axiosInstance.get('/Employee/GetAllEmployeeGrades');
};

