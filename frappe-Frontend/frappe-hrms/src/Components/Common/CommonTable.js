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
import { Table, Form, Button, Dropdown, Pagination, ButtonGroup } from "react-bootstrap";

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
      <div className="d-flex justify-content-end mb-3">
        
        <Button variant="dark" className="rounded">+  Add Company</Button>
      </div>
      <div className="border border-1 rounded">
      <div className="p-3">
        <input type="text" placeholder="Search..." className="form-control w-25" />
      </div>
      <div className="border-top p-3">
      <Table  borderless>
        <thead>
          <tr>
            <th  style={{backgroundColor:"#c1c1c145"}}>
              <Form.Check type="checkbox" />
            </th>
            <th  style={{backgroundColor:"#c1c1c145",fontWeight:"normal"}}>ID</th>
            <th style={{backgroundColor:"#c1c1c145",fontWeight:"normal"}}>Country</th>
            <th style={{backgroundColor:"#c1c1c145",fontWeight:"normal"}}>Parent Company</th>
            <th style={{backgroundColor:"#c1c1c145",fontWeight:"normal"}}>Last Updated On</th>
          </tr>
        </thead>
        <tbody className="bg-white">
          {paginatedData.map((item) => (
            <tr className="border-bottom" key={item.id}>
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
      </div>
      <div className="d-flex justify-content-between border-top p-3">
      <ButtonGroup className="" aria-label="First group">
        <Button style={{backgroundColor:"#c1c1c145",borderColor:"#d4c0c061"}} variant="light">20</Button>
        <Button style={{backgroundColor:"#c1c1c145",borderColor:"#d4c0c061"}} variant="light">100</Button>
        <Button style={{backgroundColor:"#c1c1c145",borderColor:"#d4c0c061"}} variant="light">500</Button>
        <Button style={{backgroundColor:"#c1c1c145",borderColor:"#d4c0c061"}} variant="light">2500</Button>
      </ButtonGroup>
      </div>
    </div>
    </div>
  );
};

export default CommonTable;
