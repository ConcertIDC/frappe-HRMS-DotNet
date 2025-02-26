import { Field, Formik } from "formik";
import React from "react";
import { Container, Row, Col, Form, Button, Tab, Tabs } from "react-bootstrap";
import { employeeStatusOptions, genderOptions, salutationOptions } from "../../constant/ConstatntData";

const EmployeeForm = () => {

    return (

        <Container fluid className="p-4">
            <Row className="mb-3">
                <Col>
                    <h4 className="fw-bold">New Employee</h4>
                </Col>
                <Col className="text-end">
                    <Button variant="dark" type="submit" form="employee-form" >
                        Save
                    </Button>
                </Col>
            </Row>
            <Formik className='border rounded'>
                <div className='border rounded'>
                    <Tabs defaultActiveKey="overview" className="mb-3 px-2">
                        <Tab eventKey="overview" title="Overview">
                            <div className="p-4">
                                <Row>
                                    <Col md={4}>
                                        <Form.Group className="mb-3">
                                            <Form.Label>Series <span className="text-danger">*</span></Form.Label>
                                            <Field name="series" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                        <Form.Group>
                                            <Form.Label>First Name <span className="text-danger">*</span></Form.Label>
                                            <Field name="series" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                        <Form.Group className="my-3">
                                            <Form.Label>Middle Name </Form.Label>
                                            <Field name="series" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                        <Form.Group>
                                            <Form.Label>Last Name </Form.Label>
                                            <Field name="series" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Gender <span className="text-danger">*</span></Form.Label>
                                            <Field as='select' name="gender" type="text" className="form-control bg-light" >
                                                <option hidden></option>
                                                {genderOptions.map((gender) => <option value={gender.value}>{gender.label}</option>)}
                                            </Field>
                                        </Form.Group>
                                        <Form.Group className="my-3">
                                            <Form.Label>Date Of Birth <span className="text-danger">*</span></Form.Label>
                                            <Field name="dataofbirth" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                        <Form.Group>
                                            <Form.Label>Salutation</Form.Label>
                                            <Field as='select' name="salutation" type="text" className="form-control bg-light" >
                                            <option hidden></option>
                                            {salutationOptions.map((salutation) => <option value={salutation.value}>{salutation.label}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group className="mb-3">
                                            <Form.Label>Date of Joining <span className="text-danger">*</span></Form.Label>
                                            <Field name="dateofjoining" type="date" className="form-control bg-light" />
                                        </Form.Group>
                                        <Form.Group>
                                            <Form.Label>Status <span className="text-danger">*</span></Form.Label>
                                            <Field as='select' name="status" type="text" className="form-control bg-light" >
                                            {employeeStatusOptions.map((status) => <option value={status.value}>{status.label}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                </Row>

                            </div>
                        </Tab>


                        <Tab eventKey="joining" title="Joining">
                            <div className="px-4 mb-3">
                                <Row>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Default Buying Terms</Form.Label>
                                            <Field name="defaultBuyingTerms" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Default Selling Terms</Form.Label>
                                            <Field name="defaultSellingTerms" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                </Row>
                                <Row className="my-3">
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Monthly Sales Target</Form.Label>
                                            <Form.Control type="text" className="bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Default Warehouse for Sales Return</Form.Label>
                                            <Form.Control type="text" disabled className="bg-light" />
                                        </Form.Group>
                                    </Col>
                                </Row>

                            </div>
                        </Tab>

                        {/* HR & Payroll Tab */}
                        <Tab eventKey="address" title="Address & Contacts">
                            <div className=" mb-3">
                                <Row className="px-4">
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Default Employee Advance Account</Form.Label>
                                            <Field name="defaultEmployeeAdvanceAccount" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                </Row>
                                <hr />
                                <h5 className="fw-bold px-4 mb-3">HRA Settings</h5>
                                <Row className="mb-3 px-4">
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Basic Component</Form.Label>
                                            <Form.Control type="text" name="basicComponent" className="bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Arrear Component</Form.Label>
                                            <Form.Control type="text" name="arrearComponent" className="bg-light" />
                                        </Form.Group>
                                    </Col>
                                </Row>
                                <Row className="mb-3 px-4">
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>HRA Component</Form.Label>
                                            <Form.Control type="text" name="hraComponent" className="bg-light" />
                                        </Form.Group>
                                    </Col>
                                </Row>
                            </div>
                        </Tab>

                        {/* Stock & Manufacturing Tab */}
                        <Tab eventKey="attendance" title="Attendance & Leaves">
                            <div className="px-4 mb-3">
                                <Row>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Default Operating Cost Account</Form.Label>
                                            <Field name="defaultOperatingCostAccount" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                </Row>
                            </div>
                        </Tab>
                        <Tab eventKey="salary" title="Salary">
                            <div></div>
                        </Tab>
                        <Tab eventKey="personal" title="Personal">
                            <div></div>
                        </Tab>
                        <Tab eventKey="profile" title="Profile">
                            <div></div>
                        </Tab>
                        <Tab eventKey="exit" title="Exit">
                            <div></div>
                        </Tab>
                    </Tabs>
                </div>
            </Formik>



        </Container>

    );
};


export default EmployeeForm;
