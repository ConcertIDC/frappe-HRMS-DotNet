import { Company } from "../constants/company";

const initialCompanyState = {
    companyModel: [],
    companyDetails: {},
    designation: [],
    branch: [],
    department: [],
    employmentType: [],
    loading: false,
};

export const CompanyReducer = (state = initialCompanyState, action) => {
    switch (action?.type) {
        case Company.LOADING.type:
            return { ...state, loading: true };
        case Company.REQUEST.type:
            return { ...state, companyModel: action?.payload };
        case Company.SUCCESS.type:
            return { ...state, companyModel: action?.payload.data, loading: false };
        case Company.DESIGNATION.type:
            return { ...state, designation: action?.payload.data, loading: false };
        case Company.BRANCH.type:
            return { ...state, branch: action?.payload.data, loading: false };
        case Company.DEPARTMENT.type:
            return { ...state, department: action?.payload.data, loading: false };
        case Company.EMPLOYMENT_TYPE.type:
            return { ...state, employmentType: action?.payload.data, loading: false };
        case Company.ERROR.type:
            return { ...state, companyModel: action?.payload, loading: false };
        case Company.DETAIL.type:
            return { ...state, companyDetails: action?.payload, loading: false };
        default:
            return state;
    }
};
