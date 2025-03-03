import React, { useState } from 'react'
import { Button, ButtonGroup, Form, Table } from 'react-bootstrap';
import { CiTrash } from 'react-icons/ci';
import { MdOutlineModeEditOutline } from 'react-icons/md';
import { CiSettings } from "react-icons/ci";
const CustomEditTable = ({ columns, data, initialValues, title, tableName }) => {
    const [selectedRows, setSelectedRows] = useState([]);
    const [tabledata, setTableData] = useState(data);
    const [edit, setEdit] = useState(false)

    const allRowsSelected = selectedRows.length === data?.length && data?.length > 0;

    const toggleSelectAll = () => {
        if (allRowsSelected) {
            setSelectedRows([]);
        } else {
            setSelectedRows(data?.map((item) => item.id));
        }
    };

    const toggleRowSelection = (id) => {
        setSelectedRows((prev) =>
            prev.includes(id) ? prev.filter((row) => row !== id) : [...prev, id]
        );
    };

    return (
        <div>
            <p>{title}</p>
            <Table className="rounded" bordered >
                <thead className="rounded">
                    <tr className="rounded">
                        <th style={{ backgroundColor: "#c1c1c145", textAlign: "center" }}>
                            <Form.Check
                                type="checkbox"
                                checked={allRowsSelected}
                                onChange={toggleSelectAll}
                            />
                        </th>
                        <th style={{
                            backgroundColor: "#c1c1c145",
                            color: "rgb(77, 75, 75)",
                            fontWeight: "normal",
                            fontSize: "14px",
                            textAlign: "center"
                        }}
                        >
                            No.
                        </th>
                        {columns.map((item, index) => (
                            <th
                                key={item.key}
                                style={{
                                    backgroundColor: "#c1c1c145",
                                    color: "rgb(77, 75, 75)",
                                    fontWeight: "normal",
                                    fontSize: "14px",
                                }}
                            >
                                {item.header}
                            </th>
                        ))}
                        <th
                            className="px-3"
                            style={{
                                backgroundColor: "#c1c1c145",
                                color: "rgb(77, 75, 75)",
                                fontWeight: "normal",
                                textAlign: "center",
                            }}
                        >
                            <CiSettings />
                        </th>
                    </tr>
                </thead>
                <tbody>
                    {tabledata?.map((item, tableIndex) => (
                        <tr className="border-bottom bg-dark" key={item.id}>
                            <td>
                                <Form.Check
                                    type="checkbox"
                                    checked={selectedRows.includes(item.id)}
                                    onChange={() => toggleRowSelection(item.id)}
                                    style={{
                                        cursor: "pointer",
                                        textAlign: "center",
                                    }}
                                />
                            </td>
                            <td style={{ textAlign: 'center' }}>
                                {tableIndex + 1}
                            </td>
                            {columns.map((col, index) => (
                                edit ? (
                                    <td key={col.key}>
                                        {col.type === 'date' ? (
                                            <input type="date" name={`${tableName}[${tableIndex}].${col.name}`} className='form-control' />
                                        ) : col.type === 'select' ? (
                                            <select name={`${tableName}[${tableIndex}].${col.name}`} className="form-control">
                                                <option hidden></option>
                                                {col.options?.map((option) => (
                                                    <option key={option.id} value={option.value}>
                                                        {option.label}
                                                    </option>
                                                ))}
                                            </select>
                                        ) : (
                                            <input name={`${tableName}[${tableIndex}].${col.name}`} className='form-control' />
                                        )}
                                    </td>
                                ) : (
                                    <td
                                        key={col.key}
                                        style={{
                                            fontWeight: index === 0 ? "550" : "normal",
                                            color: index === 0 ? "rgb(78, 76, 76)" : "rgb(77, 75, 75)",
                                            cursor: "pointer",
                                        }}
                                        onClick={() => setEdit(true)}
                                        className="hover-table"
                                    >
                                        {item[col.key]}
                                    </td>
                                )
                            ))}

                            <td className="text-center">
                                <MdOutlineModeEditOutline
                                    title="Edit"
                                    className="me-2 cursor-pointer"
                                />
                                <CiTrash title="Delete" color="red" className="me-2 cursor-pointer" />
                            </td>
                        </tr>
                    ))}
                </tbody>
            </Table>
            <Button onClick={() => setTableData([...tabledata, initialValues])} style={{ backgroundColor: '#c1c1c145', border: 'none', color: '#000000ba' }}>Add Row</Button>
        </div>
    )
}

export default CustomEditTable
