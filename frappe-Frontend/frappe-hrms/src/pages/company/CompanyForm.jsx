import React from "react";
import { Container, Row, Col, Form, Button, Nav, Tab, Tabs } from "react-bootstrap";
import CustomInput from "../../components/input/CustomInput";

const CompanyForm = () => {
  return (
    <Container fluid className="p-4">
      {/* Header */}
      <Row className="mb-3">
        <Col>
          <h4 className="fw-bold">
            New Company 
          </h4>
        </Col>
        <Col className="text-end">
          <Button variant="dark">Save</Button>
        </Col>
      </Row>

      {/* Tabs */}
      <div className="border rounded ">
      <Tabs defaultActiveKey="details" className="mb-3 px-2 border-bottom">
        <Tab eventKey="details" title="Details">
          <Form className="p-4">
            <Row className="mb-3">
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Company <span className="text-danger">*</span></Form.Label>
                  <Form.Control type="text" className="bg-light"/>
                </Form.Group>
              </Col>
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Default Letter Head</Form.Label>
                  <Form.Control type="text" className="bg-light"/>
                </Form.Group>
              </Col>
            </Row>

            <Row className="mb-3">
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Abbr <span className="text-danger">*</span></Form.Label>
                  <Form.Control type="text" required className="bg-light"/>
                </Form.Group>
              </Col>
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Tax ID</Form.Label>
                  <Form.Control type="text" className="bg-light"/>
                </Form.Group>
              </Col>
            </Row>

            <Row className="mb-3">
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Default Currency <span className="text-danger">*</span></Form.Label>
                  <Form.Control type="text" required className="bg-light"/>
                </Form.Group>
              </Col>
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Domain</Form.Label>
                  <Form.Control type="text" className="bg-light"/>
                </Form.Group>
              </Col>
            </Row>

            <Row className="mb-3">
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Country <span className="text-danger">*</span></Form.Label>
                  <Form.Control type="text" value="India" className="bg-light" />
                </Form.Group>
              </Col>
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Date of Establishment</Form.Label>
                  <Form.Control type="date" className="bg-light"/>
                </Form.Group>
              </Col>
            </Row>

            <Row className="mb-3">
              <Col md={6}>
                <Form.Group className="d-flex align-items-center">
                  <Form.Check type="checkbox" label="Is Group" />
                </Form.Group>
              </Col>
            </Row>

            <Row className="mb-3">
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Default Holiday List</Form.Label>
                  <Form.Control type="text" className="bg-light"/>
                </Form.Group>
              </Col>
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Parent Company</Form.Label>
                  <Form.Control type="text" className="bg-light"/>
                </Form.Group>
              </Col>
            </Row>
          </Form>
        </Tab>

        {/* <Tab eventKey="accounts" title="Accounts">
          <p>Accounts section content...</p>
        </Tab> */}

        <Tab eventKey="buying" title="Buying and Selling">
        <h5 className="fw-bold px-4 mb-3">Buying & Selling Settings</h5>
          <Form className="px-4">
            <Row>
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Default Buying Terms</Form.Label>
                  <Form.Control type="text"  className="bg-light" />
                </Form.Group>
              </Col>
              <Col md={6} className="mb-3">
                <Form.Group>
                  <Form.Label>Default Selling Terms</Form.Label>
                  <Form.Control type="text"  className="bg-light" />
                </Form.Group>
              </Col>
            </Row>
            
            <Row className="mb-3">
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Monthly Sales Target</Form.Label>
                  <Form.Control type="text"  className="bg-light" />
                </Form.Group>
              </Col>
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Default Warehouse for Sales Return</Form.Label>
                  <Form.Control type="text" disabled className="bg-light" />
                </Form.Group>
              </Col>
            </Row>
          </Form>
        </Tab>

        <Tab eventKey="hr" title="HR & Payroll">
        <h5 className="fw-bold px-4 mb-3">HR & Payroll Settings</h5>
          <Form >
            <Row className="mb-3 px-4">
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Default Employee Advance Account</Form.Label>
                  <Form.Control type="text" className="bg-light" />
                </Form.Group>
              </Col>
            </Row>
            <hr/>
            <h5 className="fw-bold px-4 mb-3">HRA Settings</h5>
            <Row className="mb-3 px-4">
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Basic Component</Form.Label>
                  <Form.Control type="text" className="bg-light" />
                </Form.Group>
              </Col>
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Arrear Component</Form.Label>
                  <Form.Control type="text" className="bg-light" />
                </Form.Group>
              </Col>
            </Row>
            <Row className="mb-3 px-4">
              <Col md={6}>
                <Form.Group>
                  <Form.Label>HRA Component</Form.Label>
                  <Form.Control type="text" className="bg-light"/>
                </Form.Group>
              </Col>
            </Row>

          </Form>
        </Tab>

        <Tab eventKey="stock" title="Stock and Manufacturing">
        <h5 className="fw-bold px-4 mb-3">Manufacturing</h5>
            <Row className="mb-3 px-4">
              <Col md={6}>
                <Form.Group>
                  <Form.Label>Default Operating Cost Account</Form.Label>
                  <Form.Control type="text" className="bg-light" />
                </Form.Group>
              </Col>
            </Row>
        </Tab>
      </Tabs>
      </div>
    </Container>
  );
};

export default CompanyForm;
