using DSI_BLL.Interfaces.Estudiantes;
using Microsoft.AspNetCore.Mvc;
using Modelos.Estudiante;

namespace Promecys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : Controller
    {
        private readonly IEstudiante _estudiantes;

        public EstudianteController(IEstudiante estudiantes)
        {
            _estudiantes = estudiantes;
        }

        /// <summary>
        /// Retorna los registros asociados a un estudiante de promecys
        /// </summary>
        /// <param name="numeroCarnet">Parámetro para obtener los datos de un estudiante</param>
        /// <returns><see cref="Estudiante"/></returns>
        [HttpGet("GetEstudiante")]
        public IActionResult ObtenerEstudiante(string numeroCarnet)
        {
            if (ModelState.IsValid)
            {
                var method = _estudiantes.ObtenerEstudiante(numeroCarnet);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return NotFound("El estudiante con el numero de carnet especificado no existe");
        }

        /// <summary>
        /// Retorna un listado de estudiantes de promecys
        /// </summary>
        /// <param name="param">Parámetro para incluir registros desactivados en el resultado</param>
        /// <returns><see cref="Estudiante"/></returns>
        [HttpPost("ListEstudiantes")]
        public IActionResult ListEstudiantes([FromBody] EstudianteList_Req param)
        {
            if (ModelState.IsValid)
            {
                var method = _estudiantes.ListarEstudiantes(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Crea un estudiante para promecys
        /// </summary>
        /// <param name="param">Parámetros para crear un estudiantes</param>
        /// <returns><see cref="Estudiante"/></returns>
        [HttpPost("CreateEstudiante")]
        public IActionResult CreateEstudiante([FromBody] Estudiante_Req param)
        {
            if (ModelState.IsValid)
            {
                var method = _estudiantes.CrearEstudiante(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Actualiza los datos de un estudiante de promecys
        /// </summary>
        /// <param name="param">Parámetros para actualizar los datos de un estudiantes</param>
        /// <returns><see cref="Estudiante"/></returns>
        [HttpPut("UpdateEstudiante")]
        public IActionResult UpdateEstdudiante([FromBody] Estudiante_Req param)
        {
            if (ModelState.IsValid)
            {
                var method = _estudiantes.ActualizarEstudiante(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }
    }
}
