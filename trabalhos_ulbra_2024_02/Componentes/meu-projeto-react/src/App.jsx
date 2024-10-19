import './App.css';
import Header from './components/Header';
import CepCard from './components/CepCard';
import Entrevero from './components/Entrevero';

function App() {
  return (
    <>
      <Header />
      <div className="app-container">
        <CepCard />
        <Entrevero />
      </div>
    </>
  );
}

export default App;
