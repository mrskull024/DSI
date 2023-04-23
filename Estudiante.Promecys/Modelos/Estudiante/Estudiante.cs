namespace Modelos.Estudiante
{
    public class Estudiante
    {
        public int id {  get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get;set; }
        public string numeroIdentificacion { get; set; }
        public string? numeroCarnet { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaIngreso { get; set; }
        public int edad { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }
        public string numeroTelefonico { get; set; }
        public int idEstadoCivil { get; set; }
        public int idGenero { get; set; }
        public int idColegioSecundaria { get; set; }
        public int idEstadoLaboral { get; set; }
        public int idDepartamento { get; set; }
        public int idMunicipio { get; set; }
        public int idTipoEstudiante { get; set; }
        public string direccion { get; set; }
        public bool estado { get; set; }
    }
}
