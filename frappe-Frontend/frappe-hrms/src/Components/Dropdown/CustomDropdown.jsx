import React from 'react';
import { Form } from 'react-bootstrap';

const CustomDropdown = ({ label, options, onChange, value,className }) => {
  return (
    <Form.Group controlId="custom-dropdown" className='mb-3'>
      <Form.Label>{label}</Form.Label>
      <Form.Select value={value} onChange={onChange}>
        {options.map((option, index) => (
          <option key={index} value={option.value}>
            {option.label}
          </option>
        ))}
      </Form.Select>
    </Form.Group>
  );
};

export default CustomDropdown;