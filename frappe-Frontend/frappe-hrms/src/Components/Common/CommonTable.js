import React, { useState } from "react";
import { Table, Form, Button, ButtonGroup } from "react-bootstrap";

const CommonTable = ({ data, columns, title }) => {
  const [selectedRows, setSelectedRows] = useState([]);
  const [itemsPerPage, setItemsPerPage] = useState(20);
  const [currentPage, setCurrentPage] = useState(1);
  const [searchQuery, setSearchQuery] = useState("");

  const toggleRowSelection = (id) => {
    setSelectedRows((prev) =>
      prev.includes(id) ? prev.filter((row) => row !== id) : [...prev, id]
    );
  };

  const handlePageChange = (pageNumber) => {
    setCurrentPage(pageNumber);
  };

  const handleSearchChange = (event) => {
    setSearchQuery(event.target.value.toLowerCase());
    setCurrentPage(1); // Reset to first page on new search
  };

  // Assuming the second column is at index 1
  const secondColumnKey = columns[0]?.key;

  const filteredData = data?.filter((item) =>
    item[secondColumnKey]?.toLowerCase().includes(searchQuery)
  );

  const paginatedData = filteredData?.slice(
    (currentPage - 1) * itemsPerPage,
    currentPage * itemsPerPage
  );

  return (
    <div>
      <div className="d-flex justify-content-end mb-3">
        <Button variant="dark" className="rounded">
          + Add {title}
        </Button>
      </div>
      <div className="border border-1 rounded">
        <div className="p-3">
          <input
            type="text"
            placeholder="ID"
            style={{backgroundColor:"#c1c1c145"}}
            className="form-control w-25"
            value={searchQuery}
            onChange={handleSearchChange}
          />
        </div>
        <div className="border-top p-3">
          <Table borderless>
            <thead>
              <tr>
                <th style={{ backgroundColor: "#c1c1c145" }}>
                  <Form.Check type="checkbox" />
                </th>
                {columns.map((item) => (
                  <th
                    key={item.key}
                    style={{ backgroundColor: "#c1c1c145", fontWeight: "normal" }}
                  >
                    {item.header}
                  </th>
                ))}
              </tr>
            </thead>
            <tbody className="bg-white">
              {paginatedData?.map((item) => (
                <tr className="border-bottom" key={item.id}>
                  <td>
                    <Form.Check
                      type="checkbox"
                      checked={selectedRows.includes(item.id)}
                      onChange={() => toggleRowSelection(item.id)}
                    />
                  </td>
                  {columns.map((col) => (
                    <td key={col.key}>{item[col.key]}</td>
                  ))}
                </tr>
              ))}
            </tbody>
          </Table>
        </div>
        <div className="d-flex justify-content-between border-top p-3">
          <ButtonGroup aria-label="Items per page">
            {[20, 100, 500, 2500].map((number) => (
              <Button
                key={number}
                style={{
                  backgroundColor: itemsPerPage === number ? "#ffffff" : "#c1c1c145",
                  borderColor: "#d4c0c061",
                  color: itemsPerPage === number ? "#000000" : "#000000",
                }}
                variant="light"
                onClick={() => {
                  setItemsPerPage(number);
                  setCurrentPage(1); // Reset to first page when items per page changes
                }}
              >
                {number}
              </Button>
            ))}
          </ButtonGroup>
          {/* Pagination controls can be added here */}
        </div>
      </div>
    </div>
  );
};

export default CommonTable;
