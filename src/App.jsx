import { useState, useRef } from 'react'
import 'bootstrap/dist/css/bootstrap.css'
import './App.css'

function App() {
  const [film, setFilm] = useState([
    { id: 1, tytul: "Deszcz", plik: "deszcz.mp4", polubienia: 5, wyswietlenia: 10, autor: 'maciek544' },
    { id: 2, tytul: "Słoneczna plaża", plik: "plaza.mp4", polubienia: 3, wyswietlenia: 6, autor: 'jacek55' },
    { id: 3, tytul: "Fale morza", plik: "morze.mp4", polubienia: 5, wyswietlenia: 8, autor: '_.joasia._' },
    { id: 4, tytul: "Samochód", plik: "samochod.mp4", polubienia: 20, wyswietlenia: 45, autor: 'mareczek_51' },
    { id: 5, tytul: "Ptak i śnieg", plik: "ptak.mp4", polubienia: 8, wyswietlenia: 24, autor: 'marysia_284' },
])
  const [filmDisplay, setFilmDisplay] = useState(0)
  const myRef = useRef();
  async function handleLikeButton(){
    console.log(filmDisplay);
    setFilm(prev =>
      prev.map(f =>
        f.id === filmDisplay+1
          ? { ...f, polubienia: f.polubienia + 1 }
          : f
      )
    );
   }
  function handleSelectButton(index) {
  setFilmDisplay(index);

  setFilm(prev =>
    prev.map((f, i) =>
      i === index
        ? { ...f, wyswietlenia: f.wyswietlenia + 1 }
        : f
    )
  );
}
  return (
    <>
      <div className='row main'>
        <div className='col-lg float-start'>
          <video controls autoPlay width="100%" key={film[filmDisplay].plik} > 
            <source src = {"./public/" + film[filmDisplay].plik} ></source>
          </video>
          <h2>{film[filmDisplay].tytul}</h2>
          <p>Dodany przez: {film[filmDisplay].autor}, polubień: {film[filmDisplay].polubienia}, wyświetleń: {film[filmDisplay].wyswietlenia}</p>
          <p> <button className='btn btn-info' onClick={handleLikeButton}>Lubię to</button> </p>
        </div>
        <div className='col-lg float-end'>
          <h2>Zobacz też inne filmy</h2>
          {film.map((f) =>  (
            <div key={f.id} className='card mb-3'>
              <button className='btn btn-success' onClick={() => handleSelectButton(f.id-1)}>{f.tytul}</button>
              </div>))}
        </div>
      </div>
    </>
  )
}

export default App