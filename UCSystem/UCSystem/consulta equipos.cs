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
    public partial class consulta_equipos : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
        public consulta_equipos()
        {
            InitializeComponent();
        }

        private void consulta_equipos_Load(object sender, EventArgs e)
        {
            con.Open();
            DataTable dtret = new DataTable();
            string sql = "select idequipo as ID, descripcionequipo as Descripción_Equipo from equipos";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtret);
            dgvequipos.DataSource = dtret;
            con.Close();
            dgvequipos.Columns[0].Width = 50;
            dgvequipos.Columns[1].Width = 300;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rdbID.Checked == true)
            {
                buscarporid();
            }
            else if (rbdDescripcion.Checked == true)
            {
                buscarpordescripcion();
            }
        }
            private void buscarpordescripcion()
        {
            con.Open();
            DataTable dtret = new DataTable();
            string sql = "select idequipo,descripcionequipo from equipos where descripcionequipo like '%" + txtbuscar.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtret);
            dgvequipos.DataSource = dtret;
            con.Close();
        }
        private void buscarporid()
        {
            con.Open();
            DataTable dtret = new DataTable();
            string sql = "select idequipo,descripcionequipo from equipos where idequipo like '%" + txtbuscar.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtret);
            dgvequipos.DataSource = dtret;
            con.Close();
        }
    }
}
