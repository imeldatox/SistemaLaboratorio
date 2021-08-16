using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using ClassProfesor;

namespace WebProfe
{
    public partial class Plataforma : System.Web.UI.Page
    {
        AccesoBD ob1 = new AccesoBD();
        LogNegocios ob2 = new LogNegocios();
        Agregar ob3 = new Agregar();
        SqlDataReader Lector;
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
           

            if (!IsPostBack)
            {
                DropDownList38.Items.Add(ob3.casado);//EstadoCivil
                DropDownList38.Items.Add(ob3.divorciado);
                DropDownList38.Items.Add(ob3.concubinato);
                DropDownList38.Items.Add(ob3.ProcesoSepracion);
                DropDownList38.Items.Add(ob3.soltero);
                DropDownList38.Items.Add(ob3.Viudo);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            DataSet contenedor = new DataSet();
            DataSet cont = new DataSet();
            DataSet con = new DataSet();
            ob1.ABRIR();
            contenedor = ob2.MostrarUsuario(ob1.CONEXION);
            cont = ob2.MostrarCelular(ob1.CONEXION);
            con = ob2.MostrarCorreo(ob1.CONEXION);
            ob1.CERRAR();
            if (contenedor != null || cont != null || con != null)
            {
                GridView4.DataSource = contenedor.Tables[0];
                GridView4.DataBind();
                GridView5.DataSource = cont.Tables[0];
                GridView5.DataBind();
                GridView6.DataSource = con.Tables[0];
                GridView6.DataBind();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Panel3.Visible = true;
            Panel2.Visible = true;
            Label128.Visible = true;
            Label20.Visible = true;
            Label21.Visible = true;
            Label22.Visible = true;
            Label23.Visible = true;
            Label24.Visible = true;
            DataSet contenedor = new DataSet();
            ob1.ABRIR();
            contenedor = ob2.UltimoRegistro(ob1.CONEXION);
            ob1.CERRAR();
            if (contenedor != null)
            {
                GridView9.DataSource = contenedor.Tables[0];
                GridView9.DataBind();
            }
        }

        protected void Button27_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            Label129.Visible = true;
            Label128.Visible = true;
            Label21.Visible = true;
            Label22.Visible = true;
            Label23.Visible = true;
            Label24.Visible = true;
            if (TextBox45.Text == "" || TextBox43.Text == "" || TextBox32.Text == "" || TextBox44.Text == "" || TextBox1.Text == "" || TextBox29.Text == "" || TextBox2.Text == "" || TextBox31.Text == "")
            {
                Label169.Visible = true;
                Label169.Text = "Datos no ingresados correctamente";
            }
            else
            {
                ob2.InsertarProfesor(Convert.ToInt32(TextBox45.Text),TextBox43.Text,TextBox32.Text,TextBox44.Text,TextBox1.Text,TextBox29.Text,TextBox2.Text,TextBox31.Text, Convert.ToInt32(DropDownList38.SelectedItem.ToString()));
                Label169.Visible = true;
                Label169.Text = "Datos ingresados correctamente";
            }
        }

        protected void Button29_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            Label129.Visible = true;
            Label128.Visible = true;
            Label21.Visible = true;
            Label22.Visible = true;
            Label23.Visible = true;
            Label24.Visible = true;
            if (TextBox46.Text == "" || TextBox33.Text == "" || TextBox34.Text == "" || TextBox3.Text == "" || TextBox47.Text == "")
            {
                Label29.Visible = true;
                Label29.Text = "Insercion no realizada";
            }
            else
            {
                ob2.InsertarPerfilProfe(Convert.ToInt32(TextBox46.Text), Convert.ToInt32(TextBox33.Text), TextBox34.Text, TextBox47.Text, TextBox3.Text);
                Label29.Visible = true;
                Label29.Text = "Insercion realizada";
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            Label129.Visible = true;
            Label128.Visible = true;
            Label21.Visible = true;
            Label22.Visible = true;
            Label23.Visible = true;
            Label24.Visible = true;
            if (TextBox50.Text=="" || TextBox48.Text == "" || TextBox49.Text == "" || TextBox35.Text == "" || TextBox4.Text == "")
            {
                Label29.Visible = true;
                Label29.Text = "Datos no Guardados";
            }
            else
            {
                ob2.InsertarGradoEspecialidad(Convert.ToInt32(TextBox50.Text),TextBox48.Text,TextBox49.Text, TextBox35.Text, TextBox4.Text);
                Label29.Visible = true;
                Label29.Text = "Datos Guardados";
            }
        }

