namespace Modelos.Login
{
    public class Usuario_Res
    {
        public int id {  get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string correoElectronico { get; set; }
        public string contrasena { get; set; }
        public string tokenSession { get; set; }
        public bool rol { get; set; }
        public bool estado { get; set; }
    }
}
