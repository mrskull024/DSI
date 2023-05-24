using System.ComponentModel.DataAnnotations;

namespace Modelos.Asignaturas
{
    public class AsignaturasList_Req
    {
        [Required(ErrorMessage = "{0} es requerido")]
        public bool incluirDesactivados {  get; set; }
    }
}
