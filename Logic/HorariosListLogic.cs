using Modelos.Horarios;
using System.Data.SqlClient;
using System.Configuration;

namespace Logic
{
    public class HorariosListLogic
    {
        public void LogicaHorarios(HorariosList_Req req, ref HorariosList_Res res)
        {
            string cn = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            var sqlErrorMessage = "";
            var errorMessage = "";

            try
            {
                using (var db = new Datos.HorariosDataAccess.Execute())
                {
                    var horarios = db.HorariosList(cn, req);
                    if (horarios == null) return;

                    res.horarios = horarios;
                }
            }
            catch (SqlException sqlEx)
            {
                sqlErrorMessage = sqlEx.Message;
            }
            catch (Exception ex)
            {
                System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
                errorMessage = ex.Message;
            }
        }
    }
}
