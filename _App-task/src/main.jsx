import React from "react";
import ReactDOM from "react-dom/client";
import { Provider } from "react-redux";
import { BrowserRouter } from "react-router-dom";
import TaskManagment from "./TaskManagment";
import "./assets/index.css";
import { store } from "./store";
import { ToastContainer } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

ReactDOM.createRoot(document.getElementById("root")).render(
  <React.StrictMode>
    <Provider store={store}>
      <BrowserRouter>
        <TaskManagment />
        <ToastContainer />
      </BrowserRouter>
    </Provider>
  </React.StrictMode>
);
