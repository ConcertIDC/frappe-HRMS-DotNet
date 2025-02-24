import { Company } from "../constants/company";
import { branchApi, companyApi, createCompanyApi, deleteCompanyApi, departmentApi, designationtApi, employmentTypeApi, getCompanyApi, updateCompanyApi } from "../../interceptor/service/CompanyServices";

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

export const createCompany = (payload) => async (dispatch) => {
    
    dispatch({
        type: Company.LOADING.type,
        payload: { loading: true },
    });
    try {
        await createCompanyApi(payload);
    } catch (err) {
        await dispatch({
            type: Company.ERROR.type,
            payload: { loading: false },
        });
    }
};

export const getCompany = (id) => async (dispatch) => {
    dispatch({
        type: Company.LOADING.type,
        payload: { loading: true },
    });

    try {
        const { data } = await getCompanyApi(id);
        await dispatch({
            type: Company.DETAIL.type,
            payload: { loading: false, data },
        });
    } catch (err) {
        console.error("Error fetching company:", err);
        
        await dispatch({
            type: Company.ERROR.type,
            payload: { loading: false, data: {} },
        });
    }
};

export const updateCompany = (payload) => async (dispatch) => {
    dispatch({
        type: Company.LOADING.type,
        payload: { loading: true },
    });
    try {
        await updateCompanyApi(payload);
    } catch (err) {
        await dispatch({
            type: Company.ERROR.type,
            payload: { loading: false },
        });
    }
};

export const deleteCompany = (companyId) => async (dispatch) => {
    dispatch({
        type: Company.LOADING.type,
        payload: { loading: true },
    });
    try {
        await deleteCompanyApi(companyId);
        dispatch(getCompanyList());
    } catch (err) {
        console.log(err);
        await dispatch({
            type: Company.ERROR.type,
            payload: { loading: false },
        });
    }
};
