import React, { useState, useEffect } from 'react';
import axios from 'axios';

const AsignaturasPorEstudiante = () => {
    //necesario para el api
    const url = "http://macadmin-001-site1.gtempurl.com/api/Asignaturas/ListAsignaturasPorEstudiante";
    const headers = { 'Content-Type': 'application/json' };
    const request = { numeroCarnet: '2017-0505A' };

    const [asignaturas, setAsignaturas] = useState([]);

    useEffect(() => {
        getAsignaturasPorEstudiante();
    }, []);

    const getAsignaturasPorEstudiante = async () => {
        const apiResponse = await axios.post(url, request, headers);
        console.log('asignaturas por Estudiante=', apiResponse.data);
        setAsignaturas(apiResponse.data)
    }

    return (
        <div className='App'>
            <div className='container-fluid'>
                <div className='row mt-3'>
                    <div className='col-md-4 offset-md-4'>
                        <h5 style={{ textAlign: 'left' }} >Listado de asignaturas cursadas:</h5>
                    </div>
                </div>
                <div className='row mt-3'>
                    <div className='col-12 col-lg-10 offset-1'>
                        <div className='table responsive'>
                            <table className='table table-bordered'>
                                <thead>
                                    <tr>
                                        <th>
                                            #
                                        </th>
                                        <th>
                                            Numero Carnet
                                        </th>
                                        <th>
                                            Nombre
                                        </th>
                                        <th>
                                            Asignatura
                                        </th>
                                        <th>
                                            Estado
                                        </th>
                                        <th>
                                            Nota
                                        </th>
                                    </tr>
                                </thead>
                                <tbody className='table-group-divider'>
                                    {
                                        asignaturas.map((asignaturas) => (
                                            <tr key={asignaturas.id}>
                                                <td>{asignaturas.id}</td>
                                                <td>{asignaturas.numeroCarnet}</td>
                                                <td>{asignaturas.nombreEstudiante}</td>
                                                <td>{asignaturas.descripcionAsignatura}</td>
                                                <td>{asignaturas.estadoAsignatura}</td>
                                                <td>{asignaturas.nota}</td>
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

export default AsignaturasPorEstudiante;