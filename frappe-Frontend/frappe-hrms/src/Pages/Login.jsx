import React, { useState, useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { Card, Col, Form, Row } from 'react-bootstrap';
import Button from '../Components/Button/Button';
import CustomInput from '../Components/Input/CustomInput';
import frappelogo from '../Assets/Images/frappe-hr2.png';
import { LoginAction } from '../redux/actions/LoginActions';
import { useNavigate } from 'react-router-dom';

const LoginComponent = () => {
    const [formData, setFormData] = useState({
        email: '',
        password: ''
    });
    const [validated, setValidated] = useState(false);
    const dispatch = useDispatch();
    const navigate = useNavigate();
    useEffect(() => {
        localStorage.removeItem("Token");
    }, []);
 

    const { loading, error, data } = useSelector(state => state.auth);
    const handleInputChange = (e) => {
        const { name, value } = e.target;
        setFormData(prevState => ({
            ...prevState,
            [name]: value
        }));
    };

    const handleSubmit = (event) => {
        event.preventDefault();
        const form = event.currentTarget;
        if (form.checkValidity() === false) {
            event.stopPropagation();
        } else {
            console.log(formData);
            dispatch(LoginAction(formData));
        }
        setValidated(true);
    };

    return (
        <div className='vh-100 d-flex align-items-center signup-body justify-content-center'>
            <Form noValidate validated={validated} onSubmit={handleSubmit}>
                <Card className='p-4 ms-5 bg-white me-5 shadow rounded'>
                    <Row>
                        <Col xl={12}>
                            <div className='d-flex justify-content-center'>
                                <img src={frappelogo} alt="logo" />
                            </div>

                            <CustomInput
                                className='fw-bold login-input'
                                label="Email address"
                                type="email"
                                name="email"
                                value={formData.email}
                                onChange={handleInputChange}
                                required
                            />

                            <CustomInput
                                className='fw-bold login-input'
                                label="Password"
                                type="password"
                                name="password"
                                value={formData.password}
                                onChange={handleInputChange}
                                required
                            />

                            <Button
                                type="submit"
                                className='btn btn-success mt-2 login-input'
                                label="Login"
                                disabled={loading}
                            />

                            {error && (
                                <div className="text-danger text-center mt-3">
                                    Login failed. Please try again.
                                </div>
                            )}

                            <h6 className='text-center mt-3'>
                                Don't have an account? <a href='/signup'>Sign Up</a>
                            </h6>
                        </Col>
                    </Row>
                </Card>
            </Form>
        </div>
    );
};

export default LoginComponent;
