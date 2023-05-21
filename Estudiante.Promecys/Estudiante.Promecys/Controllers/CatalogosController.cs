using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos.Asignaturas;
using Modelos.Catalogos;

namespace Promecys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogosController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly string _cn;
        public CatalogosController(IConfiguration configuration)
        {
            _configuration = configuration;
            _cn = _configuration.GetConnectionString("DefaultConnection").ToString();
        }

        [HttpPost("ListarEstadoCivil")]
        public IActionResult ListEstadoCivil([FromBody] EstadoCivilList_Req param)
        {
            List<EstadoCivil> data = new();

            if (ModelState.IsValid)
            {
                var method = new Datos.CatalogosDataAccess.Execute();

                data = method.EstadoCivilList(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return BadRequest(ModelState);
        }

        [HttpPost("ListarDepartamentos")]
        public IActionResult ListDepartamentos([FromBody] DepartamentosList_Req param)
        {
            List<Departamentos> data = new();

            if (ModelState.IsValid)
            {
                var method = new Datos.CatalogosDataAccess.Execute();

                data = method.DepartamentosList(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return BadRequest(ModelState);
        }

        [HttpPost("ListarMunicipios")]
        public IActionResult ListMunicipios([FromBody] MunicipiosList_Req param)
        {
            List<Municipios> data = new();

            if (ModelState.IsValid)
            {
                var method = new Datos.CatalogosDataAccess.Execute();

                data = method.MunicipiosList(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return BadRequest(ModelState);
        }
    }
}
