import { Link } from 'react-router-dom';

function Header() {
    return (
        <header style={{ display: 'flex', justifyContent: 'center', gap: '15px', padding: '10px', backgroundColor: '#f8f9fa' }}>
            <Link to="/">Home</Link>
            <Link to="/pessoas">Pessoas</Link>
            <Link to="/sobre">Sobre</Link>
            <Link to="/contato">Contato</Link>
        </header>
    );
}

export default Header;
