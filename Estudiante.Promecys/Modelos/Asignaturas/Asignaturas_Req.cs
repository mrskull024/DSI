namespace Modelos.Asignaturas
{
    public class Asignaturas_Req
    {
        public int Id { get; set; }
        public bool Estado { get; set; }
        public int IdF_Cuatrimestre { get; set; }
        public string DescripcionCuatrimestre { get; set; }
        public int Anio_Asignatura { get; set; }
        public string Descripcion_Asignatura { get; set; }
    }
}
