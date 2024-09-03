import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';
import store from './redux/store/store'; // Import your Redux store
import reportWebVitals from './reportWebVitals';
import { Provider } from 'react-redux'; // Import the Provider component

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    {/* Wrap the App component with the Provider and pass the store */}
    <Provider store={store}>
      <App />
    </Provider>
  </React.StrictMode>
);
