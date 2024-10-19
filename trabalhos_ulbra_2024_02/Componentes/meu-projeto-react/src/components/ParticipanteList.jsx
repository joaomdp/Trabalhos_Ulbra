import React from 'react';
import ParticipantCard from './ParticipanteCard';

const ParticipantList = ({ participants }) => {
    return (
        <div className="participant-list">
            {participants.map((participant, index) => (
                <ParticipantCard key={index} participant={participant} />
            ))}
        </div>
    );
};

export default ParticipantList;
