import { Signup } from "../constants/signUp";

const initialSignupState = {
    SignupModel: [],
    loading: false,
};

export const SignupReducer = (state = initialSignupState, action) => {
    switch (action?.type) {
        case Signup.LOADING.type:
            return { ...state, loading: true };
        case Signup.REQUEST.type:
            return { ...state, SignupModel: action?.payload };
        case Signup.SUCCESS.type:
            return { ...state, SignupModel: action?.payload, loading: false };
        case Signup.ERROR.type:
            return { ...state, SignupModel: action?.payload, loading: false };
        default:
            return state;
    }
};
