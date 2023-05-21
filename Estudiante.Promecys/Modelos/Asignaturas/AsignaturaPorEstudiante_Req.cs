namespace Modelos.Asignaturas
{
    public class AsignaturasPorEstudiante_Req
    {
        public int Id { get; set; }
        public bool Estado { get; set; }
        public int idAsignatura { get; set; }
        public string EstadoAsignatura { get; set; }
        public string DescripcionAsignatura { get; set; }
        public int idEstudiante { get; set; }
        public string nombreEstudiante { get; set; }
    }
}
