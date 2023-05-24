using System.Data;
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
            using (var sqlConn = ObtenerConexion())
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
