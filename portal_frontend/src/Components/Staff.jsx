import React from "react";
import Person from "./Person";

class Staff extends React.Component {
  state = {
    persons: [],
    example: "example",
  };

  getPersons = async () => {
    let response = await fetch("https://localhost:5001/api/persons");
    let data = await response.json();
    console.log(data);
    this.setState({
      persons: data,
    });
  };

  render() {
    return (
      <div className="content">
        <Person name="Maxim"></Person>
        <Person name="Maxim2"></Person>
        <Person name="Maxim3"></Person>
        <button onClick={this.getPersons.bind(this)}>button</button>
        {this.state.persons.map((person) => (
          <div>
            <div>{person.familyName}</div>
          </div>
        ))}
      </div>
    );
  }
}

export default Staff;
