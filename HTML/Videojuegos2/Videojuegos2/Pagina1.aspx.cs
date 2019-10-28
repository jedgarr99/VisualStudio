using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace Videojuegos2
{
    public partial class Pagina1 : System.Web.UI.Page
    {
        protected OdbcConnection conectarBD()
        {
            String stringConexion = "Driver={SQL Server Native Client 11.0};Server=112SALAS10;Uid=sa;Pwd=sqladmin;Database=GameSpot";
            try
            {
                OdbcConnection conexion = new OdbcConnection(stringConexion);
                conexion.Open();
                lbContador.Text = "conexion exitosa";
                return conexion;
            }
            catch (Exception ex)
            {
                lbContador.Text = ex.StackTrace.ToString();
                return null;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            OdbcConnection miConexion = conectarBD();

        }

        //Boton para checar contraseña y mandar a la siguiente pagina
        protected void btPagina2_Click(object sender, EventArgs e)
        {
            OdbcConnection miConexion = conectarBD();
            

            if (miConexion != null)
            {
                String query = " select claveU from usuario where email = '" + txUsuario.Text + "'and password = '" + txContraseña.Text + "'";
                OdbcCommand cmd = new OdbcCommand(query, miConexion);
                OdbcDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    Session["claveUnica"] = rd.GetInt32(0).ToString(); //se guarda para otras paginas
                    Response.Redirect("Pagina2.aspx");  //Manda a otra pagina
                }
                else
                    lbContador.Text = " el usuario o contraseña son incorrectos";
                rd.Close();
            }
        }
    }
}