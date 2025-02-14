import { jobApplicantApi } from "../../interceptor/service/JobService";
import { Job } from "../constants/job";

export const getJobApplicantList = () => async (dispatch) => {
    dispatch({
        type: Job.LOADING.type,
        payload: { loading: true },
    });
    try {
        const { data } = await jobApplicantApi();
        console.log("data", data);
        await dispatch({
            type: Job.SUCCESS.type,
            payload: { loading: false, data: data },
        });
    } catch (err) {
        await dispatch({
            type: Job.ERROR.type,
            payload: { loading: false, data: {} },
        });
    }
};