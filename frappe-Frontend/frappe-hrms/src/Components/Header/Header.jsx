
 import React from 'react';
 import { Link } from 'react-router-dom';
// import { Navbar } from 'react-bootstrap';
 import logo from '../../Assets/Images/person.png';
// import { Icon } from '@iconify/react/dist/iconify.js';

// const Header = () => {
//   return (
//     <Navbar bg="dark" variant="dark" expand="lg" className="p-2 shadow-sm">
//         <Navbar.Brand as={Link} to="/" className="d-flex align-items-center">
//           <img src={logo} alt="Logo" style={{ width: '40px', height: '40px', marginRight: '10px' ,borderRadius:'10px'}} />
//         </Navbar.Brand>
//         <Navbar.Toggle aria-controls="basic-navbar-nav" />
//         <Navbar.Collapse id="basic-navbar-nav" className="justify-content-end">
//           <form className="d-flex align-items-center" role="search">
//             <input
//               className="form-control me-2"
//               type="search"
//               placeholder="Search"
//               aria-label="Search"
//               style={{ width: '250px' }}
//             />
//             <Icon icon="ic:baseline-notifications-none" width="30" height="30" className="text-light mx-3" />
//             <Link to="/profile" className="text-light">
//               <Icon icon="mdi:account-circle" width="30" height="30" />
//             </Link>
//           </form>
//         </Navbar.Collapse>
//     </Navbar>
//   );
// };

// export default Header;
//import React from "react";
import { Navbar, Nav, Form, FormControl, Dropdown } from "react-bootstrap";

const Header = () => {
  return (
    <Navbar
      expand="lg"
      className="shadow-sm px-4"
    >
      <Navbar.Brand as={Link} to="/" className="d-flex align-items-center">
           <img src={logo} alt="Logo" style={{ width: '40px', height: '40px', marginRight: '10px' ,borderRadius:'10px',marginLeft:'10px'}} />
        </Navbar.Brand>

      {/* Center Search Bar */}
      <Form className="mx-auto" style={{ flex: 1, maxWidth: "500px" }}>
        <FormControl
          type="search"
          placeholder="Search or type a command (Ctrl + G)"
          className="me-2 border-0"
          aria-label="Search"
          style={{
            paddingLeft: "16px",
            backgroundColor:"#c1c1c145",
            
          }}
        />
      </Form>

      {/* Right-Aligned Icons */}
      <Nav className="ms-auto d-flex align-items-center">
        {/* Help Dropdown */}
        <Dropdown>
          <Dropdown.Toggle
            variant="link"
            id="help-dropdown"
            style={{
              textDecoration: "none",
              color: "inherit",
              fontSize: "14px",
              fontWeight: "500",
            }}
          >
            Help
          </Dropdown.Toggle>
          <Dropdown.Menu>
            <Dropdown.Item href="#action1">FAQs</Dropdown.Item>
            <Dropdown.Item href="#action2">Contact Support</Dropdown.Item>
          </Dropdown.Menu>
        </Dropdown>

        {/* Circular "DD" Icon */}
        <div
          style={{
            backgroundColor: "#ffd1f5",
            width: "36px",
            height: "36px",
            borderRadius: "50%",
            display: "flex",
            justifyContent: "center",
            alignItems: "center",
            marginLeft: "16px",
            fontWeight: "bold",
            fontSize: "14px",
            color: "#dd0077",
          }}
        >
          dd
        </div>
      </Nav>
    </Navbar>
  );
};

export default Header;
