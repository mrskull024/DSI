using System.Data;
using System.Data.SqlClient;
using Dapper;
using Modelos.Horarios;

namespace Datos.HorariosDataAccess
{
    public class Execute : IDisposable
    {
        public List<Horarios>HorariosList(string cn, HorariosList_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<Horarios>(Params.instance.spHorariosList,
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
