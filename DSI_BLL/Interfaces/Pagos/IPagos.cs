using Modelos.Pagos;

namespace DSI_BLL.Interfaces.Pagos
{
    public interface IPagos
    {
        List<Pago> ObtenerPagosPorEstudiante(PagosList_Req req);
    }
}
