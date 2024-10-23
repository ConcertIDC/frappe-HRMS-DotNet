import React, { useState } from 'react';
import { Container, Row, Col } from 'react-bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';
import Navbar from '../Components/navbar/Navbar';
import Sidebar from '../Components/sidebar/Sidebar';
import '../Assets/Css/Style.css'

const Dashboard = () => {
    const [searchTerm, setSearchTerm] = useState('');

    const handleSearchChange = (e) => {
        setSearchTerm(e.target.value);
    };

    return (
        <Container fluid className="dashboard-container p-0">
            <Navbar />

            <Row className="min-vh-100">
                {/* Fixed Sidebar */}
                <Col xs={2} className="fixed-sidebar p-0">
                    <Sidebar />
                </Col>

                {/* Main Content */}
                <Col xs={10} className="offset-2 bg-light p-4 main-content">
                    <h5 className="text-dark mb-4">Your Shortcuts</h5>
                    <Row>
                        <Col md={4} className="mb-4">
                            <h6 className="section-title text-dark mb-3">Employee</h6>
                            {['0 Active', 'Employee', 'Employee Group', 'Employee Grade'].map(item => (
                                <a key={item} href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect">
                                    {item}
                                </a>
                            ))}
                        </Col>
                        <Col md={4} className="mb-4">
                            <h6 className="section-title text-dark mb-3">Leaves</h6>
                            {['Leave Application', 'Compensatory Leave Request'].map(item => (
                                <a key={item} href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect">
                                    {item}
                                </a>
                            ))}
                        </Col>
                        <Col md={4} className="mb-4">
                            <h6 className="section-title text-dark mb-3">HR Dashboards</h6>
                            {['HR Dashboard', 'Employee Lifecycle Dashboard', 'Attendance Dashboard', 'Expense Claims Dashboard', 'Recruitment Dashboard'].map(item => (
                                <a key={item} href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect">
                                    {item}
                                </a>
                            ))}
                        </Col>
                    </Row>
                    <Row>
                        <Col md={4} className="mb-4">
                            <h6 className="section-title text-dark mb-3">Reports & Masters</h6>
                            {['Employee Information', 'Employee Birthday', 'Employees Working on a Holiday', 'Daily Work Summary Replies'].map(item => (
                                <a key={item} href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect">
                                    {item}
                                </a>
                            ))}
                        </Col>
                        <Col md={4} className="mb-4">
                            <h6 className="section-title text-dark mb-3">Key Reports</h6>
                            {['Monthly Attendance Sheet', 'Recruitment Analytics', 'Employee Leave Balance', 'Employee Leave Balance Summary', 'Employee Advance Summary', 'Employee Exits'].map(item => (
                                <a key={item} href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect">
                                    {item}
                                </a>
                            ))}
                        </Col>
                        <Col md={4} className="mb-4">
                            <h6 className="section-title text-dark mb-3">Expense & Travel</h6>
                            {['Expense Claim', 'Employee Advance', 'Travel Request'].map(item => (
                                <a key={item} href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect">
                                    {item}
                                </a>
                            ))}
                        </Col>
                    </Row>
                </Col>
            </Row>
        </Container>
    );
};

export default Dashboard;
