// src/Pages/Layout.js
import React from 'react';
import { Outlet } from 'react-router-dom';
import Header from '../Components/Header/Header';
import Sidebar from '../Components/sidebar/Sidebar';
import { Col } from 'react-bootstrap';

const Layout = () => {
  return (
    <div>
      <Header />
      <Col xs={2} className="fixed-sidebar p-0">
          <Sidebar />
      </Col>
      <Col xs={10} className="offset-2 bg-light p-4 main-content scrollable-content">
      <main>
        <Outlet />
      </main>
      </Col>
    </div>
  );
};

export default Layout;
