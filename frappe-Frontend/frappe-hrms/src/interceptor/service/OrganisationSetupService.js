import axiosInstance from '../config/axiosConfig';

export const organisationSetupApi = (payload) => {
    return axiosInstance.post('/Company/SetupOrganisation', payload);
};