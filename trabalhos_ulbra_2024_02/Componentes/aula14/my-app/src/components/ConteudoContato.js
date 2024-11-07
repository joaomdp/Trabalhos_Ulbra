import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { useData } from '../data/DataContext';

function ConteudoContato() {
  const [photoUrl, setPhotoUrl] = useState('');
  const [name, setName] = useState('');
  const [phone, setPhone] = useState('');
  const [gender, setGender] = useState('');
  const { addPerson } = useData();
  const navigate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();
    addPerson({ photoUrl, name, phone, gender });
    navigate('/pessoas');  // Navega para a página "Pessoas" após o envio
  };

  return (
    <form onSubmit={handleSubmit} style={{ maxWidth: '300px', margin: 'auto' }}>
      <h2>Cadastro</h2>
      
      <label>
        Foto (URL):
        <input
          type="url"
          value={photoUrl}
          onChange={(e) => setPhotoUrl(e.target.value)}
          placeholder="URL da foto"
        />
      </label>
      
      <label>
        Nome:
        <input
          type="text"
          value={name}
          onChange={(e) => setName(e.target.value)}
          placeholder="Nome"
        />
      </label>

      <label>
        Telefone:
        <input
          type="tel"
          value={phone}
          onChange={(e) => setPhone(e.target.value)}
          placeholder="(XX) XXXXX-XXXX"
        />
      </label>

      <label>
        Sexo:
        <select value={gender} onChange={(e) => setGender(e.target.value)}>
          <option value="">Selecione</option>
          <option value="male">Masculino</option>
          <option value="female">Feminino</option>
          <option value="other">Outro</option>
        </select>
      </label>

      <button type="submit">Enviar</button>
    </form>
  );
}

export default ConteudoContato;
