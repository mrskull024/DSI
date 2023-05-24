using DSI_BLL.Interfaces.Catalogos;
using Microsoft.AspNetCore.Mvc;
using Modelos.Catalogos;

namespace Promecys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogosController : ControllerBase
    {
        private readonly ICatalogos _catalogos;

        public CatalogosController(ICatalogos catalogos)
        {
            _catalogos = catalogos;
        }

        /// <summary>
        /// Retorna listado de estados civiles
        /// </summary>
        /// <param name="param">Parámetro para incluir registros desactivados en el resultado</param>
        /// <returns><see cref="EstadoCivil"/></returns>
        [HttpPost("ListarEstadoCivil")]
        public IActionResult ListEstadoCivil([FromBody] EstadoCivilList_Req param)
        {
           if (ModelState.IsValid)
            {
                var method = _catalogos.ListarEstadoCivil(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Retorna listado de departamentos
        /// </summary>
        /// <param name="param">Parámetro para incluir registros desactivados en el resultado</param>
        /// <returns><see cref="Departamentos"/></returns>
        [HttpPost("ListarDepartamentos")]
        public IActionResult ListDepartamentos([FromBody] DepartamentosList_Req param)
        {
            if (ModelState.IsValid)
            {
                var method =_catalogos.ListarDepartamentos(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Retorna listado de municipios
        /// </summary>
        /// <param name="param">Parámetro para incluir registros desactivados en el resultado</param>
        /// <returns><see cref="Municipios"/></returns>
        [HttpPost("ListarMunicipios")]
        public IActionResult ListMunicipios([FromBody] MunicipiosList_Req param)
        {
            if (ModelState.IsValid)
            {
                var method = _catalogos.ListarMunicipios(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Retorna listado de estados laborales
        /// </summary>
        /// <param name="param">Parámetro para incluir registros desactivados en el resultado</param>
        /// <returns><see cref="EstadoLaboral"/></returns>
        [HttpPost("ListarEstadoLaboral")]
        public IActionResult ListEstadoLaboral([FromBody] EstadoLaboralList_Req param)
        {
            if (ModelState.IsValid)
            {
                var method = _catalogos.ListarEstadoLaboral(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Retorna listado de generos
        /// </summary>
        /// <param name="param">Parámetro para incluir registros desactivados en el resultado</param>
        /// <returns><see cref="Generos"/></returns>
        [HttpPost("ListarGeneros")]
        public IActionResult ListGeneros([FromBody] GenerosList_Req param)
        {
            if (ModelState.IsValid)
            {
                var method = _catalogos.ListarGenero(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Retorna listado de tipos de estudiante
        /// </summary>
        /// <param name="param">Parámetro para incluir registros desactivados en el resultado</param>
        /// <returns><see cref="TipoEstudiante"/></returns>
        [HttpPost("ListarTipoEstudiante")]
        public IActionResult ListTipoEstudiante([FromBody] TipoEstudianteList_Req param)
        {
            if (ModelState.IsValid)
            {
                var method = _catalogos.ListarTipoEstudiante(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Retorna listado de escuelas
        /// </summary>
        /// <param name="param">Parámetro para incluir registros desactivados en el resultado</param>
        /// <returns><see cref="Escuelas"/></returns>
        [HttpPost("ListarEscuelas")]
        public IActionResult ListEscuelas([FromBody] EscuelasList_Req param)
        {
            if (ModelState.IsValid)
            {
                var method = _catalogos.ListarEscuela(param);

                if (method != null)
                {
                    return Ok(method);
                }
            }

            return BadRequest(ModelState);
        }
    }
}
