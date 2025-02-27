import { Employee } from "../constants/employee";
import { employeeApi, employeeGradeApi, employeeGroupApi } from "../../interceptor/service/EmployeeService";

export const getEmployeeList = () => async (dispatch) => {
    dispatch({
        type: Employee.LOADING.type,
        payload: { loading: true },
    });
    try {
        const { data } = await employeeApi();
        await dispatch({
            type: Employee.SUCCESS.type,
            payload: { loading: false, data: data },
        });
    } catch (err) {
        await dispatch({
            type: Employee.ERROR.type,
            payload: { loading: false, data: {} },
        });
    }
};

export const getEmployeeGroupList = () => async (dispatch) => {
    dispatch({
        type: Employee.LOADING.type,
        payload: { loading: true },
    });
    try {
        const { data } = await employeeGroupApi();
        await dispatch({
            type: Employee.SUCCESS.type,
            payload: { loading: false, data: data },
        });
    } catch (err) {
        await dispatch({
            type: Employee.ERROR.type,
            payload: { loading: false, data: {} },
        });
    }
};

export const getEmployeeGradeList = () => async (dispatch) => {
    dispatch({
        type: Employee.LOADING.type,
        payload: { loading: true },
    });
    try {
        const { data } = await employeeGradeApi();
        await dispatch({
            type: Employee.EMPLOYEE_GRADE.type,
            payload: { loading: false, data: data },
        });
    } catch (err) {
        await dispatch({
            type: Employee.ERROR.type,
            payload: { loading: false, data: {} },
        });
    }
};

