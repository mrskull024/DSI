using System.ComponentModel.DataAnnotations;

namespace Modelos.Horarios
{
    public class Horarios_Req
    {
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Text)]
        public int id { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Text)]
        public string nombre { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Text)]
        public string horaInicio { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Text)]
        public string horaFin { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [Range(minimum: 0, maximum: 1)]
        public bool estado { get; set; }
    }
}
