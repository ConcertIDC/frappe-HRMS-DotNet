import { createAction } from '@reduxjs/toolkit';

export const Job = {
    REQUEST: createAction("JOB_REQUEST"),
    LOADING: createAction("JOB_LOADING"),
    SUCCESS: createAction("JOB_SUCCESS"),
    ERROR: createAction("JOB_ERROR"),
    LOGOUT: createAction("JOB_LOGOUT")
};