using System.ComponentModel.DataAnnotations;

namespace Modelos.Catalogos
{
    public class GenerosList_Req
    {
        [Required(ErrorMessage = "{0} es requerido")]
        public bool incluirDesactivados {  get; set; }
    }
}
