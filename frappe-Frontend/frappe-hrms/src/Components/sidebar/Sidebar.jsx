import React, { useState } from "react";
import { Nav } from "react-bootstrap";
import {
  FaUserFriends,
  FaUserCircle,
  FaChartLine,
  FaClock,
  FaMoneyCheckAlt,
  FaClipboardList,
  FaFolder,
  FaUsers,
  FaGlobe,
  FaCog,
  FaTools,
  FaBuilding,
  FaChevronDown,
  FaChevronUp,
} from "react-icons/fa";

const Sidebar = () => {
  const [expanded, setExpanded] = useState({});

  const toggleExpand = (key) => {
    setExpanded((prevState) => ({
      ...prevState,
      [key]: !prevState[key],
    }));
  };

  return (
    <Nav className="vh-100 p-3 relative text-nowrap bg-white">
      <Nav.Item>
        <Nav.Link style={{ color: "black !important" }} onClick={() => toggleExpand("hr")}>
          HR {expanded["hr"] ? <FaChevronUp className="ms-2" /> : <FaChevronDown className="ms-2" />}
        </Nav.Link>
        {expanded["hr"] && (
          <Nav className="flex-column ms-3">
            <Nav.Link><FaUserFriends className="me-2" />Recruitment</Nav.Link>
            <Nav.Link><FaUserCircle className="me-2" />Employee Lifecycle</Nav.Link>
            <Nav.Link><FaChartLine className="me-2" />Performance</Nav.Link>
            <Nav.Link><FaClock className="me-2" />Shift & Attendance</Nav.Link>
            <Nav.Link><FaMoneyCheckAlt className="me-2" />Expense Claims</Nav.Link>
            <Nav.Link><FaClipboardList className="me-2" />Leaves</Nav.Link>
          </Nav>
        )}
      </Nav.Item>

      <Nav.Item>
        <Nav.Link><FaFolder className="me-2" />Projects</Nav.Link>
      </Nav.Item>
      <Nav.Item>
        <Nav.Link><FaUsers className="me-2" />Users</Nav.Link>
      </Nav.Item>
      <Nav.Item>
        <Nav.Link><FaGlobe className="me-2" />Website</Nav.Link>
      </Nav.Item>

      <Nav.Item>
        <Nav.Link onClick={() => toggleExpand("payroll")}>
          Payroll {expanded["payroll"] ? <FaChevronUp className="ms-2" /> : <FaChevronDown className="ms-2" />}
        </Nav.Link>
        {expanded["payroll"] && (
          <Nav className="flex-column ms-3">
            <Nav.Link><FaMoneyCheckAlt className="me-2" />Salary Payout</Nav.Link>
            <Nav.Link><FaBuilding className="me-2" />Tax & Benefits</Nav.Link>
          </Nav>
        )}
      </Nav.Item>

      <Nav.Item>
        <Nav.Link><FaTools className="me-2" />Tools</Nav.Link>
      </Nav.Item>
      <Nav.Item>
        <Nav.Link><FaCog className="me-2" />ERPNext Settings</Nav.Link>
      </Nav.Item>
      <Nav.Item>
        <Nav.Link><FaCog className="me-2" />Integrations</Nav.Link>
      </Nav.Item>
      <Nav.Item>
        <Nav.Link><FaCog className="me-2" />ERPNext Integrations</Nav.Link>
      </Nav.Item>
      <Nav.Item>
        <Nav.Link><FaTools className="me-2" />Build</Nav.Link>
      </Nav.Item>
    </Nav>
  );
};

export default Sidebar;