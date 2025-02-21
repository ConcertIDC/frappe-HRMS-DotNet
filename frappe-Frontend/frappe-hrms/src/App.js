import { BrowserRouter, Routes, Route } from "react-router-dom";
import './assets/css/style.css';
import Organisation from './pages/OrganisationSetup';
import Signup from "./pages/Signup";
import Login from "./pages/Login";
import Dashboard from "./pages/Dashboard";
import PrivateRoute from "./privaterouter/PrivateRouter";
import EmployeeListPage from "./pages/employee/EmployeeListPage";
import CompanyListPage from "./pages/company/CompanyListPage";
import BranchListPage from "./pages/company/BranchListPage";
import DepartmentListPage from "./pages/company/DepartmentListPage";
import DesignationListPage from "./pages/company/DesignationListPage";
import EmployeeGradeListPage from "./pages/employee/EmployeeGradeListPage";
import EmployeeGroupListPage from "./pages/employee/EmployeeGroupListPage";
import EmploymentTypeListPage from "./pages/employee/EmploymentTypeListPage";
import JobApplicantListPage from "./pages/Job/JobApplicantListPage";
import LayoutWithoutSideBar from "./pages/layout/LayoutWithoutSideBar";
import Layout from "./pages/layout/Layout";
import CompanyForm from "./pages/company/CompanyForm";

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
              <Route path="/employee-grade" element={<EmployeeGradeListPage />} />
              <Route path="/employee-group" element={<EmployeeGroupListPage />} />
              <Route path="/employment-type" element={<EmploymentTypeListPage />} />
              <Route path="/job-applicant" element={<JobApplicantListPage />} />
            </Route>

            <Route element={<LayoutWithoutSideBar />}>
              <Route path="/add-company" element={<CompanyForm />} />
              <Route path="/company/:id" element={<CompanyForm />} />
            </Route>
          </Route>
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
