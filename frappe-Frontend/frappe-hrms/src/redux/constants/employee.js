import { createAction } from '@reduxjs/toolkit';

export const Employee = {
    REQUEST: createAction("EMPLOYEE_REQUEST"),
    LOADING: createAction("EMPLOYEE_LOADING"),
    SUCCESS: createAction("EMPLOYEE_SUCCESS"),
    ERROR: createAction("EMPLOYEE_ERROR")
};
