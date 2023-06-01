using Datos.HorariosDataAccess;
using DSI_BLL.Interfaces.Horarios;
using Microsoft.Extensions.Configuration;
using Modelos.Horarios;

namespace DSI_BLL.Implementacion.Horarios
{
    public class HorariosBLL : IHorarios
    {
        private readonly IConfiguration _configuration;
        private readonly HorariosDataAccess data;

        public HorariosBLL(IConfiguration configuration)
        {
            _configuration = configuration;
            string connectionStr = _configuration.GetConnectionString(name: "DefaultConnection");
            data = new HorariosDataAccess(connectionStr);
        }

        public Horario ActualizarHorario(Horarios_Req req)
        {
            return data.UpdateHorarios(req);
        }

        public Horario BajaHorario(Horarios_Req req)
        {
            return data.DeleteHorarios(req);
        }

        public Horario CrearHorario(Horarios_Req req)
        {
            return data.CreateHorarios(req);
        }

        public List<Horario> ListarHorario(HorariosList_Req req)
        {
            return data.HorariosList(req);
        }

        public Horario ObtenerHorario(int id)
        {
            return data.GetHorarios(id);
        }
    }
}
