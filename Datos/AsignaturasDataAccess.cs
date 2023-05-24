using System.Data;
using Dapper;
using Datos.Common;
using Modelos.Asignaturas;

namespace Datos.AsignaturaDataAccess
{
    public class AsignaturasDataAccess : DSI_BaseDAL
    {
        public AsignaturasDataAccess(string connectionString) : base(connectionString)
        {
        }

        public List<Asignaturas> AsignaturasList(AsignaturasList_Req param)
        {
            using (var sqlConn = ObtenerConexion())
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

        public List<AsignaturasPorEstudiante> AsignaturasPorEstudianteList(AsignaturasPorEstudianteList_Req param)
        {
            using (var sqlConn = ObtenerConexion())
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
    }
}
