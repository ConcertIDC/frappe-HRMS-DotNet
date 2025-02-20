import React from "react";
import { Modal, Button } from "react-bootstrap";

const ErrorModal = ({ show, handleClose, errors }) => {
  return (
    <Modal show={show} onHide={handleClose} centered>
      <Modal.Header closeButton>
        <Modal.Title>Form Errors</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        <ul>
          {errors.map((error, index) => (
            <li key={index} className="text-danger">
              {error}
            </li>
          ))}
        </ul>
      </Modal.Body>
      <Modal.Footer>
        <Button variant="danger" onClick={handleClose}>
          Close
        </Button>
      </Modal.Footer>
    </Modal>
  );
};

export default ErrorModal;
