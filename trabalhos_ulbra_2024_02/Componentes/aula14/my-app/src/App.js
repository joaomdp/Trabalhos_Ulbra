import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import { DataProvider } from './data/DataContext';
import Pessoas from './pages/Pessoas';
import Header from './components/Header';
import Home from './pages/Home';
import Sobre from './pages/Sobre';
import Contato from './pages/Contato';

function App() {
  return (
    <DataProvider> 
      <Router>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/sobre" element={<Sobre />} />
          <Route path="/contato" element={<Contato />} />
          <Route path="/pessoas" element={<Pessoas />} />
        </Routes>
      </Router>
    </DataProvider>
  );
}

export default App;
