import React, { useState } from 'react';

const ParticipantForm = ({ onAddParticipant }) => {
    const [nome, setNome] = useState('');
    const [telefone, setTelefone] = useState('');
    const [fotoUrl, setFotoUrl] = useState('');
    const [egressoConvidado, setEgressoConvidado] = useState(false);
    const [confirmado, setConfirmado] = useState(false);

    const handleSubmit = (event) => {
        event.preventDefault();
        if (!nome || !telefone || !fotoUrl) {
            alert("Por favor, preencha todos os campos.");
            return;
        }

        const newParticipant = {
            nome,
            telefone,
            fotoUrl,
            egressoConvidado,
            confirmado,
        };

        onAddParticipant(newParticipant);

        setNome('');
        setTelefone('');
        setFotoUrl('');
        setEgressoConvidado(false);
        setConfirmado(false);
    };

    return (
        <form onSubmit={handleSubmit}>
            <label>
                Nome:
                <input 
                    type="text" 
                    placeholder="Nome" 
                    value={nome} 
                    onChange={(e) => setNome(e.target.value)} 
                />
            </label>
            <label>
                Telefone:
                <input 
                    type="tel" 
                    placeholder="Telefone" 
                    value={telefone} 
                    onChange={(e) => setTelefone(e.target.value)} 
                />
            </label>
            <label>
                URL da Foto:
                <input 
                    type="url" 
                    placeholder="URL da Foto" 
                    value={fotoUrl} 
                    onChange={(e) => setFotoUrl(e.target.value)} 
                />
            </label>
            <label>
                Egresso/Convidado:
                <input 
                    type="checkbox" 
                    checked={egressoConvidado} 
                    onChange={() => setEgressoConvidado(!egressoConvidado)} 
                />
            </label>
            <label>
                Confirmado:
                <input 
                    type="checkbox" 
                    checked={confirmado} 
                    onChange={() => setConfirmado(!confirmado)} 
                />
            </label>
            <button type="submit">Cadastrar</button>
        </form>
    );
};

export default ParticipantForm;
