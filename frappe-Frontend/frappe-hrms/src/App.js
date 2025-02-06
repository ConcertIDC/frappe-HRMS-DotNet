import { BrowserRouter, Routes, Route } from "react-router-dom";
import './Assets/Css/style.css';
import Organisation from './Pages/OrganisationSetup';
import Signup from "./Pages/Signup";
import Login from "./Pages/Login";
import Dashboard from "./Pages/Dashboard";
import Layout from './Pages/Layout';
import PrivateRoute from "./PrivateRouter/PrivateRouter";
import EmployeeListPage from "./Pages/Employee/EmployeeListPage";
import CompanyListPage from "./Pages/Company/CompanyListPage";
import BranchListPage from "./Pages/Company/BranchListPage";
import DepartmentListPage from "./Pages/Company/DepartmentListPage";
import DesignationListPage from "./Pages/Company/DesignationListPage";

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Login />}/>
          <Route path="/Signup" element={<Signup />} />
          <Route path="/organisation" element={<Organisation />} />
          <Route element={<PrivateRoute />}>
            <Route element={<Layout />}>
              <Route path="/dashboard" element={<Dashboard />} />
              <Route path="/employee" element={<EmployeeListPage />} />
              <Route path="/company" element={<CompanyListPage />} />
              <Route path="/branch" element={<BranchListPage />} />
              <Route path="/department" element={<DepartmentListPage />} />
              <Route path="/designation" element={<DesignationListPage />} />
            </Route>
          </Route>
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
