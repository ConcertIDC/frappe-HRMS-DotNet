import { Company } from "../constants/company";
import { branchApi, companyApi, createCompanyApi, departmentApi, designationtApi, employmentTypeApi } from "../../interceptor/service/CompanyServices";

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

export const getBranchList = () => async (dispatch) => {
    dispatch({
        type: Company.LOADING.type,
        payload: { loading: true },
    });
    try {
        const { data } = await branchApi();
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

export const getDepartmentList = () => async (dispatch) => {
    dispatch({
        type: Company.LOADING.type,
        payload: { loading: true },
    });
    try {
        const { data } = await departmentApi();
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

export const getDesignationList = () => async (dispatch) => {
    dispatch({
        type: Company.LOADING.type,
        payload: { loading: true },
    });
    try {
        const { data } = await designationtApi();
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

export const getEmploymentTypeList = () => async (dispatch) => {
    dispatch({
        type: Company.LOADING.type,
        payload: { loading: true },
    });
    try {
        const { data } = await employmentTypeApi();
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

export const createCompanyList = (payload) => async (dispatch) => {
    
    dispatch({
        type: Company.LOADING.type,
        payload: { loading: true },
    });
    try {
        const { data } = await createCompanyApi(payload);
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
