using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using Modelos.Horarios;
using Modelos.Horarios_Req;

namespace Datos.HorariosDataAccess
{
    public class Execute : IDisposable
    {
        public Horarios GetHorarios(string cn, HorariosGet_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<Horarios>(Params.instance.spGetHorarios,
                    new
                    {
                        param.id
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.FirstOrDefault();
            }

        }

        public List<Horarios> HorariosList(string cn, HorariosList_Req param)
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

        public Horarios CreateHorarios(string cn, Horarios_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<Horarios>(Params.instance.spCreateHorarios,
                    new
                    {
                        param.nombre,
                        param.horaInicio,
                        param.horaFin,
                        param.estado
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.FirstOrDefault();
            }

        }

        public Horarios UpdateHorarios(string cn, Horarios_Req param)
        {
            using (var sqlConn = new SqlConnection(cn))
            {
                var query = sqlConn.Query<Horarios>(Params.instance.spUpdateHorarios,
                    new
                    {
                        param.id,
                        param.nombre,
                        param.horaInicio,
                        param.horaFin,
                        param.estado
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.FirstOrDefault();
            }

        }

        public void Dispose()
        {

        }
    }


}
