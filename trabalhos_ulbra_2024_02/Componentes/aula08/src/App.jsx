import './styles.css';
import ImageSlider from './components/ImageSlider';
import Title from './components/Title.jsx';
import pinguin1 from '../src/assets/pinguin-1.jpg';
import pinguin2 from '../src/assets/pinguin-2.jpg';
import pinguin3 from '../src/assets/pinguin-3.jpg';
import pinguin4 from '../src/assets/pinguin-4.jpg';
import pinguin5 from '../src/assets/pinguin-5.jpg';

function App() {
  const slides = [
    pinguin1,
    pinguin2,
    pinguin3,
    pinguin4,
    pinguin5,
  ];

  return (
    <div className='container'>
      <Title text='Pinguins' />
      <ImageSlider slides={slides} />
    </div>
  );
}

export default App;
