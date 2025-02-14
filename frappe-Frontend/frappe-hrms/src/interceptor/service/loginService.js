import axiosInstance from '../config/axiosConfig';

export const loginApi = (payload) => {
    return axiosInstance.post('/login', payload);
};

