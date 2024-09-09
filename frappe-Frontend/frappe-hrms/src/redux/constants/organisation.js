import { createAction } from '@reduxjs/toolkit';

export const Organisation = {
    REQUEST: createAction("ORGANISATION_REQUEST"),
    LOADING: createAction("ORGANISATION_LOADING"),
    SUCCESS: createAction("ORGANISATION_SUCCESS"),
    ERROR: createAction("ORGANISATION_ERROR")
};