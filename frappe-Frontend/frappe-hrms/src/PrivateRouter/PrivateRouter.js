
import React from 'react';
import { Route, Navigate } from 'react-router-dom';
import { useSelector } from 'react-redux';

const PrivateRoute = ({ element: Element, ...rest }) => {
  const { data } = useSelector(state => state.auth);
  const isAuthenticated = !!data?.username;

  return (
    <Route
      {...rest}
      element={isAuthenticated ? Element : <Navigate to="/login" />}
    />
  );
};

export default PrivateRoute;
