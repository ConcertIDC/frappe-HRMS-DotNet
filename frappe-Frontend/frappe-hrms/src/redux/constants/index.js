import { createAction } from '@reduxjs/toolkit';

export const Login = {
    REQUEST: createAction("LOGIN_REQUEST"),
    LOADING: createAction("LOGIN_LOADING"),
    SUCCESS: createAction("LOGIN_SUCCESS"),
    ERROR: createAction("LOGIN_ERROR"),
    LOGOUT: createAction("LOGIN_LOGOUT")
};
