import React from "react";
import { NavLink } from "react-router-dom";

const Sidebar = () => {
  return (
    <div className="sidebar">
      <ul className="sidebar__menu">
        <li>
          <NavLink to="/staff">All Persons</NavLink>
        </li>
        <li>
          <NavLink to="/birthdays">Birthdays</NavLink>
        </li>
      </ul>
    </div>
  );
};

export default Sidebar;
