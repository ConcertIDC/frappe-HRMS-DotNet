import React from 'react';
import { Container, Row, Col } from 'react-bootstrap';
import Shortcut from '../components/shortcut/Shortcut';

const Dashboard = () => {
    return (
        <Container fluid className='border rounded p-4'>
            {/* Shortcuts Section */}
            <h5 className="fw-semibold mb-4">Your Shortcuts</h5>
            <Row className="mb-4">
                <Col md={3} className="mb-4">
                    <Shortcut name="Company" path="/company" />
                    <Shortcut name="Employee Lifecycle Dashboard" path="/employee-lifecycle-dashboard" />
                </Col>
                <Col md={3} className="mb-4">
                    <Shortcut name="Leave Application" path="/leave-application" />
                    <Shortcut name="Attendance Dashboard" path="/attendance-dashboard" />
                </Col>
                <Col md={3} className="mb-4">
                    <Shortcut name="HR Dashboard" path="/hr-dashboard" />
                    <Shortcut name="Expense Claims Dashboard" path="/expense-claims-dashboard" />
                </Col>
                <Col md={3} className="mb-4">
                    <Shortcut name="Recruitment Dashboard" path="/recruitment-dashboard" />
                </Col>
            </Row>

            {/* Reports & Masters Section */}
            <h5 className="fw-semibold mb-4">Reports & Masters</h5>
            <Row>
                <Col md={4} className="mb-4">
                    <h6 className="section-title text-dark mb-3">Setup</h6>
                    {['Company', 'Branch', 'Department', 'Designation'].map(item => (
                        <Shortcut key={item} name={item} path={`/${item.toLowerCase()}`} />
                    ))}
                </Col>
                <Col md={4} className="mb-4">
                    <h6 className="section-title text-dark mb-3">Employee</h6>
                    {['Employee', 'Employee Group', 'Employee Grade'].map(item => (
                        <Shortcut key={item} name={item} path={`/${item.toLowerCase().replace(' ', '-')}`} />
                    ))}
                </Col>
                <Col md={4} className="mb-4">
                    <h6 className="section-title text-dark mb-3">Leaves</h6>
                    {['Leave Application', 'Compensatory Leave Request'].map(item => (
                        <Shortcut key={item} name={item} path={`/${item.toLowerCase().replace(' ', '-')}`} />
                    ))}
                </Col>
            </Row>

            {/* Additional Sections */}
            <Row>
                <Col md={4} className="mb-4">
                    <h6 className="section-title text-dark mb-3">Settings</h6>
                    {['HR Settings', 'Daily Work Summary Group', 'Team Updates'].map(item => (
                        <Shortcut key={item} name={item} path={`/${item.toLowerCase().replace(' ', '-')}`} />
                    ))}
                </Col>
                <Col md={4} className="mb-4">
                    <h6 className="section-title text-dark mb-3">Attendance</h6>
                    {['Attendance', 'Attendance Request', 'Employee Checkin'].map(item => (
                        <Shortcut key={item} name={item} path={`/${item.toLowerCase().replace(' ', '-')}`} />
                    ))}
                </Col>
                <Col md={4} className="mb-4">
                    <h6 className="section-title text-dark mb-3">Expense Claim</h6>
                    {['Expense Claim', 'Employee Advance', 'Travel Request'].map(item => (
                        <Shortcut key={item} name={item} path={`/${item.toLowerCase().replace(' ', '-')}`} />
                    ))}
                </Col>
            </Row>
        </Container>
    );
};

export default Dashboard;
