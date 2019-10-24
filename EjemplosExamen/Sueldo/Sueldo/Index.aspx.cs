using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sueldo
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bSiguiente_Click(object sender, EventArgs e)
        {
            Session["nombre"] = tbNombre.Text;
            Response.Redirect("Sueldo.aspx");
        }

        protected void bReporte_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reporte.aspx");
        }
    }
}