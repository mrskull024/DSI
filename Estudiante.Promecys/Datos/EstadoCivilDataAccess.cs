using System.Data;
using System.Data.SqlClient;
using Dapper;
using Modelos.Catalogos;

namespace Datos.EstadoCivilDataAccess
{
    public class Execute : IDisposable
    {
        public List<EstadoCivil> EstadoCivilList(string cn, EstadoCivilList_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<EstadoCivil>(Params.instance.spEstadosCivilesList,
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
