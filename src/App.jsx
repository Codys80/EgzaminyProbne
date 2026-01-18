import { useState, useRef } from 'react'
import 'bootstrap/dist/css/bootstrap.css'
import './App.css'

function App() {
  const [count, setCount] = useState(0)
  const selectRef = useRef();
  const inputRef = useRef();
  function handleButtonClick(){

    console.log("tytuł: " + inputRef.current.value); 
    console.log("rodzaj: " + selectRef.current.value); 
  }
  return (
    <form className='form form-control'>
      <p className='label form-label' htmlFor='title'>Tytuł filmu</p>
      <input className='input form-input'ref={inputRef} name='title' type='text'/>
      <p className='label form-label'htmlFor='type' >Rodzaj</p>
      <select ref={selectRef}  className='select form-select' name='type'>
        <option></option>
        <option value={1}>Komedia o wartości </option>
        <option value={2}>Obyczajowy o wartości </option>
        <option value={3}>Sensacyjny o wartośc</option>
        <option value={4}>Horror o wartości</option>
      </select>
      <button type='button' className='btn btn-primary' onClick={handleButtonClick}>Dodaj</button>
    </form>
  )
}

export default App
