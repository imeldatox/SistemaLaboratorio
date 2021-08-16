using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassProfesor
{
    public class LogNegocios
    {
        AccesoBD BD = new AccesoBD();
        //logueo
        public static DataTable LOGEO(string us, string corre, string celu)
        {
            AccesoBD login = new AccesoBD();
            return login.Login(us, corre, celu);
        }

        public void InsertarProfesor(int regis, string nom, string ap_pat, string ap_mat, string gener, string catego, string corre, string celula, int f_edo )
        {
            BD.ABRIR();
            BD.InsertarProfesor(regis, nom, ap_pat, ap_mat, gener, catego, corre, celula, f_edo);
            BD.CERRAR();
        }

        public void InsertarMateria(int reg_Mat, string nomMat, int hora_sem, string ext)
        {
            BD.ABRIR();
            BD.InsertarMateria(reg_Mat, nomMat, hora_sem, ext);
            BD.CERRAR();
        }

        public void InsertarProgramEducativo(int reg_Progra, string programEdu, int f_carrer, string extt)
        {
            BD.ABRIR();
            BD.InsertarProgramaEducativo(reg_Progra, programEdu, f_carrer, extt);
            BD.CERRAR();
        }

        public void InsertarCuatrimestre(int reg_Cuatr, string period, int año, string Inici, string finn, string Ex)
        {
            BD.ABRIR();
            BD.InsertarCuatrimestre(reg_Cuatr, period, año,Inici,finn, Ex);
            BD.CERRAR();
        }

        public void InsertarGrupoCuatrimestre(int f_prog_ed, int f_gru, int f_cuatri, string turn, string moda, string Exx)
        {
            BD.ABRIR();
            BD.InsertarGrupoCuatrimestre(f_prog_ed, f_gru, f_cuatri, turn, moda, Exx);
            BD.CERRAR();
        }

        public void InsertarAsignaProfeMateriaCuatri(int f_profe, int f_mat, int f_grupCua, string exx)
        {
            BD.ABRIR();
            BD.InsertarAsignaProfeMateriaCuatri(f_profe, f_mat, f_grupCua, exx);
            BD.CERRAR();
        }

        public void InsertarGradoEspecialidad(int nuRegist, string titul, string instituto, string paiss, string exttr)
        {
            BD.ABRIR();
            BD.InsertarGradoEspecialidad(nuRegist, titul, instituto, paiss,exttr);
            BD.CERRAR();
        }

        public void InsertarPerfilProfe(int f_proff, int f_grad, string estad, string fech, string evideen)
        {
            BD.ABRIR();
            BD.InsertarPerfilProfe(f_proff, f_grad, estad, fech, evideen);
            BD.CERRAR();
        }

        public void BusquedaInfoProfe(string NOM)
        {
            BD.ABRIR();
            BD.BusquedaInfoProfesor(NOM);
            BD.CERRAR();
        }

        public void BusquedaMateriasProfe(string Nom, string materi)
        {
            BD.ABRIR();
            BD.BusquedaMateriasProfesor(Nom, materi);
            BD.CERRAR();
        }

        public void BusquedaProgramaEducativoProfe(string Nomm, string per, string grup, int regiss, int gradoo)
        {
            BD.ABRIR();
            BD.BusquedaProgramaEducativoProfe(Nomm, per, grup, regiss, gradoo);
            BD.CERRAR();
        }

        public void EliminarProfe(string Nomprofe, string f_proof, int num_Re)
        {
            BD.ABRIR();
            BD.EliminarProfesor(Nomprofe, f_proof, num_Re);
            BD.CERRAR();
        }

        public void EliminarMateria(int Regmat, int reg_cua, int reg_edu, int f_pro, int f_cuat)
        {
            BD.ABRIR();
            BD.EliminarMateria(Regmat,reg_cua, reg_edu,f_pro,f_cuat);
            BD.CERRAR();
        }

        public void ModificarProfesor(string Nomprofe, string nomMod)
        {
            BD.ABRIR();
            BD.ModificarNomProfesor1(Nomprofe, nomMod);
            BD.CERRAR();
        }

        public void ModificarProfesor2(string ap_pat, string ap_patMod)
        {
            BD.ABRIR();
            BD.ModificarNomProfesor2(ap_pat, ap_patMod);
            BD.CERRAR();
        }

        public void ModificarProfesor3(string ap_mat, string apmatMod)
        {
            BD.ABRIR();
            BD.ModificarNomProfesor3(ap_mat, apmatMod);
            BD.CERRAR();
        }

        public void ModificarProfesor4(string genero, string genMod)
        {
            BD.ABRIR();
            BD.ModificarNomProfesor4(genero, genMod);
            BD.CERRAR();
        }

        public void ModificarProfesor5(string categ, string categMod)
        {
            BD.ABRIR();
            BD.ModificarNomProfesor5(categ, categMod);
            BD.CERRAR();
        }

        public void ModificarProfesor6(string correoo, string correMod)
        {
            BD.ABRIR();
            BD.ModificarNomProfesor6(correoo, correMod);
            BD.CERRAR();
        }

        public void ModificarProfesor7(string celula, string celularMod)
        {
            BD.ABRIR();
            BD.ModificarNomProfesor7(celula, celularMod);
            BD.CERRAR();
        }

        public void ModificarPerfilProfe1(string estadoo, string estadoMod)
        {
            BD.ABRIR();
            BD.ModificarPerfilProfe1(estadoo, estadoMod);
            BD.CERRAR();
        }

        public void ModificarPerfilProfesor2(string fechObt, string fechObtMod)
        {
            BD.ABRIR();
            BD.ModificarPerfilProfe2(fechObt, fechObtMod);
            BD.CERRAR();
        }

        public void ModificarPerfilProfesor3(string eviden, string evidenMod)
        {
            BD.ABRIR();
            BD.ModificarPerfilProfe3(eviden, evidenMod);
            BD.CERRAR();
        }

        public void ModificarGradoEspecialidad1(string Titul, string TitulMod)
        {
            BD.ABRIR();
            BD.ModificarGradoEspecial1(Titul, TitulMod);
            BD.CERRAR();
        }

        public void ModificarGradoEspecialidad2(string intitut, string InstitutoMod)
        {
            BD.ABRIR();
            BD.ModificarGradoEspecial2(intitut, InstitutoMod);
            BD.CERRAR();
        }

        public void ModificarGradoEspecialidad3(string paiss, string paissMod)
        {
            BD.ABRIR();
            BD.ModificarGradoEspecial3(paiss, paissMod);
            BD.CERRAR();
        }

        public void ModificarGradoEspecialidad4(string exx, string exxMod)
        {
            BD.ABRIR();
            BD.ModificarGradoEspecial4(exx, exxMod);
            BD.CERRAR();
        }

        public void ModificarAsignaProfeMateriaCuatri(string extA, string extAMod)
        {
            BD.ABRIR();
            BD.ModificarAsignaProfeMateriaCuatri(extA, extAMod);
            BD.CERRAR();
        }

        public DataSet MostrarUsuario(SqlConnection acepta)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet cajaGrande = new DataSet();
            string querySQL = "select Nombre from Profesor";
            if (acepta != null)
            {//si la conexion esta abierta se va a cargamos el carrito
                carrito.CommandText = querySQL;
                carrito.Connection = acepta;
                trailer.SelectCommand = carrito;
                try
                {//mandar el trailer a la base de datos y obtener los resultados en el DataSet
                    trailer.Fill(cajaGrande);
                }
                catch (Exception f)
                {
                    cajaGrande = null;
                }
            }
            else
            {
                cajaGrande = null;
            }
            return cajaGrande;
        }

        public DataSet MostrarCorreo(SqlConnection acepta)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet cajaGrande = new DataSet();
            string querySQL = "select Correo from Profesor";
            if (acepta != null)
            {//si la conexion esta abierta se va a cargamos el carrito
                carrito.CommandText = querySQL;
                carrito.Connection = acepta;
                trailer.SelectCommand = carrito;
                try
                {//mandar el trailer a la base de datos y obtener los resultados en el DataSet
                    trailer.Fill(cajaGrande);
                }
                catch (Exception f)
                {
                    cajaGrande = null;
                }
            }
            else
            {
                cajaGrande = null;
            }
            return cajaGrande;
        }

        public DataSet MostrarCelular(SqlConnection acepta)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet cajaGrande = new DataSet();
            string querySQL = "select Celular from Profesor";
            if (acepta != null)
            {//si la conexion esta abierta se va a cargamos el carrito
                carrito.CommandText = querySQL;
                carrito.Connection = acepta;
                trailer.SelectCommand = carrito;
                try
                {//mandar el trailer a la base de datos y obtener los resultados en el DataSet
                    trailer.Fill(cajaGrande);
                }
                catch (Exception f)
                {
                    cajaGrande = null;
                }
            }
            else
            {
                cajaGrande = null;
            }
            return cajaGrande;
        }

        public DataSet UltimoRegistro(SqlConnection acepta)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet cajaGrande = new DataSet();
            string querySQL = "select * from Profesor";
            if (acepta != null)
            {//si la conexion esta abierta se va a cargamos el carrito
                carrito.CommandText = querySQL;
                carrito.Connection = acepta;
                trailer.SelectCommand = carrito;
                try
                {//mandar el trailer a la base de datos y obtener los resultados en el DataSet
                    trailer.Fill(cajaGrande);
                }
                catch (Exception f)
                {
                    cajaGrande = null;
                }
            }
            else
            {
                cajaGrande = null;
            }
            return cajaGrande;
        }

        public DataSet BusInterior(SqlConnection acepta)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet cajaGrande = new DataSet();
            string querySQL = "select * from ProfeInfo";
            if (acepta != null)
            {//si la conexion esta abierta se va a cargamos el carrito
                carrito.CommandText = querySQL;
                carrito.Connection = acepta;
                trailer.SelectCommand = carrito;
                try
                {//mandar el trailer a la base de datos y obtener los resultados en el DataSet
                    trailer.Fill(cajaGrande);
                }
                catch (Exception f)
                {
                    cajaGrande = null;
                }
            }
            else
            {
                cajaGrande = null;
            }
            return cajaGrande;
        }

        public DataSet BusExterior(SqlConnection acepta)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet cajaGrande = new DataSet();
            string querySQL = "select * from ProfeMaterGrup";
            if (acepta != null)
            {//si la conexion esta abierta se va a cargamos el carrito
                carrito.CommandText = querySQL;
                carrito.Connection = acepta;
                trailer.SelectCommand = carrito;
                try
                {//mandar el trailer a la base de datos y obtener los resultados en el DataSet
                    trailer.Fill(cajaGrande);
                }
                catch (Exception f)
                {
                    cajaGrande = null;
                }
            }
            else
            {
                cajaGrande = null;
            }
            return cajaGrande;
        }

        public DataSet BuscarProfesor(SqlConnection abierta, string conexio)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet cajaGrande = new DataSet();
            string querySQL = "select * from ProfeInfo where Nombre_Profesor = '" + conexio + "';";
            if (abierta != null)
            {//si la conexion esta abierta se va a cargamos el carrito
                carrito.CommandText = querySQL;
                carrito.Connection = abierta;
                trailer.SelectCommand = carrito;
                try
                {//mandar el trailer a la base de datos y obtener los resultados en el DataSet
                    trailer.Fill(cajaGrande);
                }
                catch (Exception f)
                {
                    cajaGrande = null;
                }
            }
            else
            {
                cajaGrande = null;
            }
            return cajaGrande;
        }


        public DataSet BuscarMateria(SqlConnection abierta, string conexio, string con)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet cajaGrande = new DataSet();
            string querySQL = "select * from ProfeMaterGrup where Nombre_Maestr@ = '" + conexio + "' and Materia_Especialidad = '" + con + "'";
            if (abierta != null)
            {//si la conexion esta abierta se va a cargamos el carrito
                carrito.CommandText = querySQL;
                carrito.Connection = abierta;
                trailer.SelectCommand = carrito;
                try
                {//mandar el trailer a la base de datos y obtener los resultados en el DataSet
                    trailer.Fill(cajaGrande);
                }
                catch (Exception f)
                {
                    cajaGrande = null;
                }
            }
            else
            {
                cajaGrande = null;
            }
            return cajaGrande;
        }


        public DataSet BuscarProgramaEducativo(SqlConnection abierta, string conexio, string con, string buena, int uno, int grad)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet cajaGrande = new DataSet();
            string querySQL = "select Nombre Nombre_Profesor, Letra Grupos, Grado Grados, NombeMateria Nombre_Materias, ProgramaEd Programas_Educativos_Pertenecientes from Profesor, Cuatrimestre,Grupo, Materia, ProgramaEducativo " +
                "where Nombre = '" + conexio + "' and Periodo = '" + con + "' and Letra = '" + buena + "' and RegistroEmpleado = '" + uno + "' and Grado = '" + grad + "'";
            if (abierta != null)
            {//si la conexion esta abierta se va a cargamos el carrito
                carrito.CommandText = querySQL;
                carrito.Connection = abierta;
                trailer.SelectCommand = carrito;
                try
                {//mandar el trailer a la base de datos y obtener los resultados en el DataSet
                    trailer.Fill(cajaGrande);
                }
                catch (Exception f)
                {
                    cajaGrande = null;
                }
            }
            else
            {
                cajaGrande = null;
            }
            return cajaGrande;
        }

        public DataSet Programa(SqlConnection acepta)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet cajaGrande = new DataSet();
            string querySQL = "select * from ProfeMaterGrup";
            if (acepta != null)
            {//si la conexion esta abierta se va a cargamos el carrito
                carrito.CommandText = querySQL;
                carrito.Connection = acepta;
                trailer.SelectCommand = carrito;
                try
                {//mandar el trailer a la base de datos y obtener los resultados en el DataSet
                    trailer.Fill(cajaGrande);
                }
                catch (Exception f)
                {
                    cajaGrande = null;
                }
            }
            else
            {
                cajaGrande = null;
            }
            return cajaGrande;
        }


        public DataSet Educa(SqlConnection acepta)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet cajaGrande = new DataSet();
            string querySQL = "select *  from ProfeCuatri";
            if (acepta != null)
            {//si la conexion esta abierta se va a cargamos el carrito
                carrito.CommandText = querySQL;
                carrito.Connection = acepta;
                trailer.SelectCommand = carrito;
                try
                {//mandar el trailer a la base de datos y obtener los resultados en el DataSet
                    trailer.Fill(cajaGrande);
                }
                catch (Exception f)
                {
                    cajaGrande = null;
                }
            }
            else
            {
                cajaGrande = null;
            }
            return cajaGrande;
        }


        public DataSet Perfil(SqlConnection acepta)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet cajaGrande = new DataSet();
            string querySQL = "select * from ProfeInfo";
            if (acepta != null)
            {//si la conexion esta abierta se va a cargamos el carrito
                carrito.CommandText = querySQL;
                carrito.Connection = acepta;
                trailer.SelectCommand = carrito;
                try
                {//mandar el trailer a la base de datos y obtener los resultados en el DataSet
                    trailer.Fill(cajaGrande);
                }
                catch (Exception f)
                {
                    cajaGrande = null;
                }
            }
            else
            {
                cajaGrande = null;
            }
            return cajaGrande;
        }

        public DataSet GradoEspecialidads(SqlConnection acepta)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet cajaGrande = new DataSet();
            string querySQL = "select * from GradoEspecialidad";
            if (acepta != null)
            {//si la conexion esta abierta se va a cargamos el carrito
                carrito.CommandText = querySQL;
                carrito.Connection = acepta;
                trailer.SelectCommand = carrito;
                try
                {//mandar el trailer a la base de datos y obtener los resultados en el DataSet
                    trailer.Fill(cajaGrande);
                }
                catch (Exception f)
                {
                    cajaGrande = null;
                }
            }
            else
            {
                cajaGrande = null;
            }
            return cajaGrande;
        }
    }
}
