using System.Data;
using System.Data.SqlClient;
using Dapper;
using Modelos.Catalogos;

namespace Datos.CatalogosDataAccess
{
    public class Execute : IDisposable
    {
        public List<EstadoCivil> EstadoCivilList(string cn, EstadoCivilList_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<EstadoCivil>(Params.instance.spEstadoCivilList,
                    new
                    {
                        param.incluirDesactivados
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.ToList();
            }
        }

        public List<Departamentos> DepartamentosList(string cn, DepartamentosList_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<Departamentos>(Params.instance.spDepartamentosList,
                    new
                    {
                        param.incluirDesactivados
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.ToList();
            }
        }

        public List<Municipios> MunicipiosList(string cn, MunicipiosList_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<Municipios>(Params.instance.spMunicipiosList,
                    new
                    {
                        param.incluirDesactivados
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
