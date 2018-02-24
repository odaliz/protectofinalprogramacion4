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
    public partial class Consulta_Empledados : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
        public Consulta_Empledados()
        {
            InitializeComponent();
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void mostrardatos()
        {
            con.Open();
            DataTable dtret = new DataTable();
            string sql = "select   codigoempleado as Codigo, nombre as Nombre, apellido as Apellido, cedula as Cédula, direccion as Dirección, sueldo as Sueldo , descripcioncargo as Cargo from empleados  inner join cargos on empleados.idcargo =cargos.idcargo";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtret);
            dgvempleados.DataSource = dtret;

            con.Close();
        }

        private void buscarpornombre()
        {
            con.Open();
            DataTable dtret = new DataTable();
            string sql = "select  codigoempleado as Codigo, nombre as Nombre, apellido as Apellido, cedula as Cédula, direccion as Dirección, sueldo as Sueldo, descripcioncargo as Cargo  from empleados  inner join cargos on empleados.idcargo = cargos.idcargo where empleados.nombre  like '%" + txtbuscar.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtret);
            dgvempleados.DataSource = dtret;
            con.Close();
        }
        private void buscarporapellido()
        {
            con.Open();
            DataTable dtret = new DataTable();
            string sql = "select   codigoempleado as Codigo, nombre as Nombre, apellido as Apellido, cedula as Cédula, direccion as Dirección, sueldo as Sueldo, descripcioncargo as Cargo  from empleados  inner join cargos on empleados.idcargo = cargos.idcargo where empleados.apellido  ='" + txtbuscar.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtret);
            dgvempleados.DataSource = dtret;
            con.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rdbnombre.Checked == true)
            {
                buscarpornombre();
            }
            else if (rbdapellido.Checked == true)
            {
                buscarporapellido();
            }
        }

        private void Consulta_Empledados_Load_1(object sender, EventArgs e)
        {
            mostrardatos();
        }

        private void dgvempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Empleado emp = new Empleado();
            DataGridViewRow rellenar = dgvempleados.Rows[e.RowIndex];
            //emp.txtcodigoemple.Text = rellenar.Cells["Codigo"].Value.ToString();
            emp.tbnombre.Text = rellenar.Cells["Nombre"].Value.ToString();
            emp.tbapellido.Text = rellenar.Cells["Apellido"].Value.ToString();
            emp.tbcedula.Text = rellenar.Cells["Cédula"].Value.ToString();
            emp.tbdireccion.Text = rellenar.Cells["Dirección"].Value.ToString();
            emp.cbcargo.Text = rellenar.Cells["Cargo"].Value.ToString();
            emp.Show();
        }
    }

}
