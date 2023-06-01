using System.Data;
using System.Data.SqlClient;
using Dapper;
using Datos.Common;
using Modelos.Horarios;

namespace Datos.HorariosDataAccess
{
    public class HorariosDataAccess : DSI_BaseDAL
    {
        public HorariosDataAccess(string connectionString) : base(connectionString)
        {
        }

        public Horario GetHorarios(HorariosGet_Req param)
        {
            SqlConnection conn = ObtenerConexion();
            conn.Open();
            using (var sqlConn = conn)
            {
                var query = sqlConn.Query<Horario>(Params.instance.spGetHorarios,
                    new
                    {
                        param.id
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.FirstOrDefault();
            }
            
        }

        public List<Horario> HorariosList(HorariosList_Req param)
        {
            SqlConnection conn = ObtenerConexion();
            conn.Open();
            using (var sqlConn = conn)
            {
                var query = sqlConn.Query<Horario>(Params.instance.spHorariosList,
                    new
                    {
                        param.incluirInactivos
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.ToList();
            }
        }

        public Horario CreateHorarios(Horarios_Req param)
        {
            SqlConnection conn = ObtenerConexion();
            conn.Open();
            using (var sqlConn = conn)
            {
                var query = sqlConn.Query<Horario>(Params.instance.spCreateHorarios,
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

        public Horario UpdateHorarios(Horarios_Req param)
        {
            SqlConnection conn = ObtenerConexion();
            conn.Open();
            using (var sqlConn = conn)
            {
                var query = sqlConn.Query<Horario>(Params.instance.spUpdateHorarios,
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

        public Horario DeleteHorarios(Horarios_Req param)
        {
            SqlConnection conn = ObtenerConexion();
            conn.Open();
            using (var sqlConn = conn)
            {
                var query = sqlConn.Query<Horario>(Params.instance.spDeleteHorarios,
                    new
                    {
                        param.id
                    },
                    null, true, null, CommandType.StoredProcedure);
                return query.FirstOrDefault();
            }
        }
    }
}
