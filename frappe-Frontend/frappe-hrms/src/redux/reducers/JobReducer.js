import { Job } from "../constants/job";

const initialJobState = {
    JobModel: [],
    loading: false,
};

export const JobReducer = (state = initialJobState, action) => {
    switch (action?.type) {
        case Job.LOADING.type:
            return { ...state, loading: true };
        case Job.REQUEST.type:
            return { ...state, JobModel: action?.payload };
        case Job.SUCCESS.type:            
            return { ...state, JobModel: action?.payload.data, loading: false };
        case Job.ERROR.type:
            return { ...state, JobModel: action?.payload, loading: false };
        default:
            return state;
    }
};
