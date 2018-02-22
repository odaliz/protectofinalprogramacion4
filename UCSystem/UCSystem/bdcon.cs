using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UCSystem
{
    public class bdcon
    {
        public static SqlConnection onterneconeequipo()
        {
            SqlConnection conn = new SqlConnection("Data Source = LAPTOP-TFN0CEGQ\\SQLEXPRESS01; Initial Catalog = participante; Integrated Security = True");
            conn.Open();

            return conn;


        }





    }
}