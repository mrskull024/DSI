using System.Data;
using System.Data.SqlClient;
using Dapper;
using Datos.Common;
using Modelos.Estudiante;

namespace Datos.EstudianteDataAccess
{
    public class EstudianteDataAccess : DSI_BaseDAL
    {
        public EstudianteDataAccess(string connectionString) : base(connectionString)
        {
        }

        public Estudiante EstudianteGet(string numeroCarnet)
        {
            SqlConnection conn = ObtenerConexion();
            conn.Open();
            using (var sqlConn = conn)
            {
                var query = sqlConn.Query<Estudiante>(Params.instance.spGetEstudiante,
                    new
                    {
                        numeroCarnet
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.FirstOrDefault();
            }
        }

        public List<Estudiante> EstudianteList(EstudianteList_Req param)
        {
            SqlConnection conn = ObtenerConexion();
            conn.Open();
            using (var sqlConn = conn)
            {
                var query = sqlConn.Query<Estudiante>(Params.instance.spEstudianteList,
                    new
                    {
                        param.incluirInactivos
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.ToList();
            }
        }

        public Estudiante EstudianteCreate(Estudiante_Req param)
        {
            SqlConnection conn = ObtenerConexion();
            conn.Open();
            using (var sqlConn = conn)
            {
                var query = sqlConn.Query<Estudiante>(Params.instance.spCreateEstudiante,
                    new
                    {
                        param.primerNombre,
                        param.segundoNombre,
                        param.primerApellido,
                        param.segundoApellido,
                        param.numeroIdentificacion,
                        param.numeroCarnet,
                        param.fechaNacimiento,
                        param.fechaIngreso,
                        param.edad,
                        param.celular,
                        param.correo,
                        param.numeroTelefonico,
                        param.idEstadoCivil,
                        param.idGenero,
                        param.idColegioSecundaria,
                        param.idEstadoLaboral,
                        param.idDepartamento,
                        param.idMunicipio,
                        param.idTipoEstudiante,
                        param.direccion,
                        param.estado
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.FirstOrDefault();
            }
        }

        public Estudiante EstudianteUpdate(Estudiante_Req param)
        {
            SqlConnection conn = ObtenerConexion();
            conn.Open();
            using (var sqlConn = conn)
            {
                var query = sqlConn.Query<Estudiante>(Params.instance.spUpdateEstudiante,
                    new
                    {
                        param.id,
                        param.primerNombre,
                        param.segundoNombre,
                        param.primerApellido,
                        param.segundoApellido,
                        param.numeroIdentificacion,
                        param.numeroCarnet,
                        param.fechaNacimiento,
                        param.fechaIngreso,
                        param.edad,
                        param.celular,
                        param.correo,
                        param.numeroTelefonico,
                        param.idEstadoCivil,
                        param.idGenero,
                        param.idColegioSecundaria,
                        param.idEstadoLaboral,
                        param.idDepartamento,
                        param.idMunicipio,
                        param.idTipoEstudiante,
                        param.direccion,
                        param.estado
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.FirstOrDefault();
            }
        }
    }
}
