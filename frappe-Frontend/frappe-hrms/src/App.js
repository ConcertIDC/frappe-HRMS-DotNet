import { BrowserRouter, Routes, Route } from "react-router-dom";
import './App.css';
import Organisation from './Pages/OrganisationSetup';
import Signup from "./Pages/Signup";
import Login from "./Pages/Login";
import Dashboard from "./Pages/Dashboard";
import Layout from './Pages/Layout';
import PrivateRoute from "./PrivateRouter/PrivateRouter";

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Login />} />
          <Route path="/Signup" element={<Signup />} />
          <Route path="/organisation" element={<Organisation />} />
          <Route element={<PrivateRoute />}>
            <Route element={<Layout />}>
              <Route path="/dashboard" element={<Dashboard />} />
            </Route>
          </Route>
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
