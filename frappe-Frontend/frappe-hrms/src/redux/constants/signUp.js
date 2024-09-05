import { createAction } from '@reduxjs/toolkit';

export const Signup = {
    REQUEST: createAction("SIGNUP_REQUEST"),
    LOADING: createAction("SIGNUP_LOADING"),
    SUCCESS: createAction("SIGNUP_SUCCESS"),
    ERROR: createAction("SIGNUP_ERROR")
};
