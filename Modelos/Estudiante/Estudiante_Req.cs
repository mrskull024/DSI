using System.ComponentModel.DataAnnotations;

namespace Modelos.Estudiante
{
    public class Estudiante_Req
    {
        public int id { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Text)]
        public string primerNombre { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Text)]
        public string segundoNombre { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Text)]
        public string primerApellido { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Text)]
        public string segundoApellido { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Text)]
        public string numeroIdentificacion { get; set; }
        public string? numeroCarnet { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public DateTime fechaNacimiento { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public DateTime fechaIngreso { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public int edad { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Text)]
        public string celular { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Text)]
        public string correo { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Text)]
        public string numeroTelefonico { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public int idEstadoCivil { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public int idGenero { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public int idColegioSecundaria { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public int idEstadoLaboral { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public int idDepartamento { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public int idMunicipio { get; set; }
        public int idTipoEstudiante { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Text)]
        public string direccion { get; set; }
        [Range(minimum: 0, maximum: 1)]
        public bool estado { get; set; }
    }
}
