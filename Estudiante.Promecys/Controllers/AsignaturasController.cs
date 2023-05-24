using DSI_BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Modelos.Asignaturas;

namespace Promecys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsignaturasController : ControllerBase
    {
        private readonly IAsignaturas _asignaturas;

        public AsignaturasController(IAsignaturas asignaturas)
        {
            _asignaturas = asignaturas;
        }

        /// <summary>
        /// Retorna listado de asginaturas de promecys
        /// </summary>
        /// <param name="param">Parámetro para incluir registros desactivados en el resultado</param>
        /// <returns><see cref="Asignaturas"/></returns>
        [HttpPost("ListAsignaturas")]
        public IActionResult ListAsignaturas([FromBody] AsignaturasList_Req param)
        {
            if (ModelState.IsValid)
            {
                var method = _asignaturas.ListarAsignaturas(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Retorna listado de asginaturas por estudiante de promecys
        /// </summary>
        /// <param name="param">Parámetro para incluir registros desactivados en el resultado</param>
        /// <returns><see cref="AsignaturasPorEstudiante"/></returns>
        [HttpPost("ListAsignaturasPorEstudiante")]
        public IActionResult ListAsignaturasPorEstudiante([FromBody] AsignaturasPorEstudianteList_Req param)
        {
            if (ModelState.IsValid)
            {
                var method = _asignaturas.ListarAsignaturasPorEstudiante(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }
    }
}
