using System.ComponentModel.DataAnnotations;

namespace Modelos.Catalogos
{
    public class EstadoLaboralList_Req
    {
        [Required(ErrorMessage = "{0} es requerido")]
        public bool incluirDesactivados {  get; set; }
    }
}
