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
        public SqlConnection con = new SqlConnection("Data Source = LAPTOP-TFN0CEGQ\\SQLEXPRESS01; Initial Catalog = participante; Integrated Security = True");
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
            SqlCommand cmd =  con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert Into participantes values('" + txtmatriculap.Text + "', ' " + txtnombrep.Text + "', ' " + txtapellidop.Text + "',  ' " + txtcedulap.Text + "', ' " + txtdireccionp.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Registro Insertado correctamente");

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