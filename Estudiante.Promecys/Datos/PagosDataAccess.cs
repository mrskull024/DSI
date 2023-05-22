using System.Data;
using System.Data.SqlClient;
using Dapper;
using Modelos.Pagos;

namespace Datos.PagosDataAccess
{
    public class Execute : IDisposable
    {
        public List<Pagos> PagosList(string cn, PagosList_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<Pagos>(Params.instance.spObtenerPagosPorEstudiante,
                    new
                    {
                        param.numeroCarnet
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
