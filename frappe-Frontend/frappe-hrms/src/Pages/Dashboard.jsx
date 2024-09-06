import React from 'react';
import { useDispatch } from 'react-redux';
import Button from '../Components/Button/Button';
import { Col, Row } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';
import NavbarComponent from '../Components/navbar/Navbar';
import { logoutAction } from '../redux/actions/LoginActions';

const Dashboard = () => {
    const navigate = useNavigate();
    const dispatch = useDispatch();

    const handleLogout = () => {
        localStorage.removeItem("Token");
        dispatch(logoutAction());
        navigate('/');
    };

    return (
        <>
            <NavbarComponent />
            <Row className='mt-3'>
                <Col className='d-flex justify-content-between align-items-center'>
                    <h1>Dashboard</h1>
                    <Button onClick={handleLogout} className='btn btn-danger' label='Logout' />
                </Col>
            </Row>
        </>
    );
}

export default Dashboard;
