import React from 'react';
import  "../../Assets/Css/CommonTable.css"

const CommonTable = ({ columns, data, onAdd, onFilter }) => {
  return (
    <div className="table-wrapper">
      {/* Header Section */}
      <div className="table-controls">
        <div className="view-options">
          <button className="list-view">List View</button>
        </div>
        <div className="action-buttons">
          <button className="filter-button" onClick={onFilter}>
            <span>Filters</span> 1
          </button>
          <button className="refresh-button">⟳</button>
          <button className="add-button" onClick={onAdd}>+ Add Employee</button>
        </div>
      </div>
      
      {/* Table */}
      <table className="common-table">
        <thead>
          <tr>
            {columns.map((col) => (
              <th key={col.key}>{col.header}</th>
            ))}
          </tr>
        </thead>
        <tbody>
          {data.map((row, index) => (
            <tr key={index}>
              {columns.map((col) => (
                <td key={col.key}>{row[col.key]}</td>
              ))}
            </tr>
          ))}
        </tbody>
      </table>

      {/* Pagination Section */}
      <div className="pagination-wrapper">
        <span>1 of {data.length}</span>
        <div className="pagination-controls">
          <select>
            <option value="20">20</option>
            <option value="100">100</option>
            <option value="500">500</option>
            <option value="2500">2500</option>
          </select>
        </div>
      </div>
    </div>
  );
};

export default CommonTable;

