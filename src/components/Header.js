import Button from './Button'
import PropTypes from 'prop-types'

const Header = ({title}) => {
  return (
    <header className='header'>
      <h1>{title}</h1>
      <Button color='green' text ='Hello' />
      <Button color='red' text ='whats' />
      <Button color='purple' text ='up?' />
    </header>
    
  )
}

export default Header