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
        SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
        public usuarios()
        {
            InitializeComponent();
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "SELECT codigoempleado FROM empleados;";
            SqlDataAdapter db = new SqlDataAdapter(consulta, con);
            DataSet ds = new DataSet();
            ds.Reset();
            db.Fill(ds,"empleados");
            string codigos = ds.Tables[0].Rows[0][0].ToString();
            cbcodempleado.DataSource = ds.Tables[0].DefaultView;
            cbcodempleado.ValueMember = "codigoempleado";
            string consulta2 = "SELECT tipousuario FROM tiposusuarios;";
            SqlDataAdapter db2 = new SqlDataAdapter(consulta2, con);
            DataSet ds2 = new DataSet();
            ds2.Reset();
            db2.Fill(ds2,"tiposusuarios");
            cbtiposusuarios.DataSource = ds2.Tables[0].DefaultView;
            cbtiposusuarios.ValueMember = "tipousuario";
        }

        private void btnguardarusuario_Click(object sender, EventArgs e)
        {
            con.Open();
            string tipo = "SELECT idtipousuario FROM tiposusuarios WHERE tipousuario = '" + cbtiposusuarios.Text + "';";
            SqlDataAdapter db = new SqlDataAdapter(tipo, con);
            DataSet ds = new DataSet();
            ds.Reset();
            db.Fill(ds, "tiposusuarios");
            string idtipo = ds.Tables[0].Rows[0][0].ToString();
            string insertar = ("INSERT INTO loginusuario (codigoempleado, usuario, idtipousuario, clave, idestado) VALUES (" + Convert.ToInt16(cbcodempleado.Text) + ", '" + tbusuario.Text + "'," + Convert.ToInt16(idtipo) + ",'" + tbclave.Text + "',1)");
            SqlCommand command = new SqlCommand(insertar, con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Datos guardados exitosamente", "Aviso!");
            cbcodempleado.Text = "";
            cbtiposusuarios.Text = "";
            tbclave.Text = "";
            tbusuario.Text = "";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
