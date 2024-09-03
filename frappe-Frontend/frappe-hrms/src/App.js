import { BrowserRouter, Routes, Route } from "react-router-dom";
import './App.css';
import '@iconify/react';
import Organisation from './Pages/OrganisationSetup';
import Signup from "./Pages/Signup";
import Login from "./Pages/Login";
import Dashboard from "./Pages/Dashboard";

function App() {
  console.log("gytgyg");
  

  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Signup />} />
          <Route path="/organisation" element={<Organisation />} />
          {/* <Route path="/login" element={<Login />} /> */}
          <Route path="/dashboard" element={<Dashboard />} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
