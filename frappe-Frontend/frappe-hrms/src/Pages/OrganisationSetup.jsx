import React, { useState } from 'react';
import CustomInput from '../Components/Input/CustomInput';
import { Container, Col, Row, Form } from 'react-bootstrap';
import '../Assets/Css/Style.css';
import frappelogo from '../Assets/Images/frappehr.png';
import 'bootstrap/dist/css/bootstrap.css';
import Button from '../Components/Button/Button';
import CustomDropdown from '../Components/Dropdown/CustomDropdown';
import { employeeOptions, INDUSTRY, inputs } from '../Constant/ConstatntData';
import Checkbox from '../Components/checkbox/CheckBox';

const Organisation = () => {
    const [isChecked, setIsChecked] = useState(false);
    const handleCheckboxChange = (e) => {
        setIsChecked(e.target.checked);
      };
    const dropdownConfigs = [
        {
            label: "Number of employees",
            options: employeeOptions,
            className: "",
        },

        {
            label: "Industry",
            options: INDUSTRY,
            className: "mt-3",
        },
    ];

    return (
        <div className='signup-body '>
            <div className='d-flex justify-content-center'>
                <img src={frappelogo} className="mb-4 frappr-logo mt-4" alt="Frappe Logo" />
            </div>
            <Form>
                <div className='d-flex justify-content-center signup-body '>
                    <Container>
                        <Row className="justify-content-center">
                            <Col className='card' xs={12} sm={10} md={8} lg={6} xl={6}>
                                <div className='card-body'>
                                    <Row>

                                        <Col xs={12} className="">
                                            <Row>
                                                <Col xs={6}>
                                                    <CustomInput label="Company Abbreviation" type="text" required />
                                                </Col>
                                                <Col xs={6}>
                                                    <CustomInput label="Company Name" type="text" required />
                                                </Col>
                                            </Row>
                                        </Col>
                                        {inputs.map((input, index) => (
                                            <Col xs={12} key={index} className={index !== 0 ? 'mb-3' : ''}>
                                                <CustomInput label={input.label} type={input.type} required />
                                            </Col>
                                        ))}
                                        <Col xs={12} className=''>
                                            {dropdownConfigs.map((item, index) => (
                                                <CustomDropdown key={index} label={item.label} options={item.options} className={item.className} />
                                            ))}
                                        </Col>
                                        <Checkbox 
                                            label=" Generate Demo Data For Explaination"
                                            checked={isChecked}
                                            onChange={handleCheckboxChange}
                                            id="termsCheckbox"
                                            className="mb-2 "
                                        />
                                    
                                    </Row>
                                    <Button type='button' className='btn btn-dark mt-4 w-100' label="Create Account" />
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
