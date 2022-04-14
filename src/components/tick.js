import {useState} from 'react'

function Klick () {
    const [count,setCount] = useState(0)
    function decrementCount ()
    {
        setCount(preventCount => preventCount - 1)
     }
     function crementCount()
     {
         setCount(preventCount => preventCount+1)
     }
     return (
         <>
         <button onClick={decrementCount}> - </button>
         <span> {count} </span>
         <button onClick={crementCount}> + </button>
         </>

     )
}
export default Klick