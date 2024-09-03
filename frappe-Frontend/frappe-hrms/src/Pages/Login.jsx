import React, { useState } from 'react';
import { Card, Col, Form, Row } from 'react-bootstrap';
import Button from '../Components/Button/Button';
import CustomInput from '../Components/Input/CustomInput';
import frappelogo from '../Assets/Images/frappe-hr2.png';
import { Link, useNavigate } from 'react-router-dom';
import { useDispatch } from 'react-redux';
import { LoginAction } from '../redux/actions/LoginActions';


const Login = () => {
    const[validated,setValidated]=useState(false);
    const navigate = useNavigate();

    const handleClick = () => {
        navigate('/dashboard');
    };

    const inputs = [
        { label: "Email address" },
        { label: "Password" }
    ];

    return (
        <div className='vh-100 d-flex align-items-center signup-body  justify-content-center'>
            <Form  validated={validated}>
                <Card className='p-4 ms-5 bg-white me-5 shadow rounded'  >

                    <Row>
                        <Col xl={12}>
                            <div className='d-flex justify-content-center'>
                                <img src={frappelogo} alt="logo" />
                            </div>

                            {inputs.map(item => (
                                <CustomInput className='fw-bold login-input' key={item.label} label={item.label} required />
                            ))}
                            <Button onClick={handleClick} className='btn btn-success  mt-2 login-input' label="Login" />

                            <h6 className='text-center mt-3'>Don't have an account? <Link to='/'>Sign Up</Link> </h6>
                        </Col>
                    </Row>
                </Card>
            </Form>
        </div>
    );
};

export default Login;
