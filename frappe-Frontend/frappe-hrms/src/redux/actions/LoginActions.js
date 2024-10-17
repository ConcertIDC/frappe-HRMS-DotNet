// import axios from "axios";
import { Login } from "../constants/index";
// import { BASEURL } from "../../Constant/ConstatntData";
import { loginApi } from "../../interceptor/service/loginService";

export const LoginAction = (payload) => async (dispatch) => {
    dispatch({
        type: Login.LOADING,
        payload: { loading: true },
    });
    try {
        const { data } = await loginApi(payload);
        localStorage.setItem("Token", data?.accessToken);
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

export const logoutAction = () => (dispatch) => {
    dispatch({
        type: Login.LOGOUT,
        payload: {},
    });
};