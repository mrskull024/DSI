namespace Modelos.Catalogos
{
    public class Municipios
    {
        public int id { get; set; }
        public int idDepartamento { get; set; }
        public bool estado { get; set; }
        public string municipio { get; set; }
        public string departamento { get; set; }
    }
}
