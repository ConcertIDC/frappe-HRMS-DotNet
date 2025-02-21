import React, { useState } from "react";
import { Table, Form, Button, ButtonGroup } from "react-bootstrap";
import { CiEdit, CiTrash } from "react-icons/ci";
import { FaEdit, FaTrash } from "react-icons/fa";
import { FaDeleteLeft } from "react-icons/fa6";
import { GiPencil } from "react-icons/gi";
import { GrEdit } from "react-icons/gr";
import { IoPencil } from "react-icons/io5";
import { MdOutlineModeEditOutline } from "react-icons/md";
import { VscEdit } from "react-icons/vsc";
import { useNavigate } from "react-router-dom";

const CommonTable = ({ data, columns, title, searchTitle ,handleClick}) => {
  const [selectedRows, setSelectedRows] = useState([]);
  const [itemsPerPage, setItemsPerPage] = useState(20);
  const [currentPage, setCurrentPage] = useState(1);
  const [searchQuery, setSearchQuery] = useState("");
  const navigate=useNavigate();

  const allRowsSelected = selectedRows.length === data.length && data.length > 0;

  const toggleRowSelection = (id) => {
    setSelectedRows((prev) =>
      prev.includes(id) ? prev.filter((row) => row !== id) : [...prev, id]
    );
  };

  const toggleSelectAll = () => {
    if (allRowsSelected) {
      setSelectedRows([]);
    } else {
      setSelectedRows(data.map((item) => item.id));
    }
  };

  const handleSearchChange = (event) => {
    setSearchQuery(event.target.value.toLowerCase());
    setCurrentPage(1);
  };

  const firstColumnKey = columns[0]?.key;
  const filteredData = data?.filter((item) =>
    item[firstColumnKey]?.toString().toLowerCase().includes(searchQuery)
  );

  const paginatedData = filteredData?.slice(
    (currentPage - 1) * itemsPerPage,
    currentPage * itemsPerPage
  );

  const handleEdit = (id) => {
    navigate(`/${title.toLowerCase()}/${id}`)
  }

  return (
    <div>
      <div className="d-flex justify-content-end mb-3">
        <Button variant="dark" className="rounded" onClick={handleClick}>
          + Add {title}
        </Button>
      </div>
      <div className="border border-1 rounded">
        <div className="p-3">
          <input
            type="text"
            placeholder={searchTitle}
            style={{ backgroundColor: "#c1c1c145" }}
            className="form-control w-25"
            value={searchQuery}
            onChange={handleSearchChange}
          />
        </div>
        <div className="border-top p-3">
          <Table className="rounded">
            <thead className="rounded">
              <tr className="rounded">
                <th style={{ backgroundColor: "#c1c1c145", width: "10px" }}>
                  <Form.Check
                    type="checkbox"
                    checked={allRowsSelected}
                    onChange={toggleSelectAll}
                  />
                </th>
                {columns.map((item, index) => (
                  <th
                    key={item.key}
                    style={{
                      backgroundColor: "#c1c1c145",
                      color: "rgb(77, 75, 75)",
                      fontWeight: "normal",
                      textAlign: index === columns.length - 1 ? "right" : "left",
                    }}
                  >
                    {item.header}
                  </th>
                ))}
                <th className="px-3" style={{
                      backgroundColor: "#c1c1c145",
                      color: "rgb(77, 75, 75)",
                      fontWeight: "normal",
                      textAlign:  "right",
                    }}>Actions</th>
              </tr>
            </thead>
            <tbody>
              {paginatedData?.map((item) => (
                <tr className="border-bottom bg-dark" key={item.id}>
                  <td>
                    <Form.Check
                      type="checkbox"
                      checked={selectedRows.includes(item.id)}
                      onChange={() => toggleRowSelection(item.id)}
                      style={{
                        cursor: "pointer",
                      }}
                    />
                  </td>
                  {columns.map((col, index) => (
                    <td
                      key={col.key}
                      style={{
                        fontWeight: index === 0 ? "550" : "normal",
                        color: index === 0 ? "rgb(78, 76, 76)" : "rgb(77, 75, 75)",
                        cursor: "pointer",
                        textAlign: index === columns.length - 1 ? "right" : "left",
                      }}
                      className="hover-table"
                      onClick={() => handleEdit(item.id)}
                    >
                      {col.key === "status" ? (
                        <span
                          style={{
                            padding: "0px 10px",
                            borderRadius: "15px",
                            fontSize: "14px",
                            display: "inline-block",
                            color:
                              item[col.key] === "Open" || item[col.key] === "Replied"
                                ? "#a14f00"
                                : item[col.key] === "Accepted"
                                ? "#267e4c"
                                : item[col.key] === "Rejected" || item[col.key] === "Hold"
                                ? "#b23c3c"
                                : item[col.key] === 1
                                ? "#267e4c"
                                : item[col.key] === 0
                                ? "#b23c3c"
                                : "#000",
                            backgroundColor:
                              item[col.key] === "Open"|| item[col.key] === "Replied"
                                ? "#ffecd6"
                                : item[col.key] === "Accepted"
                                ? "#d7f5e5"
                                : item[col.key] === "Rejected" || item[col.key] === "Hold"
                                ? "#fde8e8"
                                : item[col.key] === 1
                                ? "#d7f5e5"
                                : item[col.key] === 0
                                ? "#fde8e8"
                                : "#f1f1f1",
                          }}
                        >
                          {item[col.key] === 1
                            ? "Active"
                            : item[col.key] === 0
                            ? "Inactive"
                            : item[col.key]}
                        </span>
                      ) : col.key === "disabled" ? (
                        <span
                          className={`status-badge ${
                            item.disabled ? "enabled-status" : "disabled-status"
                          }`}
                        >
                          {item.disabled ? "Enabled" : "Disabled"}
                        </span>
                      ) : col.key === "designation" ? (
                        item.designation?.designationName
                      ) : (
                        item[col.key]
                      )}
                    </td>
                  ))}
                  <td className="text-end "><MdOutlineModeEditOutline onClick={()=>handleEdit(item.id)} title="Edit" className="me-2 cursor-pointer"/><CiTrash title="Delete" color="red" className="me-2 cursor-pointer"/></td>
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
                  color: itemsPerPage === number ? "#000000" : "rgb(106, 102, 102)",
                }}
                variant="light"
                onClick={() => {
                  setItemsPerPage(number);
                  setCurrentPage(1);
                }}
              >
                {number}
              </Button>
            ))}
          </ButtonGroup>
        </div>
      </div>
    </div>
  );
};

export default CommonTable;
