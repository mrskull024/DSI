namespace Modelos.Estudiante
{
    public class Estudiante_Req
    {
        public int id {  get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get;set; }
        public string numeroIdentificacion { get; set; }
        public string? numeroCarnet { get; set; }
        public string correoElectronico { get; set; }
        public string numeroTelefonico { get; set; }
        public int estadoCivil { get; set; }
        public string centroEstudiosSecundaria { get; set; }
        public bool estado { get; set; }
    }
}
