using Datos.PagosDataAccess;
using DSI_BLL.Interfaces.Pagos;
using Microsoft.Extensions.Configuration;
using Modelos.Pagos;

namespace DSI_BLL.Implementacion.Pagos
{
    public class PagosBLL : IPagos
    {
        private readonly IConfiguration _configuration;
        private readonly PagosDataAccess data;

        public PagosBLL(IConfiguration configuration)
        {
            _configuration = configuration;
            string connectionStr = _configuration.GetConnectionString(name: "DefaultConnection");
            data = new PagosDataAccess(connectionStr);
        }

        public List<Pago> ObtenerPagosPorEstudiante(PagosList_Req req)
        {
            return data.PagosList(req);
        }
    }
}
