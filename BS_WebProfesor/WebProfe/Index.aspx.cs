using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ClassProfesor;

namespace WebProfe
{
    public partial class Index : System.Web.UI.Page
    {
        LogNegocios ob2 = new LogNegocios();
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox4.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable tabla = LogNegocios.LOGEO(txtUsuario.Text, txtRFC.Text, txtContraseña.Text);
            try
            {
                if (tabla.Rows.Count == 0)
                {
                    TextBox4.Visible = true;
                    TextBox4.Text = "No existe el usuario" + "Sistema Login";//, Response.Write.OK, MessageBoxIcon.Error);   
                }
                else
                {
                    Response.Redirect("Plataforma.aspx");
                    //se obtiene el tipo de acceso del usuario, puse mas restricciones
                    //obj.tipoUser = tabla.Rows[0][3].ToString();
                    //obj.nombre = tabla.Rows[0][1].ToString();
                    //obj.ShowDialog();
                    //this.Hide();
                }
            }
            catch (Exception f)
            {
                TextBox4.Visible = true;
                TextBox4.Text = "No existe el usuario" + "Sistema Login" + f;
            }
        }
    }
}