import { Employee } from "../constants/employee";

const initialEmployeeState = {
    EmployeeModel: [],
    loading: false,
};

export const EmployeeReducer = (state = initialEmployeeState, action) => {
    switch (action?.type) {
        case Employee.LOADING.type:
            return { ...state, loading: true };
        case Employee.REQUEST.type:
            return { ...state, EmployeeModel: action?.payload };
        case Employee.SUCCESS.type:            
            return { ...state, EmployeeModel: action?.payload.data, loading: false };
        case Employee.ERROR.type:
            return { ...state, EmployeeModel: action?.payload, loading: false };
        default:
            return state;
    }
};
