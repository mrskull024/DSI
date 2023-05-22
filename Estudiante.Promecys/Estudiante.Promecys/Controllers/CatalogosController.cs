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

        [HttpPost("ListarEstadoLaboral")]
        public IActionResult ListEstadoLaboral([FromBody] EstadoLaboralList_Req param)
        {
            List<EstadoLaboral> data = new();

            if (ModelState.IsValid)
            {
                var method = new Datos.CatalogosDataAccess.Execute();

                data = method.EstadoLaboralList(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return BadRequest(ModelState);
        }

        [HttpPost("ListarGeneros")]
        public IActionResult ListGeneros([FromBody] GenerosList_Req param)
        {
            List<Generos> data = new();

            if (ModelState.IsValid)
            {
                var method = new Datos.CatalogosDataAccess.Execute();

                data = method.GenerosList(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return BadRequest(ModelState);
        }

        [HttpPost("ListarTipoEstudiante")]
        public IActionResult ListTipoEstudiante([FromBody] TipoEstudianteList_Req param)
        {
            List<TipoEstudiante> data = new();

            if (ModelState.IsValid)
            {
                var method = new Datos.CatalogosDataAccess.Execute();

                data = method.TipoEstudianteList(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return BadRequest(ModelState);
        }

        [HttpPost("ListarEscuelas")]
        public IActionResult ListEscuelas([FromBody] EscuelasList_Req param)
        {
            List<Escuelas> data = new();

            if (ModelState.IsValid)
            {
                var method = new Datos.CatalogosDataAccess.Execute();

                data = method.EscuelasList(_cn, param);

                if (data != null)
                {
                    return Ok(data);
                }
            }

            return BadRequest(ModelState);
        }
    }
}
