using System.ComponentModel.DataAnnotations;

namespace Modelos.Asignaturas
{
    public class AsignaturasPorEstudianteList_Req
    {
        [Required(ErrorMessage = "{0} es requerido")]
        public string numeroCarnet { get; set; }
    }
}
