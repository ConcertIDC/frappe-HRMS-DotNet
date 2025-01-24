import React from 'react';
import { GoArrowUpRight } from "react-icons/go";

const Shortcut = ({ name }) => {
  return (
    <div style={{ 
        fontSize: '14px',
        cursor: 'pointer',
      }}
      title={name}
    >
      {name} 
      <GoArrowUpRight style={{ fontSize: '14px', marginLeft:'10px'}} />
    </div>
  );
};

export default Shortcut;
