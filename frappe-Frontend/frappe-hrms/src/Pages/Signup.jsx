import React, { useState } from 'react';
import { Container, Row, Col, Form } from 'react-bootstrap';
import CustomInput from '../Components/Input/CustomInput';
import frappelogo from '../Assets/Images/frappe-hr2.png';
import Button from '../Components/Button/Button';
import { useNavigate } from 'react-router-dom';

const Signup = () => {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    const handleClick = () => {
        navigate('/organisation')
    }
    const inputs = [
        {label : "Sitename"},
        { label: "Firstname" },
        { label: "Lastname" },
        { label: "Email" },
        { label: "Password" },
    ]
    return (
        <div className='signup-body '>
            <div className='d-flex justify-content-center'>
                <img src={frappelogo} className="mb-4 frappr-logo mt-4" />
            </div>
            <Form >
                <div className='d-flex justify-content-center signup-body vh-100'>
                    <Container >
                        <Row className="justify-content-center">

                            <Col className='card' xs={12} sm={10} md={8} lg={6} xl={6}>
                                <div className='card-body '>
                                    <Row>
                                        {inputs.map(item => (
                                            <CustomInput key={item.label} label={item.label} />
                                        ))}
                                    </Row>
                                    <Button type='button' onClick={handleClick} className='btn btn-dark mt-2 w-100' label="Create Account" />

                                </div>
                            </Col>
                        </Row>
                    </Container>
                </div>
            </Form>
        </div>
    )
}

export default Signup;


