import { Company } from "../constants/company";

const initialCompanyState = {
    CompanyModel: [],
    loading: false,
};

export const CompanyReducer = (state = initialCompanyState, action) => {
    switch (action?.type) {
        case Company.LOADING.type:
            return { ...state, loading: true };
        case Company.REQUEST.type:
            return { ...state, CompanyModel: action?.payload };
        case Company.SUCCESS.type:            
            return { ...state, CompanyModel: action?.payload.data, loading: false };
        case Company.ERROR.type:
            return { ...state, CompanyModel: action?.payload, loading: false };
        default:
            return state;
    }
};