        protected void Button48_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            Label129.Visible = true;
            Label128.Visible = true;
            Label21.Visible = true;
            Label22.Visible = true;
            Label23.Visible = true;
            Label24.Visible = true;
            if (TextBox52.Text == "" || TextBox53.Text == "" || TextBox54.Text == "" || TextBox51.Text == "")
            {
                Label29.Visible = true;
                Label29.Text = "Datos no Guardados";
            }
            else
            {
                ob2.InsertarAsignaProfeMateriaCuatri(Convert.ToInt32(TextBox51.Text),Convert.ToInt32(TextBox52.Text), Convert.ToInt32(TextBox53.Text),TextBox54.Text);
                Label29.Visible = true;
                Label29.Text = "Datos Guardados";
            }
        }

        protected void Button30_Click(object sender, EventArgs e)
        {
            try
            {
                Panel2.Visible = true;
                Panel3.Visible = true;
                if (TextBox28.Text == "" || TextBox24.Text == "" || TextBox27.Text == "" || TextBox5.Text == "")
                {
                    Label170.Visible = true;
                    Label170.Text = "Insecion no realizada";
                }
                else
                {
                    ob2.InsertarMateria(Convert.ToInt32(TextBox5.Text),TextBox28.Text, Convert.ToInt32(TextBox24.Text), TextBox27.Text);
                    Label170.Visible = true;
                    Label170.Text = "Insecion realizada";
                }
            }
            catch (Exception)
            {
                Label170.Visible = true;
                Label170.Text = "Insecion no realizada";
            }
        }

        protected void Button31_Click(object sender, EventArgs e)
        {
            try
            {
                Panel2.Visible = true;
                Panel3.Visible = true;
                if (TextBox36.Text == "" || TextBox6.Text == "" || TextBox55.Text == "" || TextBox56.Text == "")
                {
                    Label56.Visible = true;
                    Label56.Text = "Insercion no realizada";
                }
                else
                {
                    ob2.InsertarProgramEducativo(Convert.ToInt32 (TextBox36.Text), TextBox55.Text, Convert.ToInt32(TextBox6.Text), TextBox56.Text);
                    Label56.Visible = true;
                    Label56.Text = "Insercion realizada";
                }
            }
            catch (Exception)
            {
                Label56.Visible = true;
                Label56.Text = "Insercion no realizada";
            }
        }

