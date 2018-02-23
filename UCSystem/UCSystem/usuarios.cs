using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCSystem
{
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
            con.Open();
            string consulta = "SELECT codigoempleado FROM empleados;";
            SqlDataAdapter db = new SqlDataAdapter(consulta, con);
            DataSet ds = new DataSet();
            ds.Reset();
            db.Fill(ds);
            string codigos = ds.Tables[0].Rows[0][0].ToString();
            cbcodempleado.Text = codigos;
            string consulta2 = "SELECT tipousuario FROM tiposusuarios;";
            SqlDataAdapter db2 = new SqlDataAdapter(consulta2, con);
            DataSet ds2 = new DataSet();
            ds2.Reset();
            db2.Fill(ds2);
            string tiposusua = ds2.Tables[0].Rows[0][0].ToString();
            cbtiposusuarios.Text = tiposusua;
        }
    }
}
