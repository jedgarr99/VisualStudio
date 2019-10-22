using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaSessionCookies
{
    public partial class Pagina1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//un refrescamiento de la página para que solo lo haga primera vez
            {//la página es la primera vez o es un retroceso
                Application.Lock();// para que no se incremente de manera inecesaria 
                Application["Usuarios"] = Convert.ToInt16(Application["Usuarios"]) + 1;
                Application.UnLock();
                lbContador.Text = Application["Usuarios"].ToString();
            }
            Page.Title = (String)Application["Empresa"];//le ponemos nombre a la pestaña de la págna que asingamos en la global.asax

        }

        protected void btCambio_Click(object sender, EventArgs e)
        {
            Session["sesion"] = tbUsuario.Text;
            HttpCookie cookie1 = new HttpCookie("contrasena", tbContraseña.Text);
            cookie1.Expires = new DateTime(2019, 12, 25);
            Response.Cookies.Add(cookie1);
            Response.Redirect("Pagina2.aspx");

        }
    }
}