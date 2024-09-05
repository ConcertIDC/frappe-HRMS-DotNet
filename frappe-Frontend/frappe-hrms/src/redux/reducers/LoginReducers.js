import { Login } from "../constants/login";

const initialValue = {
    LoginModel: [],
    loading: false,
};

export const LoginReducer = (state = initialValue, action) => {
    switch (action?.type) {
        case Login.LOADING.type:
            return { ...state, loading: true };
        case Login.REQUEST.type:
            return { ...state, LoginModel: action?.payload };
        case Login.SUCCESS.type:
            return { ...state, LoginModel: action?.payload, loading: false };
        case Login.ERROR.type:
            return { ...state, LoginModel: action?.payload, loading: false };
        default:
            return state;
    }
};
