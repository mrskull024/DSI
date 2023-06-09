﻿using System.Data;
using System.Data.SqlClient;
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
            SqlConnection conn = ObtenerConexion();
            conn.Open();
            using (var sqlConn = conn)
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
            SqlConnection conn = ObtenerConexion();
            conn.Open();
            using (var sqlConn = conn)
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
