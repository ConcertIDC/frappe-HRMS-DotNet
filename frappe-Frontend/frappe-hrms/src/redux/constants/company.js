import { createAction } from '@reduxjs/toolkit';

export const Company = {
    REQUEST: createAction("COMPANY_REQUEST"),
    LOADING: createAction("COMPANY_LOADING"),
    SUCCESS: createAction("COMPANY_SUCCESS"),
    ERROR: createAction("COMPANY_ERROR"),
    LOGOUT: createAction("COMPANY_LOGOUT")
};
