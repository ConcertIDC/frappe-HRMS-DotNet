import React from 'react';

const Button = ({ label, type = 'button', onClick, className = '', disabled = false }) => {
  return (
    <button 
      type={type} 
      className={`btn ${className}`} 
      onClick={onClick} 
      disabled={disabled}
    >
      {label}
    </button>
  );
};

export default Button;
