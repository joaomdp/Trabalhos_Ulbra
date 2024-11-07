
import { Link } from 'react-router-dom';

function Header({ title }) {
    return (
        <>
            <nav>
                <Link to="/">Home</Link>
                <Link to="/sobre">Sobre</Link>
            </nav>
            <h1>{title}</h1>
        </>
    )
}

export default Header;