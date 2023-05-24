using Modelos.Catalogos;

namespace DSI_BLL.Interfaces.Catalogos
{
    public interface ICatalogos
    {
        List<EstadoCivil> ListarEstadoCivil(EstadoCivilList_Req req);
        List<Departamentos> ListarDepartamentos(DepartamentosList_Req req);
        List<Municipios> ListarMunicipios(MunicipiosList_Req req);
        List<EstadoLaboral> ListarEstadoLaboral(EstadoLaboralList_Req req);
        List<Generos> ListarGenero(GenerosList_Req req);
        List<TipoEstudiante> ListarTipoEstudiante(TipoEstudianteList_Req req);
        List<Escuelas> ListarEscuela(EscuelasList_Req req);
    }
}
