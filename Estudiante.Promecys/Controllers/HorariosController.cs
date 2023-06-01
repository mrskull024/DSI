using DSI_BLL.Interfaces.Horarios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Modelos.Horarios;

namespace Promecys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorariosController : Controller
    {
        private readonly IHorarios _horarios;

        public HorariosController(IHorarios horarios)
        {
            _horarios = horarios;
        }

        /// <summary>
        /// Retorna el registro de un horario especifico de clases
        /// </summary>
        /// <param name="param">Parámetro para obtener los datos de un horario</param>
        /// <returns><see cref="Horario"/></returns>
        [HttpGet("GetHorario")]
        public IActionResult ObtenerHorario(HorariosGet_Req param)
        {
            if (ModelState.IsValid)
            {
                var method = _horarios.ObtenerHorario(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return NotFound("El registro con el id especificado no existe");
        }

        /// <summary>
        /// Retorna un listado de horarios de clases
        /// </summary>
        /// <param name="param">Parámetro para obtener un listado de horarios</param>
        /// <returns><see cref="Horario"/></returns>
        [HttpPost("ListHorarios")]
        public IActionResult ListHorarios([FromBody] HorariosList_Req param)
        {
            if (ModelState.IsValid)
            {
                var method = _horarios.ListarHorario(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Crea un horario de clases 
        /// </summary>
        /// <param name="param">Parámetros para crear un horario de clases</param>
        /// <returns><see cref="Horario"/></returns>
        [HttpPost("CreateHorario")]
        public IActionResult CreateHorario([FromBody] Horarios_Req param)
        {
            if (ModelState.IsValid)
            {
                var method = _horarios.CrearHorario(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Actualiza un horario de clases 
        /// </summary>
        /// <param name="param">Parámetros para actualizar un horario de clases</param>
        /// <returns><see cref="Horario"/></returns>
        [HttpPut("UpdateHorario")]
        public IActionResult UpdateHorario([FromBody] Horarios_Req param)
        {
            if (ModelState.IsValid)
            {
                var method = _horarios.ActualizarHorario(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Da de baja un horario de clases (cambia el estado logico)
        /// </summary>
        /// <param name="param">Parámetros para dar decbaja un horario de clases</param>
        /// <returns><see cref="Horario"/></returns>
        [HttpPut("DeleteHorario")]
        public IActionResult DeleteHorario([FromBody] Horarios_Req param)
        {
            if (ModelState.IsValid)
            {
                var method = _horarios.BajaHorario(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }
    }
}
