using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RegistroAspirantes
{
    class Aspirante
    {
        public String nombre, apellidoPaterno, apellidoMaterno, sexo, correo, fecghaNac;
        public int grado, programas;

        public Aspirante(string nombre, string apellidoPaterno, string apellidoMaterno, string sexo, string correo, string fecghaNac, int grado, int programas)
        {
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.sexo = sexo;
            this.correo = correo;
            this.fecghaNac = fecghaNac;
            this.grado = grado;
            this.programas = programas;
        }

        public Aspirante()
        {
        }
        public String alta(Aspirante a)
        {
            String res = "";
            int i = 0;
            try
            {
                SqlConnection con = Conexion.agregarConexion();
                SqlCommand cmd = new SqlCommand("select max(idAspirante) from aspirantes", con);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    i = rd.GetInt32(0) + 1;
                    rd.Close();
                    SqlCommand cmd2 = new SqlCommand(String.Format("insert into aspirantes values ({0}, '{1}','{2}','{3}','{4}','{5}','{6}',{7},{8})",i,a.nombre,a.apellidoPaterno,apellidoMaterno,a.sexo,a.correo,a.fecghaNac,a.grado,a.programas), con);
                }
                else
                {
                    rd.Close();
                    SqlCommand cmd2 = new SqlCommand(String.Format("insert into aspirantes values ({0}, '{1}','{2}','{3}','{4}','{5}','{6}',{7},{8})", 0, a.nombre, a.apellidoPaterno, apellidoMaterno, a.sexo, a.correo, a.fecghaNac, a.grado, a.programas), con);
                }
                res = "alta exitosa";
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Alta no exitosa " + ex);
                res = "alta no exitosa";
            }

            return res;
        }
        public String modifica(int programa, String nombre)
        {
            String res = "";
            try
            {
                SqlConnection con = Conexion.agregarConexion();
                SqlCommand cmd = new SqlCommand("select max(idAspirante) from aspirantes", con);
            } catch(Exception ex)
            {

                res = "modifica no exitosa";
            }
            return res;


        }

}
