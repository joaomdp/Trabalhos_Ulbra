import React from 'react';

const ParticipantCard = ({ participant }) => {
    if (!participant) {
        return <div>Participante não encontrado.</div>;
    }

    const { fotoUrl, nome, telefone, egressoConvidado, confirmado } = participant;

    return (
        <div className="card">
            <img src={fotoUrl} alt={`${nome}'s Foto`} style={{ width: '100px', height: '100px', borderRadius: '50%' }} />
            <div>
                <h3>{nome}</h3>
                <p>Telefone: {telefone}</p>
                <p>{egressoConvidado ? 'Egresso/Convidado' : 'Estudante'}</p>
                <p>{confirmado ? 'Confirmado' : 'Não Confirmado'}</p>
            </div>
        </div>
    );
};

export default ParticipantCard;
