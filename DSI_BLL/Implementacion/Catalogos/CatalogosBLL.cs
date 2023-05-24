using Datos.CatalogosDataAccess;
using DSI_BLL.Interfaces.Catalogos;
using Microsoft.Extensions.Configuration;
using Modelos.Catalogos;

namespace DSI_BLL.Implementacion.Catalogos
{
    public class CatalogosBLL : ICatalogos
    {
        private readonly IConfiguration _configuration;
        private readonly CatalogosDataAccess data;

        public CatalogosBLL(IConfiguration configuration)
        {
            _configuration = configuration;
            string connectionStr = _configuration.GetConnectionString(name: "DefaultConnection");
            data = new CatalogosDataAccess(connectionStr);
        }
        public List<Departamentos> ListarDepartamentos(DepartamentosList_Req req)
        {
            return data.DepartamentosList(req);
        }

        public List<Escuelas> ListarEscuela(EscuelasList_Req req)
        {
            return data.EscuelasList(req);
        }

        public List<EstadoCivil> ListarEstadoCivil(EstadoCivilList_Req req)
        {
            return data.EstadoCivilList(req);
        }

        public List<EstadoLaboral> ListarEstadoLaboral(EstadoLaboralList_Req req)
        {
            return data.EstadoLaboralList(req);
        }

        public List<Generos> ListarGenero(GenerosList_Req req)
        {
            return data.GenerosList(req);
        }

        public List<Municipios> ListarMunicipios(MunicipiosList_Req req)
        {
            return data.MunicipiosList(req);
        }

        public List<TipoEstudiante> ListarTipoEstudiante(TipoEstudianteList_Req req)
        {
            return data.TipoEstudianteList(req);
        }
    }
}
