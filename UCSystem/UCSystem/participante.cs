using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace claseparticipante
{
   class participante

    {
        public SqlConnection conex = new SqlConnection(@"Server=SERVERMIT2\SQLEXPRESS;Database=Universidad;Trusted_Connection=True;");

        public void ejecutarsql(string strsql)

{

    SqlCommand con = new SqlCommand(strsql, conex);
            con.CommandType = System.Data.CommandType.Text;
            conex.Open();
            con.ExecuteNonQuery();
            con.Connection.Close();
            conex.Close();



     
    
    
    

     


    }
}
}