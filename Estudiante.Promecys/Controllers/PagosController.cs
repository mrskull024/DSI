using DSI_BLL.Interfaces.Pagos;
using Microsoft.AspNetCore.Mvc;
using Modelos.Pagos;

namespace Promecys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagosController : ControllerBase
    {
        private readonly IPagos _pagos;

        public PagosController(IPagos pagos)
        {
            _pagos = pagos;
        }

        /// <summary>
        /// Retorna un listado de pagos realizados por un estudiante
        /// </summary>
        /// <param name="param">Parámetro para obtener el listado de pagos de un estudiante</param>
        /// <returns><see cref="Pago"/></returns>
        [HttpPost("PagosPorEstudiante")]
        public IActionResult ListPagos([FromBody] PagosList_Req param)
        {
           if (ModelState.IsValid)
            {
                var method = _pagos.ObtenerPagosPorEstudiante(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }
    }
}
