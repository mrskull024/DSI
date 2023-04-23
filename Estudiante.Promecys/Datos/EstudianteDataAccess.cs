using System.Data;
using System.Data.SqlClient;
using Dapper;
using Modelos.Estudiante;

namespace Datos.EstudianteDataAccess
{
    public class Execute : IDisposable
    {
        public Estudiante EstudianteGet(string cn, EstudianteGet_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<Estudiante>(Params.instance.spGetEstudiante,
                    new
                    {
                        param.numeroCarnet
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.FirstOrDefault();
            }
        }

        public List<Estudiante> EstudianteList(string cn, EstudianteList_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
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

        public Estudiante EstudianteCreate(string cn, Estudiante_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
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

        public Estudiante EstudianteUpdate(string cn, Estudiante_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
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

        public void Dispose()
        {

        }
    }


}
