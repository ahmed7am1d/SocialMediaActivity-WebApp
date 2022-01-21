import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';


function App() {

  //getting the data from our API 
  const [activities,setActivities] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/activities').then(response => {
      //just to see what is response 
      console.log(response);
      setActivities(response.data)
    })

  },[])

  //OUR DOM OR redering view content
  return (
    <div>

      <Header as='h2' icon='users' content="Reactivities"/>       
       <List>
       {activities.map((activity:any) => (
          <List.Item key={activity.id}>
            Activity Title: {activity.title}
          </List.Item>
         ))}
       </List>
         
      

       
    </div>
  );
}

export default App;
