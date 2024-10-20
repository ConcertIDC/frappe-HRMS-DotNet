import axiosInstance from '../cofig/axiosConfig';

export const organisationSetupApi = (payload) => {
    return axiosInstance.post('/Company/SetupOrganisation', payload);
};