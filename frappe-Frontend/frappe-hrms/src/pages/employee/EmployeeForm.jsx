import { Field, Formik } from "formik";
import React, { useEffect } from "react";
import { Container, Row, Col, Form, Button, Tab, Tabs } from "react-bootstrap";
import { addressTypeOptions, bloodGroupOptions, booleanOptions, currencyOptions, employeeStatusOptions, genderOptions, maritalStatusOptions, preferedContactOptions, salaryModeOptions, salutationOptions } from "../../constant/ConstatntData";
import { useDispatch, useSelector } from "react-redux";
import { getBranchList, getCompanyList, getDepartmentList, getDesignationList, getEmploymentTypeList } from "../../redux/actions/CompanyAction";
import { getEmployeeGradeList, getEmployeeGroupList } from "../../redux/actions/EmployeeAction";
import { getJobApplicantList } from "../../redux/actions/JobAction";
import { boolean } from "yup";

const EmployeeForm = () => {
    const dispatch = useDispatch();

    const employee = useSelector((state) => state);
    console.log("Employeee", employee)
    useEffect(() => {
        dispatch(getCompanyList());
        dispatch(getBranchList());
        dispatch(getDepartmentList());
        dispatch(getDesignationList());
        dispatch(getEmployeeGradeList());
        dispatch(getEmployeeGroupList());
        dispatch(getEmploymentTypeList());
        dispatch(getJobApplicantList());
    }, [dispatch]);
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
                            <div className="px-4">
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
                                                {genderOptions && genderOptions?.length > 0 && genderOptions.map((gender) => <option value={gender?.value || ""}>{gender?.label}</option>)}
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
                            <hr />
                            <div className="px-4">
                                <h5 className="fw-bold mb-3">Company Details</h5>
                                <Row>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Company</Form.Label>
                                            <Field as='select' name="company" type="text" className="form-control bg-light" >
                                                {employee.company.companyModel.map((company) => <option value={company.id}>{company.companyName}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Designation</Form.Label>
                                            <Field as='select' name="designation" type="text" className="form-control bg-light" >
                                                <option hidden></option>
                                                {employee.company.designation.map((designation) => <option value={designation.id}>{designation.designationName}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Branch</Form.Label>
                                            <Field as='select' name="branch" type="text" className="form-control bg-light" >
                                                <option hidden></option>
                                                {employee.company.branch.map((branch) => <option value={branch.id}>{branch.branchName}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                </Row>
                                <Row className="my-3">
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Department</Form.Label>
                                            <Field as='select' name="department" type="text" className="form-control bg-light" >
                                                <option hidden></option>
                                                {employee.company.department.map((department) => <option value={department.id}>{department.departmentName}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Reports to</Form.Label>
                                            <Field name="reportsto" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Grade</Form.Label>
                                            <Field as='select' name="grade" type="text" className="form-control bg-light" >
                                                <option hidden></option>
                                                {employee.employee.employeeGrade.map((grade) => <option value={grade?.id}>{grade.grade}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                </Row>
                                <Row className="mb-3">
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Employmnet Type</Form.Label>
                                            <Field as='select' name="employmentType" type="text" className="form-control bg-light" >
                                                <option hidden></option>
                                                {employee.company.employmentType.map((employmentType) => <option value={employmentType.id}>{employmentType.type}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                </Row>
                            </div>
                        </Tab>


                        <Tab eventKey="joining" title="Joining">
                            <div className="px-4 mb-3">
                                <Row>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Job Applicant</Form.Label>
                                            <Field as='select' name="jobApplicant" type="text" className="form-control bg-light" >
                                                <option hidden></option>
                                                {employee.job.jobModel.map((job) => <option value={job.id}>{job.applicantName}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Confirmation Date</Form.Label>
                                            <Field name="confirmationDate" type="date" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Notice (days)</Form.Label>
                                            <Field name="confirmationDate" type="int" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                </Row>
                                <Row className="my-3">
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Offer Date</Form.Label>
                                            <Field name="offerDate" type="date" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Contract End Date</Form.Label>
                                            <Field name="contractEndDate" type="date" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Date Of Retirement</Form.Label>
                                            <Field name="dateOfRetirement" type="date" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                </Row>

                            </div>
                        </Tab>

                        {/* HR & Payroll Tab */}
                        <Tab eventKey="address" title="Address & Contacts">
                            <div className=" mb-3">
                                <Row className="px-4">
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Mobile</Form.Label>
                                            <Field name="mobile" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Personal Email</Form.Label>
                                            <Field name="personalEMail" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Prefered Contact Email</Form.Label>
                                            <Field as='select' name="preferedContactEmail" type="text" className="form-control bg-light" >
                                                {preferedContactOptions.map((contact) => <option value={contact.value}>{contact.label}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                </Row>
                                <Row className="mt-3 px-4">
                                    <Col md={4}>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Company Email</Form.Label>
                                            <Field name="companyEMail" type="text" className="form-control bg-light" />
                                            <p>Provide Email Address registered in company</p>
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group className="d-flex align-items-center">
                                            <Form.Check type="checkbox" name="unsubscribed" label="Unsubscribed" />
                                        </Form.Group>
                                    </Col>
                                </Row>
                                <hr />
                                <h5 className="fw-bold px-4 mb-3">Address</h5>
                                <Row className="mb-3 px-4">
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Current Address</Form.Label>
                                            <Field as="textarea" name="currentAddress" className="form-control bg-light" rows={3} />
                                        </Form.Group>
                                    </Col>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Permanent Address</Form.Label>
                                            <Field as="textarea" name="permanentAddress" className="form-control bg-light" rows={3} />
                                        </Form.Group>
                                    </Col>
                                </Row>
                                <Row className="mb-3 px-4">
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Current Address Is</Form.Label>
                                            <Field as='select' name="currentAddressIs" className="bg-light form-control" >
                                                {addressTypeOptions.map((address) => <option value={address.value}>{address.label}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Permanent Address Is</Form.Label>
                                            <Field as='select' name="permanentAddressIs" className="bg-light form-control" >
                                                {addressTypeOptions.map((address) => <option value={address.value}>{address.label}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                </Row>
                                <hr />
                                <h5 className="fw-bold px-4 mb-3">Address</h5>
                                <Row className="mb-3 px-4">
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Emergency Contact Name</Form.Label>
                                            <Field name="emergencyContactName" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Emergency Phone</Form.Label>
                                            <Field name="emergencyPhone" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Relation</Form.Label>
                                            <Field name="relation" type="text" className="form-control bg-light" />
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
                                            <Form.Label>Attendance Device ID (Biometric/RF tag ID)</Form.Label>
                                            <Field name="attendanceDeviceID" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Holiday List</Form.Label>
                                            <Field name="holidayListId" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                </Row>
                                <Row>
                                    <Col md={6}></Col>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Default Shift</Form.Label>
                                            <Field name="shiftTypeId" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>

                                </Row>
                            </div>
                        </Tab>
                        <Tab eventKey="salary" title="Salary">
                            <div className="px-4 mb-3">
                                <Row>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Cost to Company (CTC)</Form.Label>
                                            <Field name="CTC" type="number" step="0.01" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Payroll Cost Center</Form.Label>
                                            <Field name="payrollCostCenterId" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                </Row>
                                <Row className="my-3">
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Salary Currency</Form.Label>
                                            <Field as='select' name="salaryCurrency" className="form-control bg-light" >
                                                {currencyOptions.map((currency) => <option value={currency.value}>{currency.label}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>PAN Number</Form.Label>
                                            <Field name="pANNumber" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                </Row>
                                <Row>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Salary Mode</Form.Label>
                                            <Field name="salaryMode" as='select' className="form-control bg-light" >
                                                {salaryModeOptions.map((mode) => <option value={mode.value}>{mode.label}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>ProvidentFundAccount</Form.Label>
                                            <Field name="providentFundAccount" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                </Row>
                            </div>
                        </Tab>
                        <Tab eventKey="personal" title="Personal">
                            <div className="px-4 mb-3">
                                <Row>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Marital Status</Form.Label>
                                            <Field name="maritalStatus" as='select' className="form-control bg-light" >
                                                {maritalStatusOptions.map((status) => <option value={status.value}>{status.label}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Blood Group</Form.Label>
                                            <Field name="bloodGroup" as='select' className="form-control bg-light" >
                                                {bloodGroupOptions.map((blood) => <option value={blood.value}>{blood.label}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                </Row>
                                <Row>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Family Background</Form.Label>
                                            <Field name="familyBackground" as="textarea" className="form-control bg-light" rows={5} />
                                            <p className="mt-3">Here you can maintain family details like name and occupation of parent, spouse and children</p>
                                        </Form.Group>
                                    </Col>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Health Details</Form.Label>
                                            <Field name="healthDetails" as="textarea" className="form-control bg-light" rows={5} />
                                            <p className="mt-3">Here you can maintain height, weight, allergies, medical concerns etc</p>
                                        </Form.Group>
                                    </Col>
                                </Row>
                            </div>
                            <hr />
                            <div className="px-4">
                                <h5 className="">Passport Details</h5>
                                <Row>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Passport Number</Form.Label>
                                            <Field name="passportNumber" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Date of Issue</Form.Label>
                                            <Field name="dateofIssue" type="date" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                </Row>
                                <Row className="my-3">
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Valid Upto</Form.Label>
                                            <Field name="validUpto" type="date" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Place of Issue</Form.Label>
                                            <Field name="placeofIssue" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                </Row>
                            </div>
                        </Tab>
                        <Tab eventKey="profile" title="Profile">
                            <div></div>
                        </Tab>
                        <Tab eventKey="exit" title="Exit">
                            <div className="px-4 mb-3">
                                <Row className="mb-3">
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Resignation Letter Date</Form.Label>
                                            <Field name="resignationLetterDate" type="date" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Exit Interview Held On</Form.Label>
                                            <Field name="exitInterviewHeldOn" type="date" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Leave Encashed?</Form.Label>
                                            <Field name="leaveEncashed" as='select' className="form-control bg-light" >
                                                {booleanOptions.map((bool) => <option value={bool.value}>{bool.label}</option>)}
                                            </Field>
                                        </Form.Group>
                                    </Col>
                                </Row>
                                <Row >
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>Relieving Date</Form.Label>
                                            <Field name="relievingDate" type="date" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                    <Col md={4}>
                                        <Form.Group>
                                            <Form.Label>New Workplace</Form.Label>
                                            <Field name="newWorkplace" type="text" className="form-control bg-light" />
                                        </Form.Group>
                                    </Col>
                                </Row>
                            </div>
                            <hr />
                            <div className="px-4 mb-3">
                                <h5>Feedback</h5>
                                <Row>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Reason for Leaving</Form.Label>
                                            <Field name="reasonforLeaving" as="textarea" className="form-control bg-light" rows={6} />
                                        </Form.Group>
                                    </Col>
                                    <Col md={6}>
                                        <Form.Group>
                                            <Form.Label>Feedback</Form.Label>
                                            <Field name="feedback" as="textarea" className="form-control bg-light" rows={6} />
                                        </Form.Group>
                                    </Col>
                                </Row>
                            </div>
                        </Tab>
                    </Tabs>
                </div>
            </Formik>



        </Container>

    );
};


export default EmployeeForm;
