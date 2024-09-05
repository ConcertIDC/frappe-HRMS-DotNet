import axios from "axios";
import { Signup } from "../constants/signUp";
import { BASEURL } from "../../Constant/ConstatntData";

export const SignupAction = (payload) => async (dispatch) => {
    console.log(BASEURL,"gd");
    
    dispatch({
        type: Signup.LOADING,
        payload: { loading: true },
    });
    try {
        console.log(BASEURL,"DH");
        
        const { data } = await axios.post(`${BASEURL}Signup`, payload);
        console.log(data,"hi");
        
        await dispatch({
            type: Signup.SUCCESS,
            payload: { loading: false, data: data },
        });

    } catch (err) {
        await dispatch({
            type: Signup.ERROR,
            payload: { loading: false, data: {} },
        });
    }
};
