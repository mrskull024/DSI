namespace Modelos.Asignaturas
{
    public class AsignaturasPorEstudiante
    {
        public int id { get; set; }
        public bool estado { get; set; }
        public int idAsignatura { get; set; }
        public string estadoAsignatura { get; set; }
        public string descripcionAsignatura { get; set; }
        public string numeroCarnet { get; set; }
        public string nombreEstudiante { get; set; }
        public int nota { get; set; }
    }
}
