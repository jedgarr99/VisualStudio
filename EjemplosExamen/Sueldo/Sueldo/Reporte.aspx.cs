using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sueldo
{
    public partial class Reporte : System.Web.UI.Page
    {
        protected OdbcConnection agregarConexion()
        {
            try
            {
                OdbcConnection conexion = new OdbcConnection("Driver={SQL Server Native Client 11.0};Server=113dac26afv;Uid=sa;Pwd=adminadmin;Database=BDSueldo;");
                conexion.Open();
                //Label1.Text = "conexion exitossa";
                return conexion;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            OdbcConnection con = agregarConexion();
            if (con != null)
            {
                OdbcCommand cmd = new OdbcCommand("select * from informacion$", con);
                OdbcDataReader rd = cmd.ExecuteReader();
                GridView1.DataSource = rd;
                GridView1.DataBind();
            }

        }
    }
}