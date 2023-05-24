using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Common
{
    public class DSI_BaseDAL
    {
        public string ConnectionString { get; set; }

        public DSI_BaseDAL(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
