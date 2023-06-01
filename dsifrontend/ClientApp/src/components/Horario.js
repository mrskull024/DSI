import React, { useState, useEffect } from 'react';
import axios from 'axios';
import Swal from 'sweetalert2';
import withReactContent from 'sweetalert2-react-content';
import { show_alert } from '../functions';

const PerfilEstudiante = () => {
    //necesario para el api
    const urlHorarios = "http://macadmin-001-site1.gtempurl.com/api/Horarios/ListHorarios";
    const urlCreateHorario = "http://macadmin-001-site1.gtempurl.com/api/Horarios/CreateHorario";
    const urlPutHorario = "http://macadmin-001-site1.gtempurl.com/api/Horarios/UpdateHorario";
    const urlDeleteHorario = "http://macadmin-001-site1.gtempurl.com/api/Horarios/DeleteHorario";
    const headers = { 'Content-Type': 'application/json' };
    const request = { incluirInactivos: true };

    const [horarios, setHorarios] = useState([]);
    const [id, setId] = useState(0);
    const [nombre, setNombre] = useState('');
    const [horaInicio, setHoraInicio] = useState('');
    const [horaFin, setHoraFin] = useState('');
    const [estado, setEstado] = useState(false);
    const [operation, setOperation] = useState(1);
    const [title, setTitle] = useState('');

    useEffect(() => {
        getHorarios();
    }, []);

    const getHorarios = async () => {
        const apiResponse = await axios.post(urlHorarios, request, headers);
        console.log(apiResponse.data);
        setHorarios(apiResponse.data)
    }

    const openModal = (opcion, id, nombre, horaInicio, horaFin, estado) => {
        setId(0);
        setNombre('');
        setHoraInicio('');
        setHoraFin('');
        setEstado(false);
        setOperation(opcion);
        console.info('opcion modal', opcion);

        if (opcion === 1) {
            //console.info('Legue a opcion1');
            setTitle('Agregar Horario');

        }
        else if (opcion === 2) {
            //console.info('Legue a opcion2', 'params:', id, nombre, horaInicio, horaFin, estado);
            setTitle('Editar Horario');
            setId(id);
            setNombre(nombre);
            setHoraInicio(horaInicio);
            setHoraFin(horaFin);
            setEstado(estado);
        }

        window.setTimeout(function () {
            document.getElementById('nombre').focus();
        }, 500);
    }

    const validarForm = () => {
        let parameter;
        let method;
        let op;

        if (nombre.trim() === '') {
            show_alert('Digital el nombre del horario', 'warning');
        }
        else if (horaInicio.trim() === '') {
            show_alert('Digital la hora de inicio del horario', 'warning');
        }
        else if (horaFin.trim() === '') {
            show_alert('Digital la hora de finalizacion del horario', 'warning');
        }
        else {
            if (operation === 1) {
                parameter = { nombre: nombre.trim(), horaInicio: horaInicio.trim(), horaFin: horaFin.trim(), estado: true };
                method = 'POST';
                op = 1;
            }
            else {
                parameter = { id: id, nombre: nombre.trim(), horaInicio: horaInicio.trim(), horaFin: horaFin.trim(), estado: true };
                method = 'PUT';
                op = 2;
            }

            console.info('parametros a enviar: ', method, parameter, op);
            sendRequest(method, parameter, op);
        }

    }

    const sendRequest = async (method, parameter, operation) => {
        console.log(operation);
        if (operation === 1) {
            console.log('create');
            await axios({ method: method, url: urlCreateHorario, data: parameter }).then(function (response) {
                let type = response.status;
                let message = 'Horario creado exitosamente';

                show_alert(message, 'info');

                if (type === 200) {
                    document.getElementById('btnCerrar').click();
                    getHorarios();
                }
            }).catch(function (error) {
                show_alert('Error al procesar la solicitud', 'error');
                console.error(error);
            });
        }

        if (operation === 2) {
            console.log('update');
            console.info('data:', method, urlPutHorario, parameter);
            await axios({ method: method, url: urlPutHorario, data: parameter }).then(function (response) {
                let type = response.status;
                let message = 'Horario actualizado exitosamente';

                show_alert(message, 'info');

                if (type === 200) {
                    document.getElementById('btnCerrar').click();
                    getHorarios();
                }
            }).catch(function (error) {
                show_alert('Error al procesar la solicitud', 'error');
                console.error(error);
            });
        }

        if (operation === 3) {
            console.log('delete');
            console.info('data:', method, urlDeleteHorario, parameter);
            await axios({ method: method, url: urlDeleteHorario, data: parameter }).then(function (response) {
                let type = response.status;
                let message = 'Horario dado de baja exitosamente';

                show_alert(message, 'info');

                if (type === 200) {
                    document.getElementById('btnCerrar').click();
                    getHorarios();
                }
            }).catch(function (error) {
                show_alert('Error al procesar la solicitud', 'error');
                console.error(error);
            });
        }

    }

    const deleteProduct = (id, nombre, horaInicio, horaFin, estado) => {
        const MySwal = withReactContent(Swal);
        MySwal.fire({
            title: 'Esta seuguro de eliminar el horario: ' + nombre + ' ?',
            icon: 'question',
            text: 'el cambio es irreversible',
            showCancelButton: true,
            confirmButtonText: 'Si, Eliminar',
            cancelButtonText: 'Cancelar'
        }).then((result) => {
            if (result.isConfirmed) {
                setId(id);
                let method = 'PUT';
                sendRequest(method, { id: id, nombre: nombre, horaInicio: horaInicio, horaFin: horaFin, estado: estado }, 3);
            }
            else {
                show_alert('El horario no se dio de baja', 'info');
            }
        });
    }

    return (
        <div className='App'>
            <div className='container-fluid'>
                <div className='row mt-3'>
                    <div className='col-md-4 offset-md-4'>
                        <div className='d-grid mx-auto'>
                            <button onClick={() => openModal(1)} className='btn btn-dark' data-bs-toggle='modal' data-bs-target='#modalHorarios'>
                                <i className='fa-solid fa-circle-plus'></i>Agregar Horario
                            </button>
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
                                            #
                                        </th>
                                        <th>
                                            Nombre
                                        </th>
                                        <th>
                                            Hora Inicio
                                        </th>
                                        <th>
                                            Hora Fin
                                        </th>
                                        <th>
                                            Estado
                                        </th>
                                    </tr>
                                </thead>
                                <tbody className='table-group-divider'>
                                    {
                                        horarios.map((horario) => (
                                            <tr key={horario.id}>
                                                <td>{horario.id}</td>
                                                <td>{horario.nombre}</td>
                                                <td>{horario.horaInicio}</td>
                                                <td>{horario.horaFin}</td>
                                                <td>{String(horario.estado)}</td>
                                                <td>
                                                    <button onClick={() => openModal(2, horario.id, horario.nombre, horario.horaInicio, horario.horaFin, horario.estado)}
                                                        className='btn btn-warning' data-bs-toggle='modal' data-bs-target='#modalHorarios'>
                                                        <i className='fa-solid fa-edit'></i>
                                                    </button>
                                                    &nbsp;
                                                    <button onClick={() => deleteProduct(horario.id, horario.nombre, horario.horaInicio, horario.horaFin, false)}
                                                        className='btn btn-danger'>
                                                        <i className='fa-solid fa-trash'></i>
                                                    </button>
                                                </td>
                                            </tr>
                                        ))
                                    }
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>

            </div>
            <div id='modalHorarios' className='modal fade' aria-hidden='true'>
                <div className='modal-dialog'>
                    <div className='modal-content'>
                        <div className='modal-header'>
                            <label className='h5'>{title}</label>
                            <button type='button' className='btn-close' data-bs-dismiss='modal' aria-label='close'></button>
                        </div>
                        <div className='modal-body'>
                            <input type='hidden' id='id'></input>
                            <div className='input-group mb-3'>
                                <span className='input-group-text'><i className='fa-solid fa-comment'></i></span>
                                <input type='text' id='nombre' className='form-control'
                                    placeholder='Nombre' value={nombre} onChange={(e) => setNombre(e.target.value)}>
                                </input>
                            </div>
                            <div className='input-group mb-3'>
                                <span className='input-group-text'><i className='fa-solid fa-calendar'></i></span>
                                <input type='text' id='horaInicio' className='form-control'
                                    placeholder='Hora de Inicio' value={horaInicio} onChange={(e) => setHoraInicio(e.target.value)}>
                                </input>
                            </div>
                            <div className='input-group mb-3'>
                                <span className='input-group-text'><i className='fa-solid fa-calendar'></i></span>
                                <input type='text' id='horaFin' className='form-control'
                                    placeholder='Hora de Fin' value={horaFin} onChange={(e) => setHoraFin(e.target.value)}>
                                </input>
                            </div>
                            <div className='input-group mb-3'>
                                <span className='input-group-text'><i className='fa-solid fa-plus'></i></span>
                                <select className='form-control' placeholder='Estado'
                                    id='estado' onChange={(e) => setEstado(e.target.value)}>
                                    <option value={true}>Activo</option>
                                    <option value={false}>No Activo</option>
                                </select>
                            </div>
                            <div className='d-grid col-6 mx-auto'>
                                <button onClick={() => validarForm()} className='btn btn-success'>
                                    <i className='fa-solid fa-floppy-disk'></i> Guardar
                                </button>
                            </div>
                        </div>
                        <div className='modal-footer'>
                            <button id='btnCerrar' type='button' className='btn btn-secondary' data-bs-dismiss='modal'>Cerrar</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default PerfilEstudiante;