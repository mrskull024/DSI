using System.ComponentModel.DataAnnotations;

namespace Modelos.Estudiante
{
    public class EstudianteList_Req
    {
        [Required(ErrorMessage = "{0} es requerido")]
        [Range(minimum: 0, maximum: 1)]
        public bool incluirInactivos { get; set; }
    }
}
