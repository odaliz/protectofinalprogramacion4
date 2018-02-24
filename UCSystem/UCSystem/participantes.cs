using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace UCSystem
{
    public partial class participantes : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
        public participantes()

        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string insertar = ("INSERT INTO participantes (matricula, nombres, apellidos, cedula, direccion) VALUES ('" + txtmatriculap.Text + "', '" + txtnombrep.Text + "','" + txtapellidop.Text + "','" + txtcedulap.Text + "','" + txtdireccionp.Text + "');");
            SqlCommand command = new SqlCommand(insertar, con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Datos guardados exitosamente", "Aviso!");
            txtdireccionp.Text = "";
            txtmatriculap.Text = "";
            txtnombrep.Text = "";
            txtapellidop.Text = "";
            txtcedulap.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtapellidop.Text = "";
            txtcedulap.Text = "";
            txtdireccionp.Text = "";
            txtmatriculap.Text = "";
            txtnombrep.Text = "";
        }
    }
}