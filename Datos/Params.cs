namespace Datos
{
    public class Params : Object
    {
        private static Params _instance;
        public static Params instance => _instance ?? new Params();

        //pasamos el nombre de la DB, esto nos sirve por si se usa mas de una 
        //db solo vamos declarandola
        #region DBs
        public string DB_DSI = "DSI_API_DB";
        #endregion

        //Sp's
        #region SP_Asignaturas
        public string spAsignaturasList => "[DSI].[uspListarAsignaturas]";
        public string spAsignaturasPorEstudiante => "[DSI].[UspListarAsignaturasPorEstudiante]";
        #endregion

        #region SP_Horarios
        public string spHorariosList => "[DSI].[uspListarHorarios]";
        public string spUpdateHorarios => "[DSI].[uspUpdateHorarios]";
        public string spCreateHorarios => "[DSI].[uspCreateHorarios]";
        public string spGetHorarios => "[DSI].[uspGetHorarios]";
        #endregion

        #region SP_Pagos
        public string spObtenerPagosPorEstudiante => "[DSI].[usp_ObtenerPagosPorEstudiante]";
        #endregion

        #region SP_Estudiante
        public string spEstudianteList => "[DSI].[uspListarEstudiantes]";
        public string spUpdateEstudiante => "[DSI].[UpdateEstudiante]";
        public string spCreateEstudiante => "[DSI].[CreateEstudiante]";
        public string spGetEstudiante => "[DSI].[uspGetEstudiante]";
        #endregion

        #region SP_Catalogos
        public string spEstadoCivilList => "[DSI].[uspListarEstadoCivil]";
        public string spDepartamentosList => "[DSI].[uspListarDepartamentos]";
        public string spMunicipiosList => "[DSI].[uspListarMunicipios]";
        public string spEstadoLaboralList => "[DSI].[usp_ListarEstadoLaboral]";
        public string spGenerosList => "[DSI].[usp_ListarGeneros]";
        public string spTipoEstudianteList => "[DSI].[usp_ListarTipoEstudiante]";
        public string spEscuelasList => "[DSI].[usp_ListarEscuelas]";
        #endregion
    }
}
