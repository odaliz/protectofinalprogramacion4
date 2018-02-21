using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UCSystem
{
    public class conexionsql
    {
        public static SqlConnection obtenerconexion()
        {

            SqlConnection con = new SqlConnection("Data Source = LAPTOP-TFN0CEGQ\\SQLEXPRESS01; Initial Catalog = participante; Integrated Security = True");
            con.Open();

            return con;

        }


    }
}
