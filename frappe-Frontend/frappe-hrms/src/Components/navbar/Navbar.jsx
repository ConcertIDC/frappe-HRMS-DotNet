import React from 'react';
import { Link } from 'react-router-dom';
import { Navbar } from 'react-bootstrap';
import logo from '../../Assets/Images/person.png';
import { Icon } from '@iconify/react/dist/iconify.js';

const NavbarComponent = () => {
  return (
    <Navbar bg="dark" variant="dark" expand="lg" className="p-2 shadow-sm">
        <Navbar.Brand as={Link} to="/" className="d-flex align-items-center">
          <img src={logo} alt="Logo" style={{ width: '40px', height: '40px', marginRight: '10px' ,borderRadius:'10px'}} />
          <span className="fw-bold text-light">Dashboard</span>
        </Navbar.Brand>
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav" className="justify-content-end">
          <form className="d-flex align-items-center" role="search">
            <input
              className="form-control me-2"
              type="search"
              placeholder="Search"
              aria-label="Search"
              style={{ width: '250px' }}
            />
            <Icon icon="ic:baseline-notifications-none" width="30" height="30" className="text-light mx-3" />
            <Link to="/profile" className="text-light">
              <Icon icon="mdi:account-circle" width="30" height="30" />
            </Link>
          </form>
        </Navbar.Collapse>
    </Navbar>
  );
};

export default NavbarComponent;
