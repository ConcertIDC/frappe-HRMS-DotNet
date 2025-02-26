import React, { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { Container, Row, Col, Form, Button, Tab, Tabs } from "react-bootstrap";
import { Formik, Field, ErrorMessage, Form as FormikForm } from "formik";
import * as Yup from "yup";
import { createCompany, getCompany, updateCompany } from "../../redux/actions/CompanyAction";
import { useNavigate, useParams } from "react-router-dom";
import { countryOptions, currencyOptions } from "../../constant/ConstatntData";

const validationSchema = Yup.object().shape({
  companyName: Yup.string().required("Company name is required"),
  companyAbbrevation: Yup.string().required("Abbr is required"),
  currency: Yup.string().required("Default Currency is required"),
  country: Yup.string().required("Country is required"),
});

const initialValues = {
  companyName: "",
  defaultLetterHead: "",
  companyAbbrevation: "",
  taxID: "",
  currency: "",
  domain: "",
  country: "India",
  dateofEstablishment: "",
  isGroup: false,
  defaultHolidayList: "",
  parentCompany: "",
  defaultBuyingTerms: "",
  defaultSellingTerms: "",
  monthlySalesTarget: "",
  defaultWarehouseForSalesReturn: "",
  defaultEmployeeAdvanceAccount: "",
  basicComponent: "",
  arrearComponent: "",
  hraComponent: "",
  defaultOperatingCostAccount: "",
};

const CompanyForm = () => {
  const dispatch = useDispatch();
  const params = useParams();
  const company = useSelector((state) => state.Company.companyDetails.data);
  const navigate = useNavigate();

  useEffect(() => {
    if (params.id)
      dispatch(getCompany(params.id));
  }, []);
  console.log(params.id ? company : initialValues);

  return (
    <Container fluid className="p-4">
      <Row className="mb-3">
        <Col>
          <h4 className="fw-bold">{params.id ? 'Edit' : 'New'} Company</h4>
        </Col>
        <Col className="text-end">
          <Button variant="dark" type="submit" form="company-form" >
            {params.id ? 'Update' : "Save"}
          </Button>
        </Col>
      </Row>

      <Formik
        initialValues={params.id ? company : initialValues}
        validationSchema={validationSchema}
        enableReinitialize
        onSubmit={(values) => {
          if (params.id) {
            dispatch(updateCompany(values))
              .then(() => {
                navigate("/company");
              })
          }
          else {
            dispatch(createCompany(values))
              .then(() => {
                navigate("/company");
              })
          }
        }}

      >
        {({ errors, touched, values, handleChange }) => (
          <FormikForm id="company-form" className="rounded border">
            <Tabs defaultActiveKey="details" className="mb-3 px-2">
              <Tab eventKey="details" title="Details">
                <div className="p-4">
                  <Row className="mb-3">
                    <Col md={6}>
                      <Form.Group>
                        <Form.Label>Company <span className="text-danger">*</span></Form.Label>
                        <Field name="companyName" type="text" className={`form-control bg-light ${errors.companyName && touched.companyName ? "is-invalid" : ""}`} />
                        <ErrorMessage name="companyName" component="div" className="text-danger" />
                      </Form.Group>
                    </Col>
                    <Col md={6}>
                      <Form.Group>
                        <Form.Label>Default Letter Head</Form.Label>
                        <Field name="defaultLetterHead" type="text" className="form-control bg-light" />
                      </Form.Group>
                    </Col>
                  </Row>

                  <Row className="mb-3">
                    <Col md={6}>
                      <Form.Group>
                        <Form.Label>
                          Abbr <span className="text-danger">*</span>
                        </Form.Label>
                        <Field
                          name="companyAbbrevation"
                          type="text"
                          className={`form-control bg-light ${errors.companyAbbrevation && touched.companyAbbrevation ? "is-invalid border-danger" : ""
                            }`}
                        />
                        <ErrorMessage name="companyAbbrevation" component="div" className="text-danger" />
                      </Form.Group>
                    </Col>
                    <Col md={6}>
                      <Form.Group>
                        <Form.Label>Tax ID</Form.Label>
                        <Field name="taxID" type="text" className="form-control bg-light" />
                      </Form.Group>
                    </Col>
                  </Row>

                  <Row className="mb-3">
                    <Col md={6}>
                      <Form.Group>
                        <Form.Label>
                          Default Currency <span className="text-danger">*</span>
                        </Form.Label>
                        <Field
                          name="currency"
                          as="select"
                          
                          className={`form-control bg-light ${errors.currency && touched.currency ? "is-invalid border-danger" : ""
                            }`}
                        >
                          <option hidden></option>
                          {currencyOptions.map((currency) => <option value={currency.value}>{currency.label}</option>)}
                        </Field>
                        <ErrorMessage name="currency" component="div" className="text-danger" />
                      </Form.Group>
                    </Col>
                    <Col md={6}>
                      <Form.Group>
                        <Form.Label>Domain</Form.Label>
                        <Field name="domain" type="text" className="form-control bg-light" />
                      </Form.Group>
                    </Col>
                  </Row>

                  <Row className="mb-3">
                    <Col md={6}>
                      <Form.Group>
                        <Form.Label>
                          Country <span className="text-danger">*</span>
                        </Form.Label>
                        <Field as="select" name="country" className={`form-control bg-light ${errors.country && touched.country ? "is-invalid border-danger" : ""
                          }`}>
                          {countryOptions.map((country) => <option value={country.value}>{country.label}</option>)}
                        </Field>
                        <ErrorMessage name="country" component="div" className="text-danger" />
                      </Form.Group>
                    </Col>
                    <Col md={6}>
                      <Form.Group>
                        <Form.Label>Date of Establishment</Form.Label>
                        <Field name="dateofEstablishment" type="date" className="form-control bg-light" />
                      </Form.Group>
                    </Col>
                  </Row>
                  <Row className="mb-3">
                    <Col md={6}>
                      <Form.Group className="d-flex align-items-center">
                        <Form.Check type="checkbox" checked={values?.isGroup} onChange={handleChange} name="isGroup" label="Is Group" />
                      </Form.Group>
                    </Col>
                  </Row>

                  <Row className="mb-3">
                    <Col md={6}>
                      <Form.Group>
                        <Form.Label>Default Holiday List</Form.Label>
                        <Field type="text" name className="form-control bg-light" />
                      </Form.Group>
                    </Col>
                    <Col md={6}>
                      <Form.Group>
                        <Form.Label>Parent Company</Form.Label>
                        <Field type="text" name="parentCompany" className="form-control bg-light" />
                      </Form.Group>
                    </Col>
                  </Row>
                </div>
              </Tab>


              {/* Buying & Selling Tab */}
              <Tab eventKey="buying" title="Buying & Selling">
                <h5 className="fw-bold px-4 mb-3">Buying & Selling Settings</h5>
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
                        <Field type="text" className="form-control bg-light" />
                      </Form.Group>
                    </Col>
                    <Col md={6}>
                      <Form.Group>
                        <Form.Label>Default Warehouse for Sales Return</Form.Label>
                        <Field type="text"  className="form-control bg-light" />
                      </Form.Group>
                    </Col>
                  </Row>

                </div>
              </Tab>

              {/* HR & Payroll Tab */}
              <Tab eventKey="hr" title="HR & Payroll">
                <h5 className="fw-bold px-4 mb-3">HR & Payroll Settings</h5>
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
                        <Field type="text" name="basicComponent" className="form-control bg-light" />
                      </Form.Group>
                    </Col>
                    <Col md={6}>
                      <Form.Group>
                        <Form.Label>Arrear Component</Form.Label>
                        <Field type="text" name="arrearComponent" className="form-control bg-light" />
                      </Form.Group>
                    </Col>
                  </Row>
                  <Row className="mb-3 px-4">
                    <Col md={6}>
                      <Form.Group>
                        <Form.Label>HRA Component</Form.Label>
                        <Field type="text" name="hraComponent" className="form-control bg-light" />
                      </Form.Group>
                    </Col>
                  </Row>
                </div>
              </Tab>

              {/* Stock & Manufacturing Tab */}
              <Tab eventKey="stock" title="Stock & Manufacturing">
                <h5 className="fw-bold px-4 mb-3">Manufacturing</h5>
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
            </Tabs>


          </FormikForm>
        )}
      </Formik>
    </Container>

  );
};

export default CompanyForm;
