using System.ComponentModel.DataAnnotations;

namespace Modelos.Estudiante
{
    public class EstudianteGet_Req
    {
        [Required(ErrorMessage = "{0} es requerido")]
        public string numeroCarnet { get; set; }
    }
}
