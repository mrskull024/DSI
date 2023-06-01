import React, { useState, useEffect } from 'react';
import axios from 'axios';
import Swal from 'sweetalert2';
import withReactContent from 'sweetalert2-react-content';
import { show_alert } from '../functions';
import { List } from 'reactstrap';

const ListaEstudiantes =() =>{

    const urlListaEstudiante = "http://macadmin-001-site1.gtempurl.com/api/Estudiante/ListEstudiantes";
    const urlCreateEstudiante = "http://macadmin-001-site1.gtempurl.com/api/Estudiante/CreateEstudiante";
    const urlGetEstudiante = "http://macadmin-001-site1.gtempurl.com/api/Estudiante/GetEstudiante";
    const urlUpdateEstudiante = "http://macadmin-001-site1.gtempurl.com/api/Estudiante/UpdateEstudiante";
    const headers = { 'Content-Type': 'application/json' };
    const request = { incluirInactivos: true };

    const [estudiante, setEstudiante] = useState([]);
    const [id, setId] = useState(0);
    const [primerNombre, setPrimerNombre] = useState('');
    const [segundoNombre, setSegundoNombre] = useState('');
    const [primerApellido, setprimerApellido] = useState('');
    const [segundoApellido, setsegundoApellido] = useState('');
    const [numeroCarnet, setnumeroCarnet] = useState('');

    useEffect(() => {
        getListaEstudiante();
    }, []);

    const getListaEstudiante = async () => {
        const apiResponse = await axios.post(urlListaEstudiante, request, headers);
        console.log(apiResponse.data);
        setEstudiante(apiResponse.data)
    }

    return(
        
        <div className='App'>
        <div className='container-fluid'>
            <div className='row mt-3'>
                <div className='col-md-4 offset-md-4'>
                    <div className='d-grid mx-auto'>
                        
                    </div>
                </div>
            </div>
            <div className='row mt-3'>
                <div className='col-12 col-lg-8 offset-0 offset-lg-2'>
                    <div className='table responsive'>
                        <table className='table table-bordered'>
                            <thead>
                                <tr>
                                    <th>
                                        ID
                                    </th>
                                    <th>
                                        Primer Nombre
                                    </th>
                                    <th>
                                        Segundo Nombre
                                    </th>
                                    <th>
                                        Apellido
                                    </th>
                                    <th>
                                        Segundo Apellido
                                    </th>
                                    <th>
                                        Numero Carnet
                                    </th>
                                </tr>
                            </thead>
                            <tbody className='table-group-divider'>
                                {
                                    estudiante.map((listaestudiantes) => (
                                        <tr key={listaestudiantes.id}>
                                            <td>{listaestudiantes.id}</td>
                                            <td>{listaestudiantes.primerNombre}</td>
                                            <td>{listaestudiantes.segundoNombre}</td>
                                            <td>{listaestudiantes.primerApellido}</td>
                                            <td>{listaestudiantes.setsegundoApellido}</td>
                                            <td>{listaestudiantes.numeroCarnet}</td>
                                        </tr>
                                    ))
                                }
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>

        </div>
        </div>


    )
}

export default ListaEstudiantes;