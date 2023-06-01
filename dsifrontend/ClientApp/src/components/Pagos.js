import React, { useState, useEffect } from 'react';
import moment from 'moment';
import axios from 'axios';

const Pagos = () => {
    //necesario para el api
    const url = "http://macadmin-001-site1.gtempurl.com/api/Pagos/PagosPorEstudiante";
    const headers = { 'Content-Type': 'application/json' };
    const request = { numeroCarnet: '2017-0505A' };

    const [pagos, setPagos] = useState([]);

    useEffect(() => {
        getPagosPorEstudiante();
    }, []);

    const getPagosPorEstudiante = async () => {
        const apiResponse = await axios.post(url, request, headers);
        console.log('pagos=', apiResponse.data);
        setPagos(apiResponse.data)
    }

    return (
        <div className='App'>
            <div className='container-fluid'>
                <div className='row mt-3'>
                    <div className='col-md-4 offset-md-4'>
                        <h5 style={{ textAlign: 'left' }} >Listado de pagos realizados:</h5>
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
                                            No. Carnet
                                        </th>
                                        <th>
                                            Concepto
                                        </th>
                                        <th>
                                            Monto
                                        </th>
                                        <th>
                                            Moneda
                                        </th>
                                        <th>
                                            Fecha de Pago
                                        </th>
                                    </tr>
                                </thead>
                                <tbody className='table-group-divider'>
                                    {
                                        pagos.map((payments) => (
                                            <tr key={payments.id}>
                                                <td>{payments.id}</td>
                                                <td>{payments.numeroCarnet}</td>
                                                <td>{payments.conceptoPago}</td>
                                                <td>{payments.montoPago}</td>
                                                <td>{payments.monedaPago + ' - ' + payments.descripcionMoneda}</td>
                                                <td>{moment(payments.fechaPago).format('DD-MM-YYYY')}</td>
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