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
    public partial class Empleado : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
        public Empleado()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            con.Open();
            string cargo = "SELECT idcargo FROM cargos WHERE descripcioncargo = '" + cbcargo.Text + "';";
            SqlDataAdapter db = new SqlDataAdapter(cargo, con);
            DataSet ds = new DataSet();
            ds.Reset();
            db.Fill(ds, "cargos");
            string idcargo = ds.Tables[0].Rows[0][0].ToString();
            string insertar = ("INSERT INTO empleados (nombre, apellido, cedula, direccion, idcargo, sueldo) VALUES ('" + tbnombre.Text + "', '" + tbapellido.Text + "','" + tbcedula.Text + "','" + tbdireccion.Text + "','" + idcargo + "','" + tbsueldo.Text + "');");
            SqlCommand command = new SqlCommand(insertar, con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Datos guardados exitosamente", "Aviso!");
            tbnombre.Text = "";
            tbapellido.Text = "";
            tbcedula.Text = "";
            tbdireccion.Text = "";
            tbsueldo.Text = "";
            cbcargo.Text = "";
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "SELECT descripcioncargo FROM cargos;";
            SqlDataAdapter db = new SqlDataAdapter(consulta, con);
            DataSet ds = new DataSet();
            ds.Reset();
            db.Fill(ds, "cargos");
            string codigos = ds.Tables[0].Rows[0][0].ToString();
            cbcargo.DataSource = ds.Tables[0].DefaultView;
            cbcargo.ValueMember = "descripcioncargo";
            con.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbnombre.Text = "";
            tbapellido.Text = "";
            tbcedula.Text = "";
            tbdireccion.Text = "";
            tbsueldo.Text = "";
            cbcargo.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
