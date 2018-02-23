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
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT descripcionestado FROM estados ORDER BY descripcionestado", con);
            da.Fill(ds, "descripcionestado");
            cbEstado.DataSource = ds.Tables[0].DefaultView;
            cbEstado.ValueMember = "descripcionestado";

            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT descripcionequipo FROM equipos ORDER BY descripcionequipo", con);
            da2.Fill(ds2, "descripcionequipo");
            cbdescripequipos.DataSource = ds2.Tables[0].DefaultView;
            cbdescripequipos.ValueMember = "descripcionequipo";

            tbSerieequipo.Enabled = true;
            cbEstado.Enabled = true;
            cbdescripequipos.Enabled = true;
            tsbGuardar.Enabled = true;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
            con.Open();
            string estados = "SELECT idestado FROM estados WHERE descripcionestado = '" + cbEstado.Text + "';";
            SqlDataAdapter db = new SqlDataAdapter(estados, con);
            DataSet ds = new DataSet();
            ds.Reset();
            db.Fill(ds, "estados");
            string idestado = ds.Tables[0].Rows[0][0].ToString();

            string equipos = "SELECT idequipo FROM equipos WHERE descripcionequipo = '" + cbdescripequipos.Text + "';";
            SqlDataAdapter dbequipos = new SqlDataAdapter(equipos, con);
            DataSet dsequipos = new DataSet();
            dsequipos.Reset();
            dbequipos.Fill(dsequipos, "equipos");
            string numequipo = dsequipos.Tables[0].Rows[0][0].ToString();

            string insertar = ("INSERT INTO inventario (idequipo, serieequipo, idestado) VALUES ('" + numequipo + "','" + tbSerieequipo.Text + "','" + idestado + "');");
            SqlCommand command = new SqlCommand(insertar, con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Datos guardados exitosamente", "Aviso!");
            cbEstado.Text = "";
            cbdescripequipos.Text = "";
            tbSerieequipo.Text = "";
            cbEstado.Enabled = false;
            cbdescripequipos.Enabled = false;
            tbSerieequipo.Enabled = false;
        }

        private void inventario_Load(object sender, EventArgs e)
        {
            
        }

        private void tsbEquipos_Click(object sender, EventArgs e)
        {
            consulta_equipos frm = new consulta_equipos();
            frm.ShowDialog();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
                con.Open();
                if (tsbcampobuscar.Text == "")
                {
                    string consulta = "SELECT inv.idequipo AS Número, inv.serieequipo AS Série, est.descripcionestado AS Estado, equip.descripcionequipo AS Equipo FROM inventario inv INNER JOIN equipos equip ON equip.idequipo = inv.idequipo INNER JOIN estados est ON est.idestado = inv.idestado";
                    SqlDataAdapter db = new SqlDataAdapter(consulta, con);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].Width = 45;
                    dataGridView1.Columns[1].Width = 80;
                    dataGridView1.Columns[2].Width = 75;
                    dataGridView1.Columns[3].Width = 130;
                    con.Close();
                }
                else
                {
                    string consulta = "SELECT inv.idequipo AS Número, inv.serieequipo AS Série, est.descripcionestado AS Estado, equip.descripcionequipo AS Equipo FROM inventario inv INNER JOIN equipos equip ON equip.idequipo = inv.idequipo INNER JOIN estados est ON est.idestado = inv.idestado WHERE equip.descripcionequipo LIKE '%" + tsbcampobuscar.Text + "%'";
                    SqlDataAdapter db = new SqlDataAdapter(consulta, con);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    DataTable dt = new DataTable();
                    db.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].Width = 45;
                    dataGridView1.Columns[1].Width = 80;
                    dataGridView1.Columns[2].Width = 75;
                    dataGridView1.Columns[3].Width = 130;
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
    }
