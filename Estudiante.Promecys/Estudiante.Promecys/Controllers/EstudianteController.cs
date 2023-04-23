using Microsoft.AspNetCore.Mvc;
using Modelos.Estudiante;

namespace Promecys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly string _cn;
        public EstudianteController(IConfiguration configuration)
        {
            _configuration = configuration;
            _cn = _configuration.GetConnectionString("DefaultConnection").ToString();
        }

        [HttpGet("GetEstudiante/{numeroCarnet}")]
        public IActionResult ObtenerEstudiante(string numeroCarnet)
        {
            Estudiante data = new();
            var param = new EstudianteGet_Req
            {
                numeroCarnet = numeroCarnet
            };

            if (ModelState.IsValid)
            {
                var method = new Datos.EstudianteDataAccess.Execute();
                data = method.EstudianteGet(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return NotFound("El registro con el id especificado no existe");
        }

        [HttpPost("ListEstudiantes")]
        public IActionResult ListEstudiantes([FromBody] EstudianteList_Req param)
        {
            List<Estudiante> data = new();

            if (ModelState.IsValid)
            {
                var method = new Datos.EstudianteDataAccess.Execute();

                data = method.EstudianteList(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return BadRequest(ModelState);
        }

        [HttpPost("CreateEstudiante")]
        public IActionResult CreateEstudiante([FromBody] Estudiante_Req param)
        {
            Estudiante data = new();

            if (ModelState.IsValid)
            {
                var method = new Datos.EstudianteDataAccess.Execute();
                data = method.EstudianteCreate(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return BadRequest(ModelState);
        }

        [HttpPut("UpdateEstudiante")]
        public IActionResult UpdateHorario([FromBody] Estudiante_Req param)
        {
            Estudiante data = new();

            if (ModelState.IsValid)
            {
                var method = new Datos.EstudianteDataAccess.Execute();
                data = method.EstudianteUpdate(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return BadRequest(ModelState);
        }
    }
}
