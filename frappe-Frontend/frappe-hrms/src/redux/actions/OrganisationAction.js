import axios from "axios";
import { Organisation } from "../constants/organisation";
import { BASEURL } from "../../constant/ConstatntData";
import { organisationSetupApi } from "../../interceptor/service/OrganisationSetupService";

export const OrganisationAction = (payload) => async (dispatch) => {
    dispatch({
        type: Organisation.LOADING.type,
        payload: { loading: true },
    });
    try {
        const { data } = await organisationSetupApi(payload);
        console.log(data);
        await dispatch({
            type: Organisation.SUCCESS.type,
            payload: { loading: false, data: data },
        });
        window.location.href = "/dashboard";    
    } catch (err) {
        await dispatch({
            type: Organisation.ERROR.type,
            payload: { loading: false, data: {} },
        });
    }
};
