import React from "react";
import { BrowserRouter, Route } from "react-router-dom";
import "./App.css";
import Birthdays from "./Components/Birthdays";

import Header from "./Components/Header";
import Sidebar from "./Components/Sidebar";
import Staff from "./Components/Staff";

const App = () => {
  return (
    <BrowserRouter>
      <div className="App">
        <Header></Header>
        <Sidebar></Sidebar>
        <Route path="/staff" component={Staff}></Route>
        <Route path="/birthdays" component={Birthdays}></Route>
      </div>
    </BrowserRouter>
  );
};

export default App;
