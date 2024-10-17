import React, { useState , useEffect} from 'react';
import { Container, Row, Col, Form } from 'react-bootstrap';
import CustomInput from '../Components/Input/CustomInput';
import frappelogo from '../Assets/Images/frappe-hr2.png';
import Button from '../Components/Button/Button';
import { useNavigate } from 'react-router-dom';
import { useDispatch, useSelector } from 'react-redux';
import { SignupAction } from '../redux/actions/SignUpActions'; 
import { type } from '@testing-library/user-event/dist/type';

function Signup() {
    useEffect(() => {
        localStorage.removeItem("Token");
    }, []);
 
    const [formData, setFormData] = useState({});
    // const navigate = useNavigate();
    const dispatch = useDispatch();
    // const { loading } = useSelector((state) => state.signup);

    const handleChange = (e) => {
        setFormData({ ...formData, [e.target.name]: e.target.value });
    };
    console.log(formData);
    

    const handleClick = () => {
        dispatch(SignupAction(formData));
    };

    const inputs = [
        { label: "Sitename", name: "sitename", type : 'text' },
        { label: "First Name", name: "firstname" , type : 'text' },
        { label: "Last Name", name: "lastname", type : 'text'  },
        { label: "Email", name: "email", type: 'email' },
        { label: "Password", name: "password" , type : 'password'},
    ];

    return (
        <div className='signup-body'>
            <div className='d-flex justify-content-center'>
                <img src={frappelogo} className="mb-4 frappr-logo mt-4" alt="Frappe HR Logo" />
            </div>
            <Form>
                <div className='d-flex justify-content-center signup-body vh-100'>
                    <Container>
                        <Row className="justify-content-center">
                            <Col className='card' xs={12} sm={10} md={8} lg={6} xl={6}>
                                <div className='card-body'>
                                    <Row>
                                        {inputs.map((item) => (
                                            <CustomInput
                                                key={item.name}
                                                label={item.label}
                                                name={item.name}
                                                value={formData[item.name] || ''}
                                                type={item.type}
                                                onChange={handleChange}
                                            />
                                        ))}
                                    </Row>
                                    <Button
                                        type='button'
                                        onClick={handleClick}
                                        className='btn btn-dark mt-2 w-100'
                                        label= "Create Account"
                                    />
                                </div>
                            </Col>
                        </Row>
                    </Container>
                </div>
            </Form>
        </div>
    );
}

export default Signup;