        protected void Button32_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            Panel3.Visible = true;
            try
            {
                if (TextBox37.Text == "" || TextBox7.Text == "" || TextBox57.Text == "" || TextBox60.Text=="" || TextBox58.Text==""|| TextBox59.Text=="")
                {
                    Label170.Visible = true;
                    Label170.Text = "Insercion no realizada";
                }
                else
                {
                    ob2.InsertarCuatrimestre(Convert.ToInt32(TextBox57.Text), TextBox37.Text, Convert.ToInt32(TextBox7.Text),TextBox58.Text,TextBox59.Text, TextBox60.Text);
                    Label170.Visible = true;
                    Label170.Text = "Insercion realizada";
                }
            }
            catch (Exception)
            {
                Label170.Visible = true;
                Label170.Text = "Insercion no realizada";
            }
        }

        protected void Button11_Click1(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            Panel3.Visible = true;
            try
            {
                if (TextBox63.Text=="" || TextBox26.Text == "" || TextBox38.Text == "" || TextBox8.Text == ""|| TextBox61.Text=="" || TextBox62.Text=="")
                {
                    Label56.Visible = true;
                    Label56.Text = "Datos no Guardados";
                }
                else
                {
                    ob2.InsertarGrupoCuatrimestre(Convert.ToInt32(TextBox63.Text), Convert.ToInt32(TextBox26.Text), Convert.ToInt32(TextBox38.Text), TextBox8.Text, TextBox61.Text, TextBox62.Text);
                    Label56.Visible = true;
                    Label56.Text = "Datos Guardados con Exito";
                }
            }
            catch (Exception)
            {
                Label56.Visible = true;
                Label56.Text = "Datos no Guardados";
            }
        }

        protected void Button46_Click(object sender, EventArgs e)
        {

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Panel4.Visible = true;
        }

        protected void Button35_Click1(object sender, EventArgs e)
        {
            try
            {
                if (TextBox9.Text == "" || TextBox42.Text == "" || TextBox64.Text == "" )
                {
                    Label56.Visible = true;
                    Label56.Text = "Datos no Eliminados";
                }
                else
                {
                    ob2.EliminarProfe(TextBox9.Text,TextBox42.Text, Convert.ToInt32(TextBox64.Text));
                    Label56.Visible = true;
                    Label56.Text = "Datos Eliminados con Exito";
                }
            }
            catch (Exception)
            {
                Label56.Visible = true;
                Label56.Text = "Datos no Eliminados intenta mas tarde";
            }

        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox9.Text == "" || TextBox42.Text == "" || TextBox64.Text == "")
                {
                    Label56.Visible = true;
                    Label56.Text = "Datos no Eliminados";
                }
                else
                {
                    ob2.EliminarMateria(Convert.ToInt32(TextBox10.Text), Convert.ToInt32(TextBox40.Text), Convert.ToInt32(TextBox11.Text),Convert.ToInt32(TextBox39.Text), Convert.ToInt32(TextBox12.Text));
                    Label56.Visible = true;
                    Label56.Text = "Datos Eliminados con Exito";
                }
            }
            catch (Exception)
            {
                Label56.Visible = true;
                Label56.Text = "Datos no Eliminados intenta mas tarde";
            }
        }

        protected void Button40_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void Button47_Click1(object sender, EventArgs e)
        {
            Panel7.Visible = true;
            DataSet contenedor = new DataSet();
            DataSet con = new DataSet();
            ob1.ABRIR();
            contenedor = ob2.BusInterior(ob1.CONEXION);
            con = ob2.BusExterior(ob1.CONEXION);
            ob1.CERRAR();
            if (contenedor != null || con != null)
            {
                GridView10.DataSource = contenedor.Tables[0];
                GridView10.DataBind();
                GridView11.DataSource = con.Tables[0];
                GridView11.DataBind();
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Panel7.Visible = true;
            if (TextBox16.Text == "")
            {
                Label118.Visible = true;
                Label118.Text = "Busqueda No realizada ingrese correctamente";
            }
            else
            {
                try
                {
                    Panel8.Visible = true;
                    Label118.Visible = true;
                    Label118.Text = "Busqueda Realizada";
                    DataSet contenedor = new DataSet();
                    ob1.ABRIR();
                    contenedor = ob2.BuscarProfesor(ob1.CONEXION, TextBox16.Text);
                    ob1.CERRAR();
                    if (contenedor != null)
                    {
                        GridView3.DataSource = contenedor.Tables[0];
                        GridView3.DataBind();
                    }
                }
                catch (Exception f)
                {
                    Label118.Visible = true;
                    Label118.Text = "Busqueda No realizada ingrese correctamente " + f;
                }
            }
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            Panel7.Visible = true;
            if (TextBox16.Text == "")
            {
                Label118.Visible = true;
                Label118.Text = "Busqueda No realizada ingrese correctamente";
            }
            else
            {
                try
                {
                    Panel8.Visible = true;
                    Label118.Visible = true;
                    Label118.Text = "Busqueda Realizada";
                    DataSet contenedor = new DataSet();
                    ob1.ABRIR();
                    contenedor = ob2.BuscarMateria(ob1.CONEXION, TextBox17.Text, TextBox18.Text);
                    ob1.CERRAR();
                    if (contenedor != null)
                    {
                        GridView3.DataSource = contenedor.Tables[0];
                        GridView3.DataBind();
                    }
                }
                catch (Exception f)
                {
                    Label118.Visible = true;
                    Label118.Text = "Busqueda No realizada ingrese correctamente " + f;
                }
            }
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            Panel7.Visible = true;
            if (TextBox16.Text == "")
            {
                Label118.Visible = true;
                Label118.Text = "Busqueda No realizada ingrese correctamente";
            }
            else
            {
                try
                {
                    Panel8.Visible = true;
                    Label118.Visible = true;
                    Label118.Text = "Busqueda Realizada";
                    DataSet contenedor = new DataSet();
                    ob1.ABRIR();
                    contenedor = ob2.BuscarProgramaEducativo(ob1.CONEXION, TextBox19.Text, TextBox20.Text, TextBox21.Text,Convert.ToInt32(TextBox22.Text),Convert.ToInt32(TextBox23.Text));
                    ob1.CERRAR();
                    if (contenedor != null)
                    {
                        GridView3.DataSource = contenedor.Tables[0];
                        GridView3.DataBind();
                    }
                }
                catch (Exception f)
                {
                    Label118.Visible = true;
                    Label118.Text = "Busqueda No realizada ingrese correctamente " + f;
                }
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Panel6.Visible = true;
            DataSet contenedor = new DataSet();
            DataSet con = new DataSet();
            DataSet contener = new DataSet();
            DataSet contiene = new DataSet();
            ob1.ABRIR();
            contenedor = ob2.Programa(ob1.CONEXION);
            con = ob2.Educa(ob1.CONEXION);
            contener = ob2.Perfil(ob1.CONEXION);
            contiene = ob2.GradoEspecialidads(ob1.CONEXION);
            ob1.CERRAR();
            if (contenedor != null || con != null || contener != null || contiene != null)
            {
                GridView2.DataSource = contenedor.Tables[0];
                GridView2.DataBind();
                GridView13.DataSource = con.Tables[0];
                GridView13.DataBind();
                GridView1.DataSource = contener.Tables[0];
                GridView1.DataBind();
                GridView14.DataSource = contiene.Tables[0];
                GridView14.DataBind();
            }
        }
    }
}