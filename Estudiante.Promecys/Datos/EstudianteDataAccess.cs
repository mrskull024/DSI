using System.Data;
using System.Data.SqlClient;
using Dapper;
using Modelos.Estudiante;

namespace Datos.EstudianteDataAccess
{
    public class Execute : IDisposable
    {
        public Estudiante EstudianteGet(string cn, Estudiante_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<Estudiante>(Params.instance.spEstudianteGet,
                    new
                    {
                        param.numeroCarnet
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
