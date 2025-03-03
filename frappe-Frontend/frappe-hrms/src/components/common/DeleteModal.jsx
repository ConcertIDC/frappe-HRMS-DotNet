import React from "react";
import { Modal, Button } from "react-bootstrap";

const DeleteModal = ({ show, handleClose, handleDelete, title }) => {
  return (
    <Modal show={show} onHide={handleClose} style={{marginTop: '3%'}} >
      <Modal.Header style={{fontSize:'12px'}} closeButton>
        <Modal.Title style={{fontSize:'18px',fontWeight:'600'}}>Confirm</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        <p style={{color:'rgb(94, 87, 87)'}}>
          Permanently delete <strong>{title}</strong>?
        </p>
      </Modal.Body>
      <Modal.Footer>
        <Button className="btn-sm" variant="light" onClick={handleClose} style={{color: 'rgb(77, 74, 74)'}}>
          No
        </Button>
        <Button className="btn-sm" variant="dark" onClick={handleDelete}>
          Yes
        </Button>
      </Modal.Footer>
    </Modal>
  );
};

export default DeleteModal;
