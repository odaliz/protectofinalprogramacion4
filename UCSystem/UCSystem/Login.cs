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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
            con.Open();
            string consulta = "SELECT usuario FROM loginusuario WHERE idestado = 1;";
            SqlDataAdapter db = new SqlDataAdapter(consulta, con);
            DataSet ds = new DataSet();
            ds.Reset();
            db.Fill(ds);
            string usuarios = ds.Tables[0].Rows[0][0].ToString();
            cbusuario.Text = usuarios;
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
            con.Open();
            string consulta = "SELECT clave FROM loginusuario WHERE usuario = '" + cbusuario.Text + "';";
            SqlDataAdapter db = new SqlDataAdapter(consulta, con);
            DataSet ds = new DataSet();
            ds.Reset();
            db.Fill(ds);
            string clave = ds.Tables[0].Rows[0][0].ToString();
            if (clave == tbclaveusuario.Text)
            {
                Principal frm = new Principal();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Clave o usuario incorrecto", "Aviso!");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿Está seguro que desea salir del sistema?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Result == DialogResult.OK)
            {
                this.Close();
            }
            return;
        }
    }
}
