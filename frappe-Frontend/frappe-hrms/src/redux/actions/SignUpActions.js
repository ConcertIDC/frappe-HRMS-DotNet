import axios from "axios";
import { Signup } from "../constants/signUp";
import { BASEURL } from "../../Constant/ConstatntData";

export const SignupAction = (payload) => async (dispatch) => {
    dispatch({
        type: Signup.LOADING,
        payload: { loading: true },
    });
    try {
        const { data } = await axios.post(`${BASEURL}Signup`, payload);
        
        await dispatch({
            type: Signup.SUCCESS,
            payload: { loading: false, data: data },
        });
        window.location.href = "/organisation";

    } catch (err) {
        await dispatch({
            type: Signup.ERROR,
            payload: { loading: false, data: {} },
        });
    }
};
