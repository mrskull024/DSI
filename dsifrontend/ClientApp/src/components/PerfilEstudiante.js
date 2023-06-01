import React, { useState, useEffect } from 'react';
import moment from 'moment';
import axios from 'axios';

const PerfilEstudiante = () => {
    //necesario para el api
    const headers = { 'Content-Type': 'application/json' };
    const request = { incluirDesactivados: true };
    const urlEstudiante = "http://macadmin-001-site1.gtempurl.com/api/Estudiante/GetEstudiante?numeroCarnet=2017-0505A";
    const urlGeneros = "http://macadmin-001-site1.gtempurl.com/api/Catalogos/ListarGeneros";
    const urlEstadosCiviles = "http://macadmin-001-site1.gtempurl.com/api/Catalogos/ListarEstadoCivil";
    const urlColegios = "http://macadmin-001-site1.gtempurl.com/api/Catalogos/ListarEscuelas";
    const urlEstadoLaboral = "http://macadmin-001-site1.gtempurl.com/api/Catalogos/ListarEstadoLaboral";
    const urlDepartamentos = "http://macadmin-001-site1.gtempurl.com/api/Catalogos/ListarDepartamentos";
    const urlMunicipios = "http://macadmin-001-site1.gtempurl.com/api/Catalogos/ListarMunicipios";
    const urlTiposEstudiante = "http://macadmin-001-site1.gtempurl.com/api/Catalogos/ListarTipoEstudiante";

    const [estudiante, setEstudiante] = useState([]);
    const [generos, setGeneros] = useState([]);
    const [estadosCiviles, setEstadosCiviles] = useState([]);
    const [colegiosSecundaria, setColegiosSecundaria] = useState([]);
    const [estadosLaborales, setEstadosLaborales] = useState([]);
    const [departamentos, setDepartamentos] = useState([]);
    const [municipios, setMunicipios] = useState([]);
    const [tiposEstudiantes, setTiposEstudiante] = useState([]); 

    //informacion personal
    const [primerNombre, setPrimerNombre] = useState('');
    const [segundoNombre, setSegundoNombre] = useState('');
    const [primerApellido, setPrimerApellido] = useState('');
    const [segundoApellido, setSegundoApellido] = useState('');
    const [numeroIdentificacion, setNumeroIdentificacion] = useState('');
    const [numeroCarnet, setNumeroCarnet] = useState('');
    const [fechaNacimiento, setFechaNacimiento] = useState('');
    const [edad, setEdad] = useState(0);
    const [genero, setGenero] = useState(0);
    const [estadoCivil, setEstadoCivil] = useState(0);
    //informacion de contacto
    const [celular, setCelular] = useState('');
    const [numeroTelefonico, setNumeroTelefonico] = useState('');
    const [correo, setCorreo] = useState('');
    const [fechaIngreso, setFechaIngreso] = useState('');
    const [direccion, setDireccion] = useState('');
    //informacion adicional
    const [secundaria, setSecundaria] = useState(0);
    const [estadoLaboral, setEstadoLaboral] = useState(0);
    const [tipoEstudiante, setTipoEstudiante] = useState(0);
    const [departamento, setDepartamento] = useState(0);
    const [municipio, setMunicipio] = useState(0);


    useEffect(() => {
        getEstudiante();
        getGeneros();
        getEstadosCiviles();
        getEscuelas();
        getEstadosLaborales();
        getDepartamentos();
        getMunicipios();
        getTiposEstudiante();
    }, []);

    const getEstudiante = async () => {
        await axios
            .get(urlEstudiante)
            .then(function (response) {
                console.log('estudiante=', response.data);
                setEstudiante(response.data);
                setPrimerNombre(response.data.primerNombre);
                setSegundoNombre(response.data.segundoNombre);
                setPrimerApellido(response.data.primerApellido);
                setSegundoApellido(response.data.segundoApellido);
                setNumeroIdentificacion(response.data.numeroIdentificacion);
                setNumeroCarnet(response.data.numeroCarnet);
                setFechaNacimiento(response.data.fechaNacimiento);
                setEdad(response.data.edad);
                setGenero(response.data.genero);
                setEstadoCivil(response.data.estadoCivil);
                setCelular(response.data.celular);
                setNumeroTelefonico(response.data.numeroTelefonico);
                setCorreo(response.data.correo);
                setDireccion(response.data.direccion);
                setFechaIngreso(response.data.fechaIngreso);
                setSecundaria(response.data.secundaria);
                setEstadoLaboral(response.data.correo);
                setTipoEstudiante(response.data.tipoEstudiante);
                setDepartamento(response.data.departamento);
                setMunicipio(response.data.municipio);
            });
    }

    const getGeneros = async () => {
        const apiResponse = await axios.post(urlGeneros, request, headers);
        console.log('generos=', apiResponse.data);
        setGeneros(apiResponse.data)
    }

    const getEstadosCiviles = async () => {
        const apiResponse = await axios.post(urlEstadosCiviles, request, headers);
        console.log('estados civiles=', apiResponse.data);
        setEstadosCiviles(apiResponse.data)
    }

    const getEscuelas = async () => {
        const apiResponse = await axios.post(urlColegios, request, headers);
        console.log('colegios=', apiResponse.data);
        setColegiosSecundaria(apiResponse.data)
    }

    const getEstadosLaborales = async () => {
        const apiResponse = await axios.post(urlEstadoLaboral, request, headers);
        console.log('estados laborales=', apiResponse.data);
        setEstadosLaborales(apiResponse.data)
    }

    const getDepartamentos = async () => {
        const apiResponse = await axios.post(urlDepartamentos, request, headers);
        console.log('departamentos=', apiResponse.data);
        setDepartamentos(apiResponse.data)
    }

    const getMunicipios = async () => {
        const apiResponse = await axios.post(urlMunicipios, request, headers);
        console.log('municipios=', apiResponse.data);
        setMunicipios(apiResponse.data)
    }

    const getTiposEstudiante = async () => {
        const apiResponse = await axios.post(urlTiposEstudiante, request, headers);
        console.log('tipo Estudiante=', apiResponse.data);
        setTiposEstudiante(apiResponse.data)
    }

    return (
        <div className='App'>
            <form id='formEstudiante'>
                <div className='row'>
                    <h3 className='form-label'>Informacion Personal de: {primerNombre + ' ' + segundoNombre + ' ' + primerApellido + ' ' + segundoApellido}</h3>
                    <div className='col-6'>
                        <label className='form-label'>Primer Nombre</label>
                        <input type='text' className='form-control' name='pNombre' value={primerNombre} disabled>
                        </input>
                    </div>
                    <div className='col-6'>
                        <label className='form-label'>Segundo Nombre</label>
                        <input type='text' className='form-control' name='sNombre' value={segundoNombre} disabled>
                        </input>
                    </div>
                    <div className='col-6'>
                        <label className='form-label'>Primer Apellido</label>
                        <input type='text' className='form-control' name='pApellido' value={primerApellido} disabled>
                        </input>
                    </div>
                    <div className='col-6'>
                        <label className='form-label'>Segundo Apellido</label>
                        <input type='text' className='form-control' name='sApellido' value={segundoApellido} disabled>
                        </input>
                    </div>
                    <div className='col-6'>
                        <label className='form-label'>Cedula de identidad</label>
                        <input type='text' className='form-control' name='cedula' value={numeroIdentificacion} disabled>
                        </input>
                    </div>
                    <div className='col-6'>
                        <label className='form-label'>Numero de carnet</label>
                        <input type='text' className='form-control' name='carnet' value={numeroCarnet} disabled>
                        </input>
                    </div>
                    <div className='col-6'>
                        <label className='form-label'>Fecha de Nacimiento</label>
                        <input type='text' className='form-control' name='fechaNac' value={moment(fechaNacimiento).format('DD-MM-YYYY')} disabled>
                        </input>
                    </div>
                    <div className='col-6'>
                        <label className='form-label'>Edad</label>
                        <input type='text' className='form-control' name='edad' value={edad + ' anios'} disabled>
                        </input>
                    </div>
                    <div className='col-6'>
                        <label className='form-label'>Genero</label>
                        <select className='form-control' onChange={e => e.target.value} value={genero} disabled>
                            {
                                generos.map((generos) => <option key={generos.id}>{generos.descripcion}</option>)
                            }
                        </select>
                    </div>
                    <div className='col-6'>
                        <label className='form-label'>Estado Civil</label>
                        <select className='form-control' onChange={e => e.target.value} value={estadoCivil} disabled>
                            {
                                estadosCiviles.map((estadosCiviles) => <option key={estadosCiviles.id}>{estadosCiviles.descripcion}</option>)
                            }
                        </select>
                    </div>

                </div>
                <br />
                <div className='row'>
                    <h3 className='form-label'>Informacion de contacto:</h3>
                    <div className='col-3'>
                        <label className='form-label'>Celular</label>
                        <input type='text' className='form-control' name='celular' value={celular} disabled>
                        </input>
                    </div>
                    <div className='col-3'>
                        <label className='form-label'>Telefono</label>
                        <input type='text' className='form-control' name='telefono' value={numeroTelefonico} disabled>
                        </input>
                    </div>
                    <div className='col-3'>
                        <label className='form-label'>Correo</label>
                        <input type='text' className='form-control' name='correo' value={correo} disabled>
                        </input>
                    </div>
                    <div className='col-3'>
                        <label className='form-label'>Fecha de Ingreso</label>
                        <input type='text' className='form-control' name='fechaIngreso' value={moment(fechaIngreso).format('DD-MM-YYYY')} disabled>
                        </input>
                    </div>
                    <div className='col-6'>
                        <label className='form-label'>Direccion</label>
                        <input type='text' className='form-control' name='direccion' value={direccion} disabled>
                        </input>
                    </div>
                </div>
                <br />
                <div className='row'>
                    <h3 className='form-label'>Informacion adicional:</h3>
                    <div className='col-4'>
                        <label className='form-label'>Tipo colegio secundaria</label>
                        <select className='form-control' onChange={e => e.target.value} value={secundaria} disabled>
                            {
                                colegiosSecundaria.map((colegiosSecundaria) => <option key={colegiosSecundaria.id}>{colegiosSecundaria.descripcion}</option>)
                            }
                        </select>
                    </div>
                    <div className='col-4'>
                        <label className='form-label'>Estado Laboral</label>
                        <select className='form-control' onChange={e => e.target.value} value={estadoLaboral} disabled>
                            {
                                estadosLaborales.map((estadosLaborales) => <option key={estadosLaborales.id}>{estadosLaborales.descripcion}</option>)
                            }
                        </select>
                    </div>
                    <div className='col-4'>
                        <label className='form-label'>Tipo Estudiante</label>
                        <select className='form-control' onChange={e => e.target.value} value={tipoEstudiante} disabled>
                            {
                                tiposEstudiantes.map((tiposEstudiantes) => <option key={tiposEstudiantes.id}>{tiposEstudiantes.descripcion}</option>)
                            }
                        </select>
                    </div>
                    <div className='col-4'>
                        <label className='form-label'>Departamento origen</label>
                        <select className='form-control' onChange={e => e.target.value} value={departamento} disabled>
                            {
                                departamentos.map((departamentos) => <option key={departamentos.id}>{departamentos.departamento}</option>)
                            }
                        </select>
                    </div>
                    <div className='col-4'>
                        <label className='form-label'>Municipio</label>
                        <select className='form-control' onChange={e => e.target.value} value={municipio} disabled>
                            {
                                municipios.map((municipios) => <option key={municipios.id}>{municipios.municipio}</option>)
                            }
                        </select>
                    </div>
                </div>
                <br />
            </form>
        </div>
    )
}

export default PerfilEstudiante;