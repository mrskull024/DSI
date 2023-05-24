using Modelos.Asignaturas;

namespace DSI_BLL.Interfaces
{
    public interface IAsignaturas
    {
        List<Asignaturas> ListarAsignaturas(AsignaturasList_Req req);
        List<AsignaturasPorEstudiante> ListarAsignaturasPorEstudiante(AsignaturasPorEstudianteList_Req req);
    }
}
