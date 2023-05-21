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
                        param.incluirDesactivados
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.ToList();
            }
        }

        public List<AsignaturasPorEstudiante> AsignaturasPorEstudianteList(string cn, AsignaturasPorEstudianteList_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<AsignaturasPorEstudiante>(Params.instance.spAsignaturasPorEstudiante,
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
