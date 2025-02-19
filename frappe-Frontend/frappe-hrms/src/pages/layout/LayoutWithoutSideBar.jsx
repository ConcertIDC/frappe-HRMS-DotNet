// src/Pages/Layout.js
import React from 'react';
import { Outlet } from 'react-router-dom';
import Header from '../../components/header/Header';
import { Col,Row } from 'react-bootstrap';

const LayoutWithoutSideBar = () => {
  return (
    <div>
      <Row>
      <Header />
      </Row>
      <Col  className="p-4 main-content ">
        <Outlet />
      </Col>
    </div>
  );
};

export default LayoutWithoutSideBar;
