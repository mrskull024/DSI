using System.Data;
using Dapper;
using Datos.Common;
using Modelos.Catalogos;

namespace Datos.CatalogosDataAccess
{
    public class CatalogosDataAccess : DSI_BaseDAL
    {
        public CatalogosDataAccess(string connectionString) : base(connectionString)
        {
        }

        public List<EstadoCivil> EstadoCivilList(EstadoCivilList_Req param)
        {
            using (var sqlConn = ObtenerConexion())
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

        public List<Departamentos> DepartamentosList(DepartamentosList_Req param)
        {
            using (var sqlConn = ObtenerConexion())
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

        public List<Municipios> MunicipiosList(MunicipiosList_Req param)
        {
            using (var sqlConn = ObtenerConexion())
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

        public List<EstadoLaboral> EstadoLaboralList(EstadoLaboralList_Req param)
        {
            using (var sqlConn = ObtenerConexion())
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

        public List<Generos> GenerosList(GenerosList_Req param)
        {
            using (var sqlConn = ObtenerConexion())
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

        public List<TipoEstudiante> TipoEstudianteList(TipoEstudianteList_Req param)
        {
            using (var sqlConn = ObtenerConexion())
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

        public List<Escuelas> EscuelasList(EscuelasList_Req param)
        {
            using (var sqlConn = ObtenerConexion())
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
    }
}
