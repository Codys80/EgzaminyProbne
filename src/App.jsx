import { useState, useRef } from 'react'
import 'bootstrap/dist/css/bootstrap.css'
import './App.css'

function App() {
  const [photo, setPhoto] = useState([    
    {id: 0, alt: "Mak", filename: "obraz1.jpg", category:1, downloads: 35},
    {id: 1, alt:"Bukiet", filename: "obraz2.jpg", category: 1, downloads: 43},
    {id: 2, alt:"Dalmatyńczyk", filename: "obraz3.jpg", category:2, downloads: 2},
    {id: 3, alt:"Świnka morska", filename: "obraz4.jpg", category:2, downloads: 53},
    {id: 4, alt:"Rotwailer", filename: "obraz5.jpg", category:2, downloads: 43},
    {id: 5, alt:"Audi", filename: "obraz6.jpg", category:3, downloads: 11},
    {id: 6, alt:"kotki", filename: "obraz7.jpg", category:2, downloads: 22},
    {id: 7, alt:"Róża", filename: "obraz8.jpg", category:1, downloads: 33},
    {id: 8, alt:"Świnka morska", filename: "obraz9.jpg", category:2, downloads: 123},
    {id: 9, alt:"Foksterier", filename: "obraz10.jpg", category:2, downloads: 22},
    {id: 10, alt:"Szczeniak", filename: "obraz11.jpg", category:2, downloads: 12},
    {id: 11, alt:"Garbus", filename: "obraz12.jpg", category:3, downloads: 321}])
    const [categoryStatus, setCategoryStatus] = useState([true, true, true])
   
    function handleDownloadButton(index){
        var newDownloads = photo[index].downloads + 1;
        const newPhoto = photo.map(photo => {
        if (photo.id === index) {
            return { ...photo, downloads: newDownloads };
        }
        return photo;
        });
        setPhoto(newPhoto);
    }
    function handleCheck(category){
      setCategoryStatus(prevState => 
          prevState.map((item, idx) => idx === category ? !item : item)
        );  
    }
    function displayPhoto(id){
      return(
      <div key={id} className = "float-start">
          <img src={photo[id].filename} style={ {margin: '5px'} }/>
          <h4>Liczba pobrań: {photo[id].downloads}</h4>
          <button id={photo[id].id} className='btn btn-success' onClick={() => handleDownloadButton(id)}>Pobierz</button>
      </div>
      );
    }
  return (
    <div className='row'>
      <div>
      <h1>Kategoria zdjęć</h1>
      <div className='form-check form-switch float-start'>
        <input  name='flowers' value={1} className='input form-check-input' type='checkbox' onClick={() => handleCheck(0)}/>
        <label htmlFor='flowers'>Kwiaty </label>
      </div>
      <div className='form-check form-switch float-start'>
        <input  name='animals' value={2} className='form-check-input' type='checkbox' onClick={() => handleCheck(1)}/>
        <label htmlFor='animals'>Zwierzęta </label>
      </div>
      <div className='form-check form-switch float-start'>
        <input   name='cars' value={3} className='input form-check-input' type='checkbox' onClick={() => handleCheck(2)}/>
        <label htmlFor='cars'>Samochody </label>
      </div>
      </div>
      <div className='col'>
      {photo.map( (photo, index) => (
        categoryStatus[photo.category - 1] ? displayPhoto(index) : null
      ))}
      </div>
    </div>
  )
}

export default App