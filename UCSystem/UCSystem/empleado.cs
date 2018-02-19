using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCSystem
{
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtapellidoem.Text = " ";
            txtcedulaem.Text = "";
            txtcodigoemple.Text = "";
            txtdireccionem.Text = "";
            txtnombreem.Text = "";
            cmb.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
