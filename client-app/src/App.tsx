
import { useEffect, useState } from 'react'
import './App.css'
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {
  const [clothingitems, setClothingitems] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/clothingitems')
      .then(response => {
        setClothingitems(response.data)
      })
  }, [])
  return (
    <div>
      <Header as='h2' icon='users' content='Outfitting'></Header>
      <List>
        {clothingitems.map((clothingitem: any) => (
          <List.Item key={clothingitem.id}>
            {clothingitem.title}
          </List.Item>
        ))}
      </List>
    </div>
   
  )
}

export default App
