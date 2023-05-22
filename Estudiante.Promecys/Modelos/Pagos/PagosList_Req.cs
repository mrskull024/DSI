using System.ComponentModel.DataAnnotations;

namespace Modelos.Pagos
{
    public class PagosList_Req
    {
        [Required(ErrorMessage = "{0} es requerido")]
        public string numeroCarnet { get; set; }
    }
}
