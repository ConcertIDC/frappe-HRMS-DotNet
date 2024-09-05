import axios from "axios";
import { Login } from "../constants/login";
import { BASEURL } from "../../Constant/ConstatntData";
 
export const LoginAction = (payload) => async (dispatch) => {
    dispatch({
        type: Login.LOADING,
        payload: { loading: true },
    });
    try {
        const { data } = await axios.post(`${BASEURL}Login`, payload);
        localStorage.setItem("USER", data && data?.username);
        await dispatch({
            type: Login.SUCCESS,
            payload: { loading: false, data: data },
        });
        window.location.href = "/dashboard";
    } catch (err) {
        await dispatch({
            type: Login.ERROR,
            payload: { loading: false, data: {} },
        });
    }
};
 