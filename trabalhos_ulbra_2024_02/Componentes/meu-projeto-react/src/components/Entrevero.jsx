import React, { useState } from 'react';
import ParticipantForm from './ParticipanteForm';
import ParticipantList from './ParticipanteList';

const Entrevero = () => {
    const [participants, setParticipants] = useState([]);

    const handleAddParticipant = (newParticipant) => {
        setParticipants((prevParticipants) => {
            const updatedList = [...prevParticipants, newParticipant];
            return updatedList.sort((a, b) => a.nome.localeCompare(b.nome)); 
        });
    };

    return (
        <div className="entrevero-container">
            <h2>Cadastro para o Entrevero</h2>
            <div className="form-participant-container">
                <div className="form-container">
                    <ParticipantForm onAddParticipant={handleAddParticipant} />
                </div>
                <div className="participant-list-container">
                    <ParticipantList participants={participants} />
                </div>
            </div>
        </div>
    );
};

export default Entrevero;
