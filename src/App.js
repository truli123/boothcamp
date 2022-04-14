import { useState } from "react";
import React from 'react' // treba ako se zove klasa
import Header from './components/Header'
import Klick from './components/tick'
import UserForm from "./components/ContactForm.jsx";
import ContactForm from "./components/ContactForm.jsx";
import ContactList from "./components/ContactList.jsx";
import "./App.css";

function App() {
  const [contacts, updateContacts] = useState([]);
    const addContact = (contact) => {
    updateContacts([...contacts, contact]);
  };
  return (
    <div className="App">
    < Header/>
    <br></br>
    < Klick/>
    
        <ContactForm addContact={addContact} />
      <ContactList contacts={contacts} />
  
   </div>
  );
}
export default App;
/*
function Papp(){

class Papp extends React.Component
{
  render ()
  {
    return <h1> Dobrodošli uz pomoć  klase</h1>  }
  }
  export default Papp;

*/
