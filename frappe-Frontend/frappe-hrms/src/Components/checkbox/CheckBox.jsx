import React from 'react';

const Checkbox = ({ label, checked, onChange, className, id }) => {
  return (
    <div className={className}>
      <input
        type="checkbox"
        className="form-check-input "
        id={id}
        checked={checked}
        onChange={onChange}
      />
      {label && (
        <label className="form-check-label ms-2" htmlFor={id}>
          {label}
        </label>
      )}
    </div>
  );
};

export default Checkbox;
