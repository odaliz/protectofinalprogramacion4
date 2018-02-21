using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace UCSystem
{
    public class claMovimientos
    {
        SqlConnection con = new SqlConnection(@"Data Source=WINDOWS-TP6EBH6\SQLEXPRESS01;Initial Catalog=UCSystem_SQLServer;Integrated Security=True;");
        public void Guardar(claEquipos equip)
        {
            try
            {
                string strSql = "insertar_movimientos";
                SqlCommand cmd = new SqlCommand(strSql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@matricula", equip.matricula);
                cmd.Parameters.AddWithValue("@serieequipo", equip.serieequipo);
                cmd.Parameters.AddWithValue("@idestado", equip.idestado);
                cmd.Parameters.AddWithValue("@fechaestado", equip.fechaestado);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
            }
        }
    }

    }
