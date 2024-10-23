import React, { useState } from 'react';
import { Container, Row, Col } from 'react-bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';
import Navbar from '../Components/navbar/Navbar';
import Sidebar from '../Components/sidebar/Sidebar';
import '../Assets/Css/Style.css'
import { useNavigate } from 'react-router-dom';

const Dashboard = () => {
    const [searchTerm, setSearchTerm] = useState('');
    const navigate= useNavigate();
    const handleSearchChange = (e) => {
        setSearchTerm(e.target.value);
    };
    const handleNavigate =()=>{
        navigate("/employee-list");
    }

    return (
        <Container fluid className="dashboard-container p-0">
            {/* Shortcuts Section */}
            <h5 className="text-dark mb-4">Your Shortcuts</h5>
            <Row className="mb-4">
                <Col md={3} className="mb-4">
                    <a href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect"onClick={handleNavigate}>
                        Employee <span className="badge bg-success ms-2">1 Active</span>
                    </a>
                    <a href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect">Employee Lifecycle Dashboard</a>
                </Col>
                <Col md={3} className="mb-4">
                    <a href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect">Leave Application</a>
                    <a href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect">Attendance Dashboard</a>
                </Col>
                <Col md={3} className="mb-4">
                    <a href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect">HR Dashboard</a>
                    <a href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect">Expense Claims Dashboard</a>
                </Col>
                <Col md={3} className="mb-4">
                    <a href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect">Recruitment Dashboard</a>
                </Col>
            </Row>

            {/* Reports & Masters Section */}
            <h5 className="text-dark mb-4">Reports & Masters</h5>
            <Row>
                <Col md={4} className="mb-4">
                    <h6 className="section-title text-dark mb-3">Setup</h6>
                    {['Company', 'Branch', 'Department', 'Designation'].map(item => (
                        <a key={item} href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect">
                            {item}
                        </a>
                    ))}
                </Col>
                <Col md={4} className="mb-4">
                    <h6 className="section-title text-dark mb-3">Employee</h6>
                    {['Employee', 'Employee Group', 'Employee Grade'].map(item => (
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
            </Row>

            {/* Additional Sections */}
            <Row>
                <Col md={4} className="mb-4">
                    <h6 className="section-title text-dark mb-3">Settings</h6>
                    {['HR Settings', 'Daily Work Summary Group', 'Team Updates'].map(item => (
                        <a key={item} href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect">
                            {item}
                        </a>
                    ))}
                </Col>
                <Col md={4} className="mb-4">
                    <h6 className="section-title text-dark mb-3">Attendance</h6>
                    {['Attendance', 'Attendance Request', 'Employee Checkin'].map(item => (
                        <a key={item} href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect">
                            {item}
                        </a>
                    ))}
                </Col>
                <Col md={4} className="mb-4">
                    <h6 className="section-title text-dark mb-3">Expense Claim</h6>
                    {['Expense Claim', 'Employee Advance', 'Travel Request'].map(item => (
                        <a key={item} href="#" className="d-block mb-2 text-dark text-decoration-none hover-effect">
                            {item}
                        </a>
                    ))}
                </Col>
            </Row>
        </Container>
    );
};

export default Dashboard;
