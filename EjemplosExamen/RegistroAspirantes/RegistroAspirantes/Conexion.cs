using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RegistroAspirantes
{
    class Conexion
    {
        public static SqlConnection agregarConexion()
        {
            SqlConnection conexion = new SqlConnection("Data Source=CC102-16\\SA;Initial Catalog=baseAspirantes;User ID=sa;Password=adminadmin");
            conexion.Open();
            return conexion;
        }
        public static void llenarCombo(ComboBox cb)
        {
            try
            {
                SqlConnection con = agregarConexion();
                if (con != null)
                {
                    SqlCommand cmd = new SqlCommand("select nombre from programas", con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        cb.Items.Add(rd.GetString(0));

                    }
                    cb.SelectedIndex = 0;
                    rd.Close();
                    con.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        public static void llenarCombo2(ComboBox cb)
        {
            try
            {
                SqlConnection con = agregarConexion();
                if (con != null)
                {
                    SqlCommand cmd = new SqlCommand("select nombre from aspirantes", con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        cb.Items.Add(rd.GetString(0));

                    }
                    cb.SelectedIndex = 0;
                    rd.Close();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
