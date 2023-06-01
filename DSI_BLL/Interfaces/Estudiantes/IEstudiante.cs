using Modelos.Estudiante;

namespace DSI_BLL.Interfaces.Estudiantes
{
    public interface IEstudiante
    {
        Estudiante ObtenerEstudiante(string numeroCarnet);
        List<Estudiante> ListarEstudiantes(EstudianteList_Req req);
        Estudiante CrearEstudiante(Estudiante_Req req);
        Estudiante ActualizarEstudiante(Estudiante_Req req);
    }
}
