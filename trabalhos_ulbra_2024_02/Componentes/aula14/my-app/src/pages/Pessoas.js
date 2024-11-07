import React from 'react';
import { useData } from '../data/DataContext';
import Header from '../components/Header';

function Pessoas() {
  const { people } = useData();
  
  return (
    <div>
      <Header/>
      <h2>Lista de Pessoas</h2>
      {people.length === 0 ? (
        <p>Nenhuma pessoa cadastrada.</p>
      ) : (
        <ul>
          {people.map((person, index) => (
            <li key={index} style={{ marginBottom: '15px', borderBottom: '1px solid #ccc', paddingBottom: '10px' }}>
              <img src={person.photoUrl} alt={person.name} style={{ width: '50px', height: '50px', borderRadius: '50%' }} />
              <p>Nome: {person.name}</p>
              <p>Telefone: {person.phone}</p>
              <p>Sexo: {person.gender}</p>
            </li>
          ))}
        </ul>
      )}
    </div>
  );
}

export default Pessoas;
