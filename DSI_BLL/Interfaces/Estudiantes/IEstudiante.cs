using Modelos.Estudiante;

namespace DSI_BLL.Interfaces.Estudiantes
{
    public  interface IEstudiante
    {
        Estudiante ObtenerEstudiante(EstudianteGet_Req req);
        List<Estudiante> ListarEstudiantes(EstudianteList_Req req);
        Estudiante CrearEstudiante(Estudiante_Req req);
        Estudiante ActualizarEstudiante(Estudiante_Req req);
    }
}
