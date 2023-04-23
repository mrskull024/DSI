using Microsoft.AspNetCore.Mvc;
using Modelos.Horarios;
using Modelos.Horarios_Req;

namespace Promecys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorariosController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly string _cn;
        public HorariosController(IConfiguration configuration)
        {
            _configuration = configuration;
            _cn = _configuration.GetConnectionString("DefaultConnection").ToString();
        }

        [HttpGet("GetHorario/{id}")]
        public IActionResult ObtenerHorario(int id)
        {
            Horarios data = new();
            var param = new HorariosGet_Req
            {
                id = id
            };

            if(ModelState.IsValid)
            {
                var method = new Datos.HorariosDataAccess.Execute();
                data = method.GetHorarios(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return NotFound("El registro con el id especificado no existe");
        }

        [HttpPost("ListHorarios")]
        public IActionResult ListHorarios([FromBody] HorariosList_Req param)
        {
            List<Horarios> data = new();

            if (ModelState.IsValid)
            {
                var method = new Datos.HorariosDataAccess.Execute();

                data = method.HorariosList(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }
          
            return BadRequest(ModelState);
        }

        [HttpPost("CreateHorario")]
        public IActionResult CreateHorario([FromBody] Horarios_Req param)
        {
            Horarios data = new();
            
            if(ModelState.IsValid)
            {
                var method = new Datos.HorariosDataAccess.Execute();
                data = method.CreateHorarios(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return BadRequest(ModelState);
        }

        [HttpPut("UpdateHorario")]
        public IActionResult UpdateHorario([FromBody] Horarios_Req param)
        {
            var data = new Horarios();
            if (ModelState.IsValid)
            {
                var method = new Datos.HorariosDataAccess.Execute();
                data = method.UpdateHorarios(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return BadRequest(ModelState);
        }
    }
}
