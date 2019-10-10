using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usoControles
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ddColores.Items.Count == 0)
            {
                ddColores.Items.Add("Rojo");
                ddColores.Items.Add("Azul");
                ddColores.Items.Add("Amarillo");
                ddColores.Items.Add("Verde");
            }

            if(rbSabores.Items.Count == 0)
            {
                rbSabores.Items.Add("vainilla");
                rbSabores.Items.Add("fresa");
                rbSabores.Items.Add("vainilla con fresa");
            }
            if (cbCafe.Items.Count == 0)
            {
                cbCafe.Items.Add("Fresa");
                cbCafe.Items.Add("Pistache");
                cbCafe.Items.Add("Bisteck");

            }
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = 0;
            seleccion = ddColores.SelectedIndex;
            lbColores.Text = "indice seleccionado  " + seleccion.ToString();

            Session["controles"] = "cambio al DropDownList";//informacion entre paginas 
            lbSession.Text = Session["controles"].ToString();
            //AutoPostBack-> True
        }

        protected void rbSabores_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbIndiceS.Text = "Indice Seleccionado: " + rbSabores.SelectedIndex.ToString();
            lbContenidoS.Text = "El contenido es: " + rbSabores.SelectedValue.ToString();

            Session["controles"] = "cambio al RadioButton";//informacion entre paginas 
            lbSession.Text = Session["controles"].ToString();
        }

        protected void cbCafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            ListBox1.Items.Clear();
            ListBox2.Items.Clear();
            for (i=0; i < cbCafe.Items.Count; i++)
            {
                if (cbCafe.Items[i].Selected == true)
                {
                    ListBox1.Items.Add(i.ToString());
                    ListBox2.Items.Add(cbCafe.Items[i].Value.ToString());
                }

            }
            Session["controles"] = "cambio al CheckBoxList";//informacion entre paginas 
            lbSession.Text = Session["controles"].ToString();

        }
    }
}