// src/Pages/Layout.js
import React from 'react';
import { Outlet } from 'react-router-dom';
import Sidebar from '../../components/sidebar/Sidebar';
import { Col,Row } from 'react-bootstrap';
import Header from '../../components/header/Header';

const Layout = () => {
  return (
    <div>
      <Row>
      <Header />
      </Row>
      
      <Col xs={2} className="fixed-sidebar ">
          <Sidebar />
      </Col>
      <Col xs={10} className="offset-2 p-4 main-content ">
        <Outlet />
      </Col>
    </div>
  );
};

export default Layout;
