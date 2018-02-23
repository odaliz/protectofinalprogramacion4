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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Seguro que desea salir del sistema", "Saliendo del sistema - UCSystem", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void participantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            participantes abrir = new participantes();
            abrir.Show();
              
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            equipos abrir = new equipos();
            abrir.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado abrir = new Empleado();
            abrir.Show();
        }

        private void participantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultaparticipante on = new consultaparticipante();
            on.Show();
        }

        private void movimientosEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movimientoequipos frm = new movimientoequipos();
            frm.Show();
        }

        private void equiposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consulta_equipos on = new consulta_equipos();
            on.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_Empledados on = new Consulta_Empledados();
            on.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarios frm = new usuarios();
            frm.ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventario frm = new inventario();
            frm.Show();
        }
    }
}
