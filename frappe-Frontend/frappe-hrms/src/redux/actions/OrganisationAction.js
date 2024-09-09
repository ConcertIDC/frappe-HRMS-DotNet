import axios from "axios";
import { Organisation } from "../constants/organisation";
import { BASEURL } from "../../Constant/ConstatntData";

export const OrganisationAction = (payload) => async (dispatch) => {
    dispatch({
        type: Organisation.LOADING,
        payload: { loading: true },
    });
    try {
        console.log("dcvh",payload);
        
        const { data } = await axios.post(`${BASEURL}Company/SetupOrganisation`, payload);
        console.log(data);
        await dispatch({
            type: Organisation.SUCCESS,
            payload: { loading: false, data: data },
        });
        window.location.href = "/dashboard";    
    } catch (err) {
        await dispatch({
            type: Organisation.ERROR,
            payload: { loading: false, data: {} },
        });
    }
};
