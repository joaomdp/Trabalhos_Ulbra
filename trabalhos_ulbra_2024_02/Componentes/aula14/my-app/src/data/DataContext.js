import React, { createContext, useState, useContext } from 'react';

const DataContext = createContext();

export function DataProvider({ children }) {
  const [people, setPeople] = useState([]);

  const addPerson = (person) => {
    setPeople((prevPeople) => [...prevPeople, person]);
  };

  return (
    <DataContext.Provider value={{ people, addPerson }}>
      {children}
    </DataContext.Provider>
  );
}

export function useData() {
  return useContext(DataContext);
}
