// import axios from "axios";
import { Company } from "../constants/company";
// import { BASEURL } from "../../Constant/ConstatntData";
import { companyApi } from "../../interceptor/service/companyService";

export const getCompanyList = () => async (dispatch) => {
    dispatch({
        type: Company.LOADING.type,
        payload: { loading: true },
    });
    try {
        const { data } = await companyApi();
        console.log("data", data);
        await dispatch({
            type: Company.SUCCESS.type,
            payload: { loading: false, data: data },
        });
    } catch (err) {
        await dispatch({
            type: Company.ERROR.type,
            payload: { loading: false, data: {} },
        });
    }
};

