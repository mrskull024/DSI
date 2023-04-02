using System.Data;
using System.Data.SqlClient;
using Dapper;
using Modelos.Asignaturas;

namespace Datos.AsignaturaDataAccess
{
    public class Execute : IDisposable
    {
        public List<Asignaturas> AsignaturasList(string cn, AsignaturasList_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<Asignaturas>(Params.instance.spAsignaturasList,
                    new
                    {
                        param.incluirInactivos
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.ToList();
            }
        }

        public void Dispose()
        {

        }
    }


}
