import { Employee } from "../constants/employee";
import { employeeApi } from "../../interceptor/service/EmployeeService";

export const getEmployeeList = () => async (dispatch) => {
    dispatch({
        type: Employee.LOADING.type,
        payload: { loading: true },
    });
    try {
        const { data } = await employeeApi();
        console.log("data", data);
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

