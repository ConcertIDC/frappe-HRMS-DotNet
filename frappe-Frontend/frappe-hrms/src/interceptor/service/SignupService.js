import axiosInstance from '../cofig/axiosConfig';

export const signupApi = (payload) => {
    return axiosInstance.post('/login', payload);
};