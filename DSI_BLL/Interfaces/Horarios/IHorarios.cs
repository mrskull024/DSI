using Modelos.Horarios;

namespace DSI_BLL.Interfaces.Horarios
{
    public interface IHorarios
    {
        Horario ObtenerHorario(int id);
        List<Horario> ListarHorario (HorariosList_Req req);
        Horario CrearHorario (Horarios_Req req);
        Horario ActualizarHorario (Horarios_Req req);
        Horario BajaHorario (Horarios_Req req); 
    }
}
