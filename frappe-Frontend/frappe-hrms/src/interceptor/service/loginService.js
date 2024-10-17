import axiosInstance from '../cofig/axiosConfig';

export const loginApi = (payload) => {
    return axiosInstance.post('/login', payload);
};

