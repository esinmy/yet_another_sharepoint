import React from "react";
import Person from "./Person";

class Staff extends React.Component {
  constructor(props) {
    super(props);
    this.getPersons();
  }

  getPersons = async () => {
    const response = await fetch("https://localhost:5001/api/persons");
    const somedata = await response.json();
    console.log(somedata);
  };

  render() {
    return (
      <div className="content">
        <Person name="Maxim"></Person>
        <Person name="Maxim2"></Person>
        <Person name="Maxim3"></Person>
      </div>
    );
  }
}

export default Staff;
