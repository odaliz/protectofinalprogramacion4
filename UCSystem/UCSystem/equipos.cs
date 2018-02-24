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
    public partial class equipos : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
        public equipos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string insertar = ("INSERT INTO equipos (descripcionequipo) VALUES ('" + txtdescripcion.Text + "');");
            SqlCommand command = new SqlCommand(insertar, con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Datos guardados exitosamente", "Aviso!");
            txtdescripcion.Text = "";
            txtidequipo.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtdescripcion.Text = "";
            txtidequipo.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
