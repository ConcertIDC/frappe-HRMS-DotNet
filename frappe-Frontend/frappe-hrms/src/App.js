import { BrowserRouter, Routes, Route } from "react-router-dom";
import './Assets/Css/style.css';
import Organisation from './Pages/OrganisationSetup';
import Signup from "./Pages/Signup";
import Login from "./Pages/Login";
import Dashboard from "./Pages/Dashboard";
import Layout from './Pages/Layout';
import PrivateRoute from "./PrivateRouter/PrivateRouter";
import EmployeeListPage from "./Pages/Employee/EmployeeListPage";
import CompanyList from "./Company/CompanyList";
import Shortcut from "./Components/Shortcut/Shortcut";

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
        <Route element={<Layout />}>
          <Route path="/" element={<Dashboard />} />
          </Route>
          {/* <Route path="/Signup" element={<Signup />} />
          <Route path="/organisation" element={<Organisation />} />
          <Route element={<PrivateRoute />}>
            <Route element={<Layout />}>
              <Route path="/dashboard" element={<Dashboard />} />
              <Route path="/employee-list" element={<EmployeeListPage />} />
              <Route path="/company-list" element={<CompanyList />} />
            </Route>
          </Route> */}
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
