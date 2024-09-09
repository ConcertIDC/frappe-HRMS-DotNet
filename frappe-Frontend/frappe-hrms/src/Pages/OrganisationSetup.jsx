import React, { useState } from 'react';
import CustomInput from '../Components/Input/CustomInput';
import { Container, Col, Row, Form } from 'react-bootstrap';
import '../Assets/Css/Style.css';
import frappelogo from '../Assets/Images/frappehr.png';
import 'bootstrap/dist/css/bootstrap.css';
import Button from '../Components/Button/Button';
import CustomDropdown from '../Components/Dropdown/CustomDropdown';
import { countryOptions, currencyOptions, employeeOptions, INDUSTRY, inputs } from '../Constant/ConstatntData';
import Checkbox from '../Components/checkbox/CheckBox';
import { useDispatch } from 'react-redux';
import { OrganisationAction } from '../redux/actions/OrganisationAction'; 

const Organisation = () => {
    const [formData, setFormData] = useState({});
    const [isChecked, setIsChecked] = useState(false);
    console.log(formData);
    
    const dispatch = useDispatch();
    // const { loading } = useSelector((state) => state.organisation);

    const handleCheckboxChange = (e) => {
        setIsChecked(e.target.checked);
        setFormData({ ...formData, isDemo: e.target.checked });
    };

    const handleChange = (e) => {
        setFormData({ ...formData, [e.target.name]: e.target.value });
    };

    const handleClick = () => {
        dispatch(OrganisationAction(formData));
    };

    const dropdownConfigs = [
        { label: "Number of employees", options: employeeOptions, className: "", name : "numberOfEmployess",id:"numberOfEmployess"},
        { label: "Industry", options: INDUSTRY, className: "mt-3" , name : "industry",id:"industry"},
        { label: "Country", options : countryOptions, className: "", name:"country"},
        { label: "Currency", options : currencyOptions, className: "", name:"currency"}
    ];

    return (
        <div className='signup-body'>
            <div className='d-flex justify-content-center'>
                <img src={frappelogo} className="mb-4 frappr-logo mt-4" alt="Frappe Logo" />
            </div>
            <Form>
                <div className='d-flex justify-content-center signup-body'>
                    <Container>
                        <Row className="justify-content-center">
                            <Col className='card' xs={12} sm={10} md={8} lg={6} xl={6}>
                                <div className='card-body'>
                                    <Row>
                                        <Col xs={12}>
                                            <Row>
                                                
                                                <Col xs={6}>
                                                    <CustomInput
                                                        label="Company Name"
                                                        name="companyName"
                                                        type="text"
                                                        required
                                                        onChange={handleChange}
                                                    />
                                                </Col>
                                                <Col xs={6}>
                                                    <CustomInput
                                                        label="Company Abbreviation"
                                                        name="companyAbbrevation"
                                                        type="text"
                                                        required
                                                        onChange={handleChange}
                                                    />
                                                </Col>
                                            </Row>
                                        </Col>
                                        {inputs.map((input, index) => (
                                            <Col xs={12} key={index} className={index !== 0 ? 'mb-3' : ''}>
                                                <CustomInput
                                                    label={input.label}
                                                    name={input.name}
                                                    type={input.type}
                                                    required
                                                    onChange={handleChange}
                                                />
                                            </Col>
                                        ))}
                                        <Col xs={12}>
                                            {dropdownConfigs.map((item, index) => (
                                                <CustomDropdown
                                                    key={index}
                                                    label={item.label}
                                                    name={item.name}
                                                    id={item.id}
                                                    options={item.options}
                                                    className={item.className}
                                                    onChange={handleChange}
                                                />
                                            ))}
                                        </Col>
                                        <Checkbox 
                                            label="Generate Demo Data For Explanation"
                                            checked={isChecked}
                                            name="isDemo"
                                            onChange={handleCheckboxChange}
                                            id="isDemo"
                                            className="mb-2"
                                        />
                                    </Row>
                                    <Button
                                        type='button'
                                        onClick={handleClick}
                                        className='btn btn-dark mt-4 w-100'
                                        label="Create Account"
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

export default Organisation;
