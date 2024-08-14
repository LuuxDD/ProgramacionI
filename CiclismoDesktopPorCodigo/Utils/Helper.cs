using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiclismoDesktopPorCodigo.Utils
{
    public class Helper
    {
        public static SqlConnection CrearConexion()
        { 
             string connectionString = "Server=.\\SQLEXPRESS; database=Ciclismo; user id=sa; password=123; multipleactiveresultsets=true; Encrypt=false";
            SqlConnection conex = new SqlConnection(connectionString);
            conex.Open();
            return conex;
        }
    }

}
