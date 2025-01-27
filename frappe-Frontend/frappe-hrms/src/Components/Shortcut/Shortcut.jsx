import React from 'react';
import { Link } from 'react-router-dom'; // Ensure this is imported
import { GoArrowUpRight } from "react-icons/go";

const Shortcut = ({ name, path }) => {
  return (
    <Link 
      to={path} // Use dynamic interpolation for the path
      className="d-block mb-2 text-dark text-decoration-none hover-effect"
    >
      <div 
        style={{ 
          fontSize: '14px',
          cursor: 'pointer',
          display: 'flex',
          alignItems: 'center' // Align text and icon properly
        }}
        title={name}
      >
        {name} 
        <GoArrowUpRight 
          style={{ 
            fontSize: '14px', 
            marginLeft: '10px' 
          }} 
        />
      </div>
    </Link>
  );
};

export default Shortcut;
