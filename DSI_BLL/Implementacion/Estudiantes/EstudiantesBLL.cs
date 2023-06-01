using Datos.EstudianteDataAccess;
using DSI_BLL.Interfaces.Estudiantes;
using Microsoft.Extensions.Configuration;
using Modelos.Estudiante;

namespace DSI_BLL.Implementacion.Estudiantes
{
    public class EstudiantesBLL:IEstudiante
    {
        private readonly IConfiguration _configuration;
        private readonly EstudianteDataAccess data;

        public EstudiantesBLL(IConfiguration configuration)
        {
            _configuration = configuration;
            string connectionStr = _configuration.GetConnectionString(name: "DefaultConnection");
            data = new EstudianteDataAccess(connectionStr);
        }

        public Estudiante ActualizarEstudiante(Estudiante_Req req)
        {
            return data.EstudianteUpdate(req);
        }

        public Estudiante CrearEstudiante(Estudiante_Req req)
        {
            return data.EstudianteCreate(req);
        }

        public List<Estudiante> ListarEstudiantes(EstudianteList_Req req)
        {
            return data.EstudianteList(req);
        }

        public Estudiante ObtenerEstudiante(string numeroCarnet)
        {
            return data.EstudianteGet(numeroCarnet);
        }
    }
}
