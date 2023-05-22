using System.ComponentModel.DataAnnotations;

namespace Modelos.Catalogos
{
    public class EstadoCivilList_Req
    {
        [Required(ErrorMessage = "{0} es requerido")]
        public bool incluirDesactivados {  get; set; }
    }
}