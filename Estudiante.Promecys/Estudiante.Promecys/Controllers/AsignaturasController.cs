using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos.Asignaturas;
using Modelos.Estudiante;

namespace Promecys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsignaturasController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly string _cn;
        public AsignaturasController(IConfiguration configuration)
        {
            _configuration = configuration;
            _cn = _configuration.GetConnectionString("DefaultConnection").ToString();
        }

        [HttpPost("ListAsignaturas")]
        public IActionResult ListAsignaturas([FromBody] AsignaturasList_Req param)
        {
            List<Asignaturas> data = new();

            if (ModelState.IsValid)
            {
                var method = new Datos.AsignaturaDataAccess.Execute();

                data = method.AsignaturasList(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return BadRequest(ModelState);
        }

        [HttpPost("ListAsignaturasPorEstudiante")]
        public IActionResult ListAsignaturasPorEstudiante([FromBody] AsignaturasPorEstudianteList_Req param)
        {
            List<AsignaturasPorEstudiante> data = new();

            if (ModelState.IsValid)
            {
                var method = new Datos.AsignaturaDataAccess.Execute();

                data = method.AsignaturasPorEstudianteList(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return BadRequest(ModelState);
        }
    }
}
