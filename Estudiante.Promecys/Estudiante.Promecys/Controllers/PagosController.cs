using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos.Catalogos;
using Modelos.Pagos;

namespace Promecys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagosController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly string _cn;
        public PagosController(IConfiguration configuration)
        {
            _configuration = configuration;
            _cn = _configuration.GetConnectionString("DefaultConnection").ToString();
        }

        [HttpPost("PagosPorEstudiante")]
        public IActionResult ListPagos([FromBody] PagosList_Req param)
        {
            List<Pagos> data = new();

            if (ModelState.IsValid)
            {
                var method = new Datos.PagosDataAccess.Execute();

                data = method.PagosList(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return BadRequest(ModelState);
        }
    }
}
