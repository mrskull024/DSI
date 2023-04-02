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

        //Validar este metodo que aun no esta funcional
        [HttpGet]
        public Horarios ObtenerHorario([FromBody] HorariosGet_Req param)
        {
            var data = new Horarios();
            var method = new Datos.HorariosDataAccess.Execute();

            try
            {
                data = method.GetHorarios(_cn, param);

                if (data != null)
                {
                    return data;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }



            return data;
        }

        [HttpPost]
        public List<Horarios> ListHorarios([FromBody] HorariosList_Req param)
        {
            var data = new List<Horarios>();
            var method = new Datos.HorariosDataAccess.Execute();

            data = method.HorariosList(_cn, param);

            if (data != null)
            {
                return data;
            }

            return data;
        }

        [HttpPost]
        public Horarios CreateHorario([FromBody] Horarios_Req param)
        {
            var data = new Horarios();
            var method = new Datos.HorariosDataAccess.Execute();

            try
            {
                data = method.CreateHorarios(_cn, param);

                if (data != null)
                {
                    return data;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }

            return data;
        }

        [HttpPut]
        public Horarios UpdateHorario([FromBody] Horarios_Req param)
        {
            var data = new Horarios();
            var method = new Datos.HorariosDataAccess.Execute();

            try
            {
                data = method.UpdateHorarios(_cn, param);

                if (data != null)
                {
                    return data;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }

            return data;
        }
    }
}
