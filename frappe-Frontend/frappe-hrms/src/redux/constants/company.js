import { createAction } from '@reduxjs/toolkit';

export const Company = {
    REQUEST: createAction("COMPANY_REQUEST"),
    LOADING: createAction("COMPANY_LOADING"),
    SUCCESS: createAction("COMPANY_SUCCESS"),
    ERROR: createAction("COMPANY_ERROR"),
    DETAIL: createAction("COMPANY_DETAIL"),
    LOGOUT: createAction("COMPANY_LOGOUT"),
    DESIGNATION: createAction("COMPANY_DESIGNATION"),
    BRANCH: createAction("COMPANY_BRANCH"),
    DEPARTMENT: createAction("COMPANY_DEPARTMENT"),
    EMPLOYMENT_TYPE: createAction("COMPANY_EMPLOYMENTTYPE"),
};
