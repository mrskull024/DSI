using System.Data;
using System.Data.SqlClient;
using Dapper;
using Datos.Common;
using Modelos.Pagos;

namespace Datos.PagosDataAccess
{
    public class PagosDataAccess : DSI_BaseDAL
    {
        public PagosDataAccess(string connectionString) : base(connectionString)
        {
        }

        public List<Pago> PagosList(PagosList_Req param)
        {
            SqlConnection conn = ObtenerConexion();
            conn.Open();
            using (var sqlConn = conn)
            {
                var query = sqlConn.Query<Pago>(Params.instance.spObtenerPagosPorEstudiante,
                    new
                    {
                        param.numeroCarnet
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.ToList();
            }
        }
    }
}
