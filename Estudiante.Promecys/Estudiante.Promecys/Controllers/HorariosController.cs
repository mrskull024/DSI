using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos.Horarios;

namespace Promecys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorariosController : Controller
    {
        [HttpPost]
        public JsonResult ObtenerHorarios([FromBody] HorariosList_Req req)
        {
            var apiResp = new HorariosList_Res();
            var apiResult = new HorariosListLogic();
            apiResult.LogicaHorarios(req, ref apiResp);

            return Json(apiResult);
        }
    }
}
