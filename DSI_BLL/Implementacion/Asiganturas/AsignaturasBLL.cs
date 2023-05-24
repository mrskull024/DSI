using Datos.AsignaturaDataAccess;
using DSI_BLL.Interfaces;
using Microsoft.Extensions.Configuration;
using Modelos.Asignaturas;

namespace DSI_BLL.Implementacion.Asiganturas
{
    public class AsignaturasBLL : IAsignaturas
    {
        private readonly IConfiguration _configuration;
        private readonly AsignaturasDataAccess data;

        public AsignaturasBLL(IConfiguration configuration)
        {
            _configuration = configuration;
            string connectionStr = _configuration.GetConnectionString(name: "DefaultConnection");
            data = new AsignaturasDataAccess(connectionStr);
        }

         public List<Asignaturas> ListarAsignaturas(AsignaturasList_Req req)
        {
            return data.AsignaturasList(req);
        }

        public List<AsignaturasPorEstudiante> ListarAsignaturasPorEstudiante(AsignaturasPorEstudianteList_Req req)
        {
            return data.AsignaturasPorEstudianteList(req);
        }
    }
}
