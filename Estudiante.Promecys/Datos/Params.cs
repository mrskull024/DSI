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
        #region SP_Estado_Civil
        public string spEstadosCivilesList => "[dbo].[uspListarEstadosCiviles]";
        #endregion

        #region SP_Asignaturas
        public string spAsignaturasList => "[dbo].[uspListarAsignaturas]";
        #endregion

        #region SP_Horarios
        public string spHorariosList => "[DSI].[uspListarHorarios]";
        public string spUpdateHorarios => "[DSI].[uspUpdateHorarios]";
        public string spCreateHorarios => "[DSI].[uspCreateHorarios]";
        public string spGetHorarios => "[DSI].[uspGetHorarios]";
        #endregion

        #region SP_Matricula
        public string spMatriculaSave => "[dbo].[uspRegistarMatricula]";
        public string spMatriculaUpdate => "[dbo].[uspActualizarMatricula]";
        public string spMatriculaGet => "[dbo].[uspObtenerMatricula]";
        #endregion

        #region SP_Estudiante
        public string spEstudianteGet => "[dbo].[uspObtenerMatricula]";
        #endregion

        #region SP_Login
        public string spLoginSave => "[dbo].[uspRegistarLogin]";
        public string spLoginUpdate => "[dbo].[uspActualizarLogin]";
        public string spLoginGet => "[dbo].[uspObtenerLogin]";
        #endregion
    }
}
