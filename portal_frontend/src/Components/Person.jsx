import React from "react";

const Person = (props) => {
  return (
    <div className="person">
      <div>Name, Birthday {props.name}</div>
    </div>
  );
};

export default Person;
