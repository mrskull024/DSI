namespace Modelos.Matricula
{
    public class Matricula_Res
    {
        public int id {  get; set; }
        public int estudianteId { get; set; }
        public int horario1 { get; set; }
        public int? horario2 { get; set;}
        public int? horario3 { get; set;}
        public int? horario4 { get; set;}
        public DateTime fechaRegistro { get; set; }
        public bool estado { get; set; }
    }
}
