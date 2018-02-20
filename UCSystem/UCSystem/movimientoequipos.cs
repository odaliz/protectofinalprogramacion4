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
    public partial class movimientoequipos : Form
    {
        public movimientoequipos()
        {
            InitializeComponent();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            claEquipos equip = new claEquipos();
            claMovimientos da = new claMovimientos();
            equip.matricula = tbMatricula.Text;
            equip.serieequipo = tbSerieequipo.Text;
            equip.idestado = Convert.ToInt16(cbEstado.Text);
            equip.fechaestado = tbFecha.Text;
            da.Guardar(equip); MessageBox.Show("Registro Guardado !");
        }
    }
}
