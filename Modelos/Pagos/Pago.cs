namespace Modelos.Pagos
{
    public class Pago
    {
        public int id { get; set; }
        public bool estado { get; set; }
        public int idEstudiante { get; set; }
        public string numeroCarnet { get; set; }
        public string conceptoPago { get; set; }
        public DateTime fechaPago { get; set; }
        public string monedaPago { get; set; }
        public string descripcionMoneda { get; set; }
        public double montoPago { get; set; }
    }
}
