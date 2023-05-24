using System.ComponentModel.DataAnnotations;

namespace Modelos.Horarios
{
    public class HorariosList_Req
    {
        [Required(ErrorMessage = "{0} es requerido")]
        [Range(minimum: 0, maximum: 1)]
        public bool incluirInactivos { get; set; }
    }
}
