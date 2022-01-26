import logo from './logo.svg';
import './App.css';
import { useState, useEffect } from 'react';
import axios from 'axios';

function duplicateCode1(z){
  // var x = 4;
  // var y = x < 5
  // return y == true;

  var x = 4;
  var y = x < 5
  return y == true;
}

function duplicateCode2(z){
  var x = 4;
  var y = x < 5
  return y == true;

  var x = 4;
  var y = x < 5
  return y == true;
}

function App() {
  const [apps, setApps] = useState([]);

  useEffect(() => {

    (async () => {
      const resp = await axios.get(process.env.REACT_APP_BASEURL + 'api/values');
      const data = await resp.data;

      setApps(data);
    })()


    return () => {

    }
  }, [])
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          {apps.map(app => (
            <div>{app}</div>
          ))}
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
