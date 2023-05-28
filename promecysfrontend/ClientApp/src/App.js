//import React, { Component } from 'react';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import PerfilEstudiante from './components/PerfilEstudiante';
//import AppRoutes from './AppRoutes';
//import { Layout } from './components/Layout';
//import './custom.css';

//export default class App extends Component {
//  static displayName = App.name;

//  render() {
//    return (
//      <Layout>
//        <Routes>
//          {AppRoutes.map((route, index) => {
//            const { element, ...rest } = route;
//            return <Route key={index} {...rest} element={element} />;
//          })}
//        </Routes>
//      </Layout>
//    );
//  }
//}

function App() {
    return (
        <BrowserRouter>
            <Routes>
                <Route path='/' element={<PerfilEstudiante></PerfilEstudiante>}>
                </Route>
            </Routes>
        </BrowserRouter>
    )
}

export default App;
