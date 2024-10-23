// Sidebar.js
import React, { useState } from 'react';
import { Button, Col } from 'react-bootstrap';

const Sidebar = () => {
    const [isPublicOpen, setIsPublicOpen] = useState(false);

    const togglePublicDropdown = () => {
        setIsPublicOpen(!isPublicOpen);
    };

    return (
        <Col xs={2} className="bg-light vh-100 position-fixed p-4 sidebar shadow-sm">
            <h4 className="text-dark mb-4">HR</h4>
            <ul className="nav flex-column">
                <li className="nav-item">
                    <Button
                        variant="link"
                        className="nav-link text-dark"
                        onClick={togglePublicDropdown}
                        style={{ textAlign: 'left' }}
                    >
                        Public
                    </Button>
                    <div className={isPublicOpen ? 'collapse show' : 'collapse'}>
                        <ul className="list-unstyled ps-3">
                            {['HR', 'Projects', 'Users', 'Website', 'Payroll', 'Tools', 'ERPNext Settings', 'Integrations', 'Build'].map(item => (
                                <li key={item} className="nav-item">
                                    <a
                                        className="nav-link text-dark hover-effect"
                                        href="#"
                                        style={{ paddingLeft: '10px' }}
                                    >
                                        {item}
                                    </a>
                                </li>
                            ))}
                        </ul>
                    </div>
                </li>
            </ul>
        </Col>
    );
};

export default Sidebar;
