import { Employee } from "../constants/employee";

const initialEmployeeState = {
    employeeModel: [],
    employeeGrade: [],
    loading: false,
};

export const EmployeeReducer = (state = initialEmployeeState, action) => {
    switch (action?.type) {
        case Employee.LOADING.type:
            return { ...state, loading: true };
        case Employee.REQUEST.type:
            return { ...state, employeeModel: action?.payload };
        case Employee.SUCCESS.type:
            return { ...state, employeeModel: action?.payload.data, loading: false };
        case Employee.EMPLOYEE_GRADE.type:
            return { ...state, employeeGrade: action?.payload.data, loading: false };
        case Employee.ERROR.type:
            return { ...state, employeeModel: action?.payload, loading: false };
        default:
            return state;
    }
};
