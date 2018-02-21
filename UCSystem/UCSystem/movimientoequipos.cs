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
        public void Buscar()
        {
            //try
            //{
            //    SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
            //    con.Open();
            //    string consulta = "SELECT mov.matricula AS Matrícula, mov.serieequipo AS Série, est.descripcionestado AS Estado, mov.fechaestado AS Fecha FROM movimientosequipos mov INNER JOIN estados est ON est.descripcionestado = mov.idestado";
            //    SqlDataAdapter db = new SqlDataAdapter(consulta, con);
            //    DataSet ds = new DataSet();
            //    ds.Reset();
            //    DataTable dt = new DataTable();
            //    db.Fill(ds);
            //    dt = ds.Tables[0];
            //    dataGridView1.DataSource = dt;
            //    dataGridView1.Columns[0].Width = 60;
            //    dataGridView1.Columns[1].Width = 80;
            //    dataGridView1.Columns[2].Width = 70;
            //    dataGridView1.Columns[3].Width = 65;
            //    con.Close();
            //}
            //catch (Exception ex)
            //{

            //}
        }
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
            con.Open();
            string consulta = "SELECT idestado FROM estados WHERE descripcionestado = '" + cbEstado.Text + "';";
            SqlDataAdapter db = new SqlDataAdapter(consulta, con);
            DataSet ds = new DataSet();
            ds.Reset();
            db.Fill(ds);
            string estados = ds.Tables[0].Rows[0][0].ToString();
            try
            {

                claEquipos equip = new claEquipos();
                claMovimientos da = new claMovimientos();
                equip.matricula = tbMatricula.Text;
                equip.serieequipo = tbSerieequipo.Text;
                equip.idestado = Convert.ToInt16(estados);
                equip.fechaestado = tbFecha.Text;
                da.Guardar(equip); MessageBox.Show("Registro Guardado !");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor complete todos los datos", "Aviso!");
            }

}

        private void tsbParticipantes_Click(object sender, EventArgs e)
        {
            consultaparticipante frm = new consultaparticipante();
            frm.Show();
        }

        private void tsbEquipos_Click(object sender, EventArgs e)
        {
            consulta_equipos frm = new consulta_equipos();
            frm.Show();
        }
        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
                con.Open();
                if (tsbcampobuscar.Text == "")
                {
                    string consulta = "SELECT mov.matricula AS Matrícula, mov.serieequipo AS Série, est.descripcionestado AS Estado, mov.fechaestado AS Fecha FROM movimientosequipos mov INNER JOIN estados est ON est.idestado = mov.idestado";
                    SqlDataAdapter db = new SqlDataAdapter(consulta, con);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].Width = 55;
                    dataGridView1.Columns[1].Width = 80;
                    dataGridView1.Columns[2].Width = 63;
                    dataGridView1.Columns[3].Width = 72;
                    con.Close();
                }
                else
                {
                    string consulta = "SELECT mov.matricula AS Matrícula, mov.serieequipo AS Série, est.descripcionestado AS Estado, mov.fechaestado AS Fecha FROM movimientosequipos mov INNER JOIN estados est ON est.idestado = mov.idestado WHERE mov.matricula LIKE '%" + tsbcampobuscar.Text + "%'";
                    SqlDataAdapter db = new SqlDataAdapter(consulta, con);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].Width = 55;
                    dataGridView1.Columns[1].Width = 80;
                    dataGridView1.Columns[2].Width = 63;
                    dataGridView1.Columns[3].Width = 72;
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT descripcionestado FROM estados ORDER BY descripcionestado ", con);
            da.Fill(ds, "descripcionestado");
            cbEstado.DataSource = ds.Tables[0].DefaultView;
            cbEstado.ValueMember = "descripcionestado";
            tbFecha.Enabled = true;
            tbMatricula.Enabled = true;
            tbSerieequipo.Enabled = true;
            cbEstado.Enabled = true;
            tsbGuardar.Enabled = true;
        }

        private void movimientoequipos_Load(object sender, EventArgs e)
        {

        }
    }
}
