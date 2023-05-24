using Modelos.Horarios;

namespace DSI_BLL.Interfaces.Horarios
{
    public interface IHorarios
    {
        Horario ObtenerHorario(HorariosGet_Req req);
        List<Horario> ListarHorario (HorariosList_Req req);
        Horario CrearHorario (Horarios_Req req);
        Horario ActualizarHorario (Horarios_Req req);
    }
}
