using System.Data;
using System.Data.SqlClient;
using Dapper;
using Modelos.Estudiante;
using Modelos.Matricula;

namespace Datos.MatriculaDataAccess
{
    public class Execute : IDisposable
    {
        public Matricula MatriculaGet(string cn, Matricula_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<Matricula>(Params.instance.spEstudianteGet,
                    new
                    {
                        param.id
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.FirstOrDefault();
            }
        }

        public Matricula MatriculaSave(string cn, Matricula_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<Matricula>(Params.instance.spEstudianteGet,
                    new
                    {
                        param.id,
                        param.estudianteId,
                        param.horario1,
                        param.horario2,
                        param.horario3,
                        param.horario4,
                        param.fechaRegistro,
                        param.estado
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.FirstOrDefault();
            }
        }

        public Matricula MatriculaUpdate(string cn, Matricula_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<Matricula>(Params.instance.spEstudianteGet,
                    new
                    {
                        param.id,
                        param.estudianteId,
                        param.horario1,
                        param.horario2,
                        param.horario3,
                        param.horario4,
                        param.fechaRegistro,
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
