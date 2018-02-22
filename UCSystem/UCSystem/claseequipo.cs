using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UCSystem
{
    public class claseequipo
    {
        public int idequipo { get; set; }
        public string descripcionequipo { get; set; }

        public claseequipo() { }

        public claseequipo(int idequipo, string descripcionequipo)
        {

            this.idequipo = idequipo;
            this.descripcionequipo = descripcionequipo;



        }

    }
}
