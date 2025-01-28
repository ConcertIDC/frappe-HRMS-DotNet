// import React from 'react';
// import  "../../Assets/Css/CommonTable.css"

// const CommonTable = ({ columns, data, onAdd, onFilter }) => {
//   return (
//     <div className="table-wrapper">
//       {/* Header Section */}
//       <div className="table-controls">
//         <div className="view-options">
//           <button className="list-view">List View</button>
//         </div>
//         <div className="action-buttons">
//           <button className="filter-button" onClick={onFilter}>
//             <span>Filters</span> 1
//           </button>
//           <button className="refresh-button">⟳</button>
//           <button className="add-button" onClick={onAdd}>+ Add Employee</button>
//         </div>
//       </div>
      
//       {/* Table */}
//       <table className="common-table">
//         <thead>
//           <tr>
//             {columns.map((col) => (
//               <th key={col.key}>{col.header}</th>
//             ))}
//           </tr>
//         </thead>
//         <tbody>
//           {data.map((row, index) => (
//             <tr key={index}>
//               {columns.map((col) => (
//                 <td key={col.key}>{row[col.key]}</td>
//               ))}
//             </tr>
//           ))}
//         </tbody>
//       </table>

//       {/* Pagination Section */}
//       <div className="pagination-wrapper">
//         <span>1 of {data.length}</span>
//         <div className="pagination-controls">
//           <select>
//             <option value="20">20</option>
//             <option value="100">100</option>
//             <option value="500">500</option>
//             <option value="2500">2500</option>
//           </select>
//         </div>
//       </div>
//     </div>
//   );
// };

// export default CommonTable;
import React, { useState } from "react";
import { Table, Form, Button, Dropdown, Pagination } from "react-bootstrap";

const CommonTable = ({ data }) => {
  const [selectedRows, setSelectedRows] = useState([]);
  const [itemsPerPage, setItemsPerPage] = useState(20);
  const [currentPage, setCurrentPage] = useState(1);

  const toggleRowSelection = (id) => {
    setSelectedRows((prev) =>
      prev.includes(id) ? prev.filter((row) => row !== id) : [...prev, id]
    );
  };

  const handlePageChange = (pageNumber) => {
    setCurrentPage(pageNumber);
  };

  const paginatedData = data.slice(
    (currentPage - 1) * itemsPerPage,
    currentPage * itemsPerPage
  );

  return (
    <div>
      <div className="d-flex justify-content-between mb-3">
        <input type="text" placeholder="Search..." className="form-control w-25" />
        <Button variant="dark">+ Add Company</Button>
      </div>
      <Table striped bordered hover>
        <thead>
          <tr>
            <th>
              <Form.Check type="checkbox" />
            </th>
            <th>ID</th>
            <th>Country</th>
            <th>Parent Company</th>
            <th>Last Updated On</th>
          </tr>
        </thead>
        <tbody>
          {paginatedData.map((item) => (
            <tr key={item.id}>
              <td>
                <Form.Check
                  type="checkbox"
                  checked={selectedRows.includes(item.id)}
                  onChange={() => toggleRowSelection(item.id)}
                />
              </td>
              <td>{item.id}</td>
              <td>{item.country}</td>
              <td>{item.parentCompany}</td>
              <td>{item.lastUpdated}</td>
            </tr>
          ))}
        </tbody>
      </Table>
      <div className="d-flex justify-content-between">
        <Dropdown onSelect={(e) => setItemsPerPage(Number(e))}>
          <Dropdown.Toggle variant="light">Items per page</Dropdown.Toggle>
          <Dropdown.Menu>
            {[20, 100, 500, 2500].map((num) => (
              <Dropdown.Item key={num} eventKey={num}>{num}</Dropdown.Item>
            ))}
          </Dropdown.Menu>
        </Dropdown>
        <Pagination>
          {[...Array(Math.ceil(data.length / itemsPerPage)).keys()].map((num) => (
            <Pagination.Item
              key={num + 1}
              active={num + 1 === currentPage}
              onClick={() => handlePageChange(num + 1)}
            >
              {num + 1}
            </Pagination.Item>
          ))}
        </Pagination>
      </div>
    </div>
  );
};

export default CommonTable;
