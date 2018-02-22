using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UCSystem
{
    public class equipodb
    {

        public static int agrer(claseequipo equip)
        {
            int retorno = 0;
            using (SqlConnection conn = bdcon.onterneconeequipo())
            {
                SqlCommand comando = new SqlCommand(string.Format(" insert into equipos ( idequipo,descripcionequipo  ) values ( '{0}','{1}')", equip.idequipo, equip.descripcionequipo), conn);

                retorno = comando.ExecuteNonQuery();
            }


            return retorno;


        }


    }
}
