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
    public partial class consultaparticipante : Form
    {
        public consultaparticipante()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            participantes par = new participantes();
            DataGridViewRow rellenar = dvparticipantes.Rows[e.RowIndex];
            par.txtmatriculap.Text = rellenar.Cells["matricula"].Value.ToString();
            par.txtnombrep.Text = rellenar.Cells["nombres"].Value.ToString();
            par.txtapellidop.Text = rellenar.Cells["apellidos"].Value.ToString();
            par.txtcedulap.Text = rellenar.Cells["cedula"].Value.ToString();
            par.txtdireccionp.Text = rellenar.Cells["direccion"].Value.ToString();
            par.txtmatriculap.Enabled = false;
            par.Show();
        }

        private void consultaparticipante_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
            con.Open();
            DataTable dtret = new DataTable();
            string sql = "select * from participantes";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtret);
            dvparticipantes.DataSource = dtret;

            con.Close();
        }

        private void buscarpornombre()
        {
            SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
            con.Open();
            DataTable dtret = new DataTable();
            string sql = "select matricula, nombres, apellidos,cedula,direccion from participantes where nombres like '%" + txtbuscar.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtret);
            dvparticipantes.DataSource = dtret;
            con.Close();
        }
        private void buscarporapellido()
        {
            SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
            con.Open();
            DataTable dtret = new DataTable();
            string sql = "select matricula, nombres, apellidos,cedula,direccion from participantes where apellidos like '%" + txtbuscar.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtret);
            dvparticipantes.DataSource = dtret;
            con.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rdbnombre.Checked == true)
            {
                buscarpornombre();
            }
            else if (rbdapellido.Checked == true)
            {
                buscarporapellido();
            }
        }
    }
}
