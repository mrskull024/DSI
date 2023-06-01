import React, { useState, useEffect } from 'react';
import axios from 'axios';
import Swal from 'sweetalert2';
import withReactContent from 'sweetalert2-react-content';
import { show_alert } from '../functions';
import { List } from 'reactstrap';

const Pagos =() =>{

    const urlPagos = "http://macadmin-001-site1.gtempurl.com/api/Pagos/PagosPorEstudiante";
    const headers = { 'Content-Type': 'application/json' };
    const request = { incluirInactivos: true };

    const [pagos, setpagos] = useState([]);
    const [id, setId] = useState(0);
    const [estado, setestado] = useState(false);
    const [idEstudiante, setidEstudiante] = useState('');
    const [numeroCarnet, setnumeroCarnet] = useState('');
    const [conceptoPago, setconceptoPago] = useState('');
    const [fechaPago, setfechaPago] = useState('');
    const [monedaPago, setmonedaPago] = useState('');
    const [descripcionMoneda, setdescripcionMoneda] = useState('');
    const [montoPago, setmontoPago] = useState('');

    

    useEffect(() => {
        getPagos();
    }, []);

    const getPagos = async () => {
        const apiResponse = await axios.post(urlPagos, request, headers);
        console.log(apiResponse.data);
        setpagos(apiResponse.data)
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
                                        Estado
                                    </th>
                                    <th>
                                        Id Estudiante
                                    </th>
                                    <th>
                                        Numero de Carnet
                                    </th>
                                    <th>
                                        Concepto Pago
                                    </th>
                                    <th>
                                        Fecha Pago
                                    </th>
                                    <th>
                                        Moneda Pago
                                    </th>
                                    <th>
                                        Descripcion
                                    </th>
                                    <th>
                                        Monto
                                    </th>
                                </tr>
                            </thead>
                            <tbody className='table-group-divider'>
                                {
                                    pagos.map((Pagos, id) => (
                                        <tr key={Pagos.id}>
                                            <td>{Pagos.estado}</td>
                                            <td>{Pagos.idEstudiante}</td>
                                            <td>{Pagos.numeroCarnet}</td>
                                            <td>{Pagos.conceptoPago}</td>
                                            <td>{Pagos.fechaPago}</td>
                                            <td>{Pagos.monedaPago}</td>
                                            <td>{Pagos.setdescripcionMoneda}</td>
                                            <td>{Pagos.montoPago}</td>
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

export default Pagos;