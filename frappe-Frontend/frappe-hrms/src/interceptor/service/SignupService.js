import axiosInstance from '../config/axiosConfig';

export const signupApi = (payload) => {
    return axiosInstance.post('/login', payload);
};