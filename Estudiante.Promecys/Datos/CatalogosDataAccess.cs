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

        public List<EstadoLaboral> EstadoLaboralList(string cn, EstadoLaboralList_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<EstadoLaboral>(Params.instance.spEstadoLaboralList,
                    new
                    {
                        param.incluirDesactivados
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.ToList();
            }
        }

        public List<Generos> GenerosList(string cn, GenerosList_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<Generos>(Params.instance.spGenerosList,
                    new
                    {
                        param.incluirDesactivados
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.ToList();
            }
        }

        public List<TipoEstudiante> TipoEstudianteList(string cn, TipoEstudianteList_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<TipoEstudiante>(Params.instance.spTipoEstudianteList,
                    new
                    {
                        param.incluirDesactivados
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.ToList();
            }
        }

        public List<Escuelas> EscuelasList(string cn, EscuelasList_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<Escuelas>(Params.instance.spEscuelasList,
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
