using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassProfesor
{
    public class AccesoBD
    {
        public string cadeConex { get; set; }
        public SqlConnection CONEXION = new SqlConnection();
        public SqlCommand COMANDO = new SqlCommand();

        public AccesoBD()
        {
			string CadCon = (@"Data Source = GRM\SQLEXPRESS; Initial Catalog = BD_Inventario; Integrated Security = false; user = Imelda; pwd = Lord012097");
            CONEXION = new SqlConnection(CadCon);
            COMANDO.Connection = CONEXION;
            
        }

        public bool ABRIR()
        {
            try
            {
                CONEXION.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public SqlConnection AbrirConexion(ref string msj)
        {
            SqlConnection cn1 = new SqlConnection();
            cn1.ConnectionString = cadeConex;

            try
            {
                cn1.Open();
                msj = "Conexion abierta";
            }
            catch (Exception h)
            {
                cn1 = null;
                msj = "Error" + h.Message;
            }
            return cn1;
        }

        public void CERRAR()
        {
            CONEXION.Close();
        }

        public DataTable Login(string usu, string correo, string cel)
        {
            DataTable login = new DataTable("Login");
            SqlConnection sql = new SqlConnection();
            try
            {
                sql.ConnectionString = CONEXION.ConnectionString;

                SqlCommand sqlCm = new SqlCommand("LOGEO", sql);
                sqlCm.CommandType = CommandType.StoredProcedure;

                sqlCm.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usu;
                sqlCm.Parameters.Add("@corr", SqlDbType.VarChar).Value = correo;
                sqlCm.Parameters.Add("@celul", SqlDbType.VarChar).Value = cel;

                SqlDataAdapter sqlAdp = new SqlDataAdapter(sqlCm);
                sqlAdp.Fill(login);

            }
            catch
            {
                login = null;
            }
            return login;
        }


        public string InsertarProfesor(int regi, string nombre, string ap_pat, string ap_mat, string genero, string categoria, string correo, string celular, int f_edo_civil)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[9];
                paramD[0] = new SqlParameter("@reg", SqlDbType.Int);
                paramD[0].Value = regi;
                paramD[1] = new SqlParameter("@nombre", SqlDbType.VarChar);
                paramD[1].Value = nombre;
                paramD[2] = new SqlParameter("@ap_pat", SqlDbType.VarChar);
                paramD[2].Value = ap_pat;
                paramD[3] = new SqlParameter("@ap_Mat", SqlDbType.VarChar);
                paramD[3].Value = ap_mat;
                paramD[4] = new SqlParameter("@genero", SqlDbType.VarChar);
                paramD[4].Value = genero;
                paramD[5] = new SqlParameter("@catego", SqlDbType.VarChar);
                paramD[5].Value = categoria;
                paramD[6] = new SqlParameter("@correo", SqlDbType.VarChar);
                paramD[6].Value = correo;
                paramD[7] = new SqlParameter("@celular", SqlDbType.VarChar);
                paramD[7].Value = celular;
                paramD[8] = new SqlParameter("@f_edo_civil", SqlDbType.TinyInt);
                paramD[8].Value = f_edo_civil;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_Profesor";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[9];
                paramD[0] = new SqlParameter("@reg", SqlDbType.Int);
                paramD[0].Value = regi;
                paramD[1] = new SqlParameter("@nombre", SqlDbType.VarChar);
                paramD[1].Value = nombre;
                paramD[2] = new SqlParameter("@ap_pat", SqlDbType.VarChar);
                paramD[2].Value = ap_pat;
                paramD[3] = new SqlParameter("@ap_Mat", SqlDbType.VarChar);
                paramD[3].Value = ap_mat;
                paramD[4] = new SqlParameter("@genero", SqlDbType.VarChar);
                paramD[4].Value = genero;
                paramD[5] = new SqlParameter("@catego", SqlDbType.VarChar);
                paramD[5].Value = categoria;
                paramD[6] = new SqlParameter("@correo", SqlDbType.VarChar);
                paramD[6].Value = correo;
                paramD[7] = new SqlParameter("@celular", SqlDbType.VarChar);
                paramD[7].Value = celular;
                paramD[8] = new SqlParameter("@f_edo_civil", SqlDbType.TinyInt);
                paramD[8].Value = f_edo_civil;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_Profesor";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }

        public string InsertarMateria(int regMat, string nom_materi, int horas_sem, string extra)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[4];
                paramD[0] = new SqlParameter("@regmat", SqlDbType.Int);
                paramD[0].Value = regMat;
                paramD[1] = new SqlParameter("@nom_mat", SqlDbType.VarChar);
                paramD[1].Value = nom_materi;
                paramD[2] = new SqlParameter("@horas_sem", SqlDbType.TinyInt);
                paramD[2].Value = horas_sem;
                paramD[3] = new SqlParameter("@extra", SqlDbType.VarChar);
                paramD[3].Value = extra;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_Materia";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[4];
                paramD[0] = new SqlParameter("@regmat", SqlDbType.Int);
                paramD[0].Value = regMat;
                paramD[1] = new SqlParameter("@nom_mat", SqlDbType.VarChar);
                paramD[1].Value = nom_materi;
                paramD[2] = new SqlParameter("@horas_sem", SqlDbType.TinyInt);
                paramD[2].Value = horas_sem;
                paramD[3] = new SqlParameter("@extra", SqlDbType.VarChar);
                paramD[3].Value = extra;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_Materia";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string InsertarProgramaEducativo(int registr, string programa_edu, int f_carrera, string extra)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[4];
                paramD[0] = new SqlParameter("@registro", SqlDbType.Int);
                paramD[0].Value = registr;
                paramD[1] = new SqlParameter("@program_edu", SqlDbType.VarChar);
                paramD[1].Value = programa_edu;
                paramD[2] = new SqlParameter("@f_carrera", SqlDbType.TinyInt);
                paramD[2].Value = f_carrera;
                paramD[3] = new SqlParameter("@extra", SqlDbType.VarChar);
                paramD[3].Value = extra;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_ProgramaEducativo";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[4];
                paramD[0] = new SqlParameter("@registro", SqlDbType.Int);
                paramD[0].Value = registr;
                paramD[1] = new SqlParameter("@program_edu", SqlDbType.VarChar);
                paramD[1].Value = programa_edu;
                paramD[2] = new SqlParameter("@f_carrera", SqlDbType.TinyInt);
                paramD[2].Value = f_carrera;
                paramD[3] = new SqlParameter("@extra", SqlDbType.VarChar);
                paramD[3].Value = extra;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_ProgramaEducativo";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }



        public string InsertarCuatrimestre(int registroCuatri, string periodo, int anio, string inicio, string fin, string extraa)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[6];
                paramD[0] = new SqlParameter("@registroCua", SqlDbType.Int);
                paramD[0].Value = registroCuatri;
                paramD[1] = new SqlParameter("@periodo", SqlDbType.VarChar);
                paramD[1].Value = periodo;
                paramD[2] = new SqlParameter("@anio", SqlDbType.Int);
                paramD[2].Value = anio;
                paramD[3] = new SqlParameter("@inicio", SqlDbType.Date);
                paramD[3].Value = inicio;
                paramD[4] = new SqlParameter("@fin", SqlDbType.Date);
                paramD[4].Value = fin;
                paramD[5] = new SqlParameter("@extra", SqlDbType.VarChar);
                paramD[5].Value = extraa;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_Cuatrimestre";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[6];
                paramD[0] = new SqlParameter("@registroCua", SqlDbType.Int);
                paramD[0].Value = registroCuatri;
                paramD[1] = new SqlParameter("@periodo", SqlDbType.VarChar);
                paramD[1].Value = periodo;
                paramD[2] = new SqlParameter("@anio", SqlDbType.Int);
                paramD[2].Value = anio;
                paramD[3] = new SqlParameter("@inicio", SqlDbType.Date);
                paramD[3].Value = inicio;
                paramD[4] = new SqlParameter("@fin", SqlDbType.Date);
                paramD[4].Value = fin;
                paramD[5] = new SqlParameter("@extra", SqlDbType.VarChar);
                paramD[5].Value = extraa;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_Cuatrimestre";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string InsertarGrupoCuatrimestre(int f_prog_edo, int f_grupo, int f_cuatrimes, string turno, string modalidad, string extras)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[6];
                paramD[0] = new SqlParameter("@f_prog_ed", SqlDbType.Int);
                paramD[0].Value = f_prog_edo;
                paramD[1] = new SqlParameter("@f_grupo", SqlDbType.Int);
                paramD[1].Value = f_grupo;
                paramD[2] = new SqlParameter("@f_cuatri", SqlDbType.Int);
                paramD[2].Value = f_cuatrimes;
                paramD[3] = new SqlParameter("@turno", SqlDbType.VarChar);
                paramD[3].Value = turno;
                paramD[4] = new SqlParameter("@modalidad", SqlDbType.VarChar);
                paramD[4].Value = modalidad;
                paramD[5] = new SqlParameter("@extra", SqlDbType.VarChar);
                paramD[5].Value = extras;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_GrupoCuatrimestre";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[6];
                paramD[0] = new SqlParameter("@f_prog_ed", SqlDbType.Int);
                paramD[0].Value = f_prog_edo;
                paramD[1] = new SqlParameter("@f_grupo", SqlDbType.Int);
                paramD[1].Value = f_grupo;
                paramD[2] = new SqlParameter("@f_cuatri", SqlDbType.Int);
                paramD[2].Value = f_cuatrimes;
                paramD[3] = new SqlParameter("@turno", SqlDbType.VarChar);
                paramD[3].Value = turno;
                paramD[4] = new SqlParameter("@modalidad", SqlDbType.VarChar);
                paramD[4].Value = modalidad;
                paramD[5] = new SqlParameter("@extra", SqlDbType.VarChar);
                paramD[5].Value = extras;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_GrupoCuatrimestre";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string InsertarAsignaProfeMateriaCuatri(int f_prof, int f_mater, int f_grupoCua, string exxtra)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[4];
                paramD[0] = new SqlParameter("@f_prof", SqlDbType.SmallInt);
                paramD[0].Value = f_prof;
                paramD[1] = new SqlParameter("@f_mater", SqlDbType.SmallInt);
                paramD[1].Value = f_mater;
                paramD[2] = new SqlParameter("@f_grupCua", SqlDbType.Int);
                paramD[2].Value = f_grupoCua;
                paramD[3] = new SqlParameter("@extr", SqlDbType.VarChar);
                paramD[3].Value = exxtra;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_AsignaProfeMateriaCuatri";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[4];
                paramD[0] = new SqlParameter("@f_prof", SqlDbType.SmallInt);
                paramD[0].Value = f_prof;
                paramD[1] = new SqlParameter("@f_mater", SqlDbType.SmallInt);
                paramD[1].Value = f_mater;
                paramD[2] = new SqlParameter("@f_grupCua", SqlDbType.Int);
                paramD[2].Value = f_grupoCua;
                paramD[3] = new SqlParameter("@extr", SqlDbType.VarChar);
                paramD[3].Value = exxtra;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_AsignaProfeMateriaCuatri";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string InsertarGradoEspecialidad(int num_registro, string titulo, string institucion, string pais, string Extr)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[4];
                paramD[0] = new SqlParameter("@num_regis", SqlDbType.Int);
                paramD[0].Value = num_registro;
                paramD[1] = new SqlParameter("@titulo", SqlDbType.VarChar);
                paramD[1].Value = titulo;
                paramD[2] = new SqlParameter("@institucion", SqlDbType.VarChar);
                paramD[2].Value = institucion;
                paramD[3] = new SqlParameter("@extraa", SqlDbType.VarChar);
                paramD[3].Value = Extr;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_GradoEspecialidad";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[4];
                paramD[0] = new SqlParameter("@num_regis", SqlDbType.Int);
                paramD[0].Value = num_registro;
                paramD[1] = new SqlParameter("@titulo", SqlDbType.VarChar);
                paramD[1].Value = titulo;
                paramD[2] = new SqlParameter("@institucion", SqlDbType.VarChar);
                paramD[2].Value = institucion;
                paramD[3] = new SqlParameter("@extraa", SqlDbType.VarChar);
                paramD[3].Value = Extr;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_GradoEspecialidad";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string InsertarPerfilProfe(int f_profesorr, int f_grado, string estado, string fechaObtenida, string Evidencia)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[5];
                paramD[0] = new SqlParameter("@f_profesor", SqlDbType.Int);
                paramD[0].Value = f_profesorr;
                paramD[1] = new SqlParameter("@f_grad", SqlDbType.Int);
                paramD[1].Value = f_grado;
                paramD[2] = new SqlParameter("@estado", SqlDbType.VarChar);
                paramD[2].Value = estado;
                paramD[3] = new SqlParameter("@fechaOb", SqlDbType.VarChar);
                paramD[3].Value = fechaObtenida;
                paramD[4] = new SqlParameter("@evidencia", SqlDbType.VarChar);
                paramD[4].Value = Evidencia;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_PerfilProfe";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[5];
                paramD[0] = new SqlParameter("@f_profesor", SqlDbType.Int);
                paramD[0].Value = f_profesorr;
                paramD[1] = new SqlParameter("@f_grad", SqlDbType.Int);
                paramD[1].Value = f_grado;
                paramD[2] = new SqlParameter("@estado", SqlDbType.VarChar);
                paramD[2].Value = estado;
                paramD[3] = new SqlParameter("@fechaOb", SqlDbType.VarChar);
                paramD[3].Value = fechaObtenida;
                paramD[4] = new SqlParameter("@evidencia", SqlDbType.VarChar);
                paramD[4].Value = Evidencia;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Insertar_PerfilProfe";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string BusquedaInfoProfesor(string Nombre)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[1];
                paramD[0] = new SqlParameter("@nom", SqlDbType.VarChar);
                paramD[0].Value = Nombre;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Busqueda_InfoProfesor";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[1];
                paramD[0] = new SqlParameter("@nom", SqlDbType.VarChar);
                paramD[0].Value = Nombre;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Busqueda_InfoProfesor";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string BusquedaMateriasProfesor(string Nombre_Profe, string materia)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@nom_pro", SqlDbType.VarChar);
                paramD[0].Value = Nombre_Profe;
                paramD[1] = new SqlParameter("@mate", SqlDbType.VarChar);
                paramD[1].Value = materia;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Busqueda_MateriasProfesor";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@nom_pro", SqlDbType.VarChar);
                paramD[0].Value = Nombre_Profe;
                paramD[1] = new SqlParameter("@mate", SqlDbType.VarChar);
                paramD[1].Value = materia;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Busqueda_MateriasProfesor";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string BusquedaProgramaEducativoProfe(string Nombre_profe, string pers, string grupo, int registroo, int graado)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[5];
                paramD[0] = new SqlParameter("@nomb", SqlDbType.VarChar);
                paramD[0].Value = Nombre_profe;
                paramD[1] = new SqlParameter("@per", SqlDbType.VarChar);
                paramD[1].Value = pers;
                paramD[2] = new SqlParameter("@grup", SqlDbType.VarChar);
                paramD[2].Value = grupo;
                paramD[3] = new SqlParameter("@regis", SqlDbType.Int);
                paramD[3].Value = registroo;
                paramD[4] = new SqlParameter("@grad", SqlDbType.Int);
                paramD[4].Value = graado;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Busqueda_ProgramaEducativoProfe";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[5];
                paramD[0] = new SqlParameter("@nomb", SqlDbType.VarChar);
                paramD[0].Value = Nombre_profe;
                paramD[1] = new SqlParameter("@per", SqlDbType.VarChar);
                paramD[1].Value = pers;
                paramD[2] = new SqlParameter("@grup", SqlDbType.VarChar);
                paramD[2].Value = grupo;
                paramD[3] = new SqlParameter("@regis", SqlDbType.Int);
                paramD[3].Value = registroo;
                paramD[4] = new SqlParameter("@grad", SqlDbType.Int);
                paramD[4].Value = graado;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Busqueda_ProgramaEducativoProfe";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string EliminarProfesor(string NombrePr, string f_prof, int numero_re)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[3];
                paramD[0] = new SqlParameter("@NombrePr", SqlDbType.VarChar);
                paramD[0].Value = NombrePr;
                paramD[1] = new SqlParameter("@f_prof", SqlDbType.VarChar);
                paramD[1].Value = f_prof;
                paramD[2] = new SqlParameter("@num_re", SqlDbType.Int);
                paramD[2].Value = numero_re;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Eliminar_Profesor";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[3];
                paramD[0] = new SqlParameter("@NombrePr", SqlDbType.VarChar);
                paramD[0].Value = NombrePr;
                paramD[1] = new SqlParameter("@f_prof", SqlDbType.VarChar);
                paramD[1].Value = f_prof;
                paramD[2] = new SqlParameter("@num_re", SqlDbType.Int);
                paramD[2].Value = numero_re;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Eliminar_Profesor";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string EliminarMateria(int RegMateria, int regCuatri, int regEdu, int f_prof, int f_cuatrimest)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[5];
                paramD[0] = new SqlParameter("@Regmat", SqlDbType.Int);
                paramD[0].Value = RegMateria;
                paramD[1] = new SqlParameter("@regCua", SqlDbType.Int);
                paramD[1].Value = regEdu;
                paramD[2] = new SqlParameter("@regisEd", SqlDbType.Int);
                paramD[2].Value = regEdu;
                paramD[3] = new SqlParameter("@f_pro", SqlDbType.Int);
                paramD[3].Value = f_prof;
                paramD[4] = new SqlParameter("@f_cuatri", SqlDbType.Int);
                paramD[4].Value = f_cuatrimest;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Eliminar_Materia";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[5];
                paramD[0] = new SqlParameter("@Regmat", SqlDbType.Int);
                paramD[0].Value = RegMateria;
                paramD[1] = new SqlParameter("@regCua", SqlDbType.Int);
                paramD[1].Value = regEdu;
                paramD[2] = new SqlParameter("@regisEd", SqlDbType.Int);
                paramD[2].Value = regEdu;
                paramD[3] = new SqlParameter("@f_pro", SqlDbType.Int);
                paramD[3].Value = f_prof;
                paramD[4] = new SqlParameter("@f_cuatri", SqlDbType.Int);
                paramD[4].Value = f_cuatrimest;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Eliminar_Materia";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string ModificarNomProfesor1(string Nombr, string nombrMod)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@nomb", SqlDbType.VarChar);
                paramD[0].Value = Nombr;
                paramD[1] = new SqlParameter("@NomMod", SqlDbType.VarChar);
                paramD[1].Value = nombrMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_NomProfesor1";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@nomb", SqlDbType.VarChar);
                paramD[0].Value = Nombr;
                paramD[1] = new SqlParameter("@NomMod", SqlDbType.VarChar);
                paramD[1].Value = nombrMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_NomProfesor1";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }

        public string ModificarNomProfesor2(string ap_pat, string ap_patmod)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@ap_pat", SqlDbType.VarChar);
                paramD[0].Value = ap_pat;
                paramD[1] = new SqlParameter("@ap_patMod", SqlDbType.VarChar);
                paramD[1].Value = ap_patmod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_NomProfesor2";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@ap_pat", SqlDbType.VarChar);
                paramD[0].Value = ap_pat;
                paramD[1] = new SqlParameter("@ap_patMod", SqlDbType.VarChar);
                paramD[1].Value = ap_patmod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_NomProfesor2";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string ModificarNomProfesor3(string ap_mat, string ap_matMod)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@ap_mat", SqlDbType.VarChar);
                paramD[0].Value = ap_mat;
                paramD[1] = new SqlParameter("@ap_matMod", SqlDbType.VarChar);
                paramD[1].Value = ap_matMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_NomProfesor3";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@ap_mat", SqlDbType.VarChar);
                paramD[0].Value = ap_mat;
                paramD[1] = new SqlParameter("@ap_matMod", SqlDbType.VarChar);
                paramD[1].Value = ap_matMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_NomProfesor3";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }

        public string ModificarNomProfesor4(string generoo, string generoMod)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@genero", SqlDbType.VarChar);
                paramD[0].Value = generoo;
                paramD[1] = new SqlParameter("@generoMod", SqlDbType.VarChar);
                paramD[1].Value = generoMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_NomProfesor4";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@genero", SqlDbType.VarChar);
                paramD[0].Value = generoo;
                paramD[1] = new SqlParameter("@generoMod", SqlDbType.VarChar);
                paramD[1].Value = generoMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_NomProfesor4";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string ModificarNomProfesor5(string categoriaa, string categoriaMod)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@categoria", SqlDbType.VarChar);
                paramD[0].Value = categoriaa;
                paramD[1] = new SqlParameter("@categoriaMod", SqlDbType.VarChar);
                paramD[1].Value = categoriaMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_NomProfesor5";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@categoria", SqlDbType.VarChar);
                paramD[0].Value = categoriaa;
                paramD[1] = new SqlParameter("@categoriaMod", SqlDbType.VarChar);
                paramD[1].Value = categoriaMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_NomProfesor5";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }

        public string ModificarNomProfesor6(string correo, string correoMod)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@correo", SqlDbType.VarChar);
                paramD[0].Value = correo;
                paramD[1] = new SqlParameter("@correoMod", SqlDbType.VarChar);
                paramD[1].Value = correoMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_NomProfesor6";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@correo", SqlDbType.VarChar);
                paramD[0].Value = correo;
                paramD[1] = new SqlParameter("@correoMod", SqlDbType.VarChar);
                paramD[1].Value = correoMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_NomProfesor6";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string ModificarNomProfesor7(string celul, string celulMod)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@celul", SqlDbType.VarChar);
                paramD[0].Value = celul;
                paramD[1] = new SqlParameter("@celuMod", SqlDbType.VarChar);
                paramD[1].Value = celulMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_NomProfesor7";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@celul", SqlDbType.VarChar);
                paramD[0].Value = celul;
                paramD[1] = new SqlParameter("@celuMod", SqlDbType.VarChar);
                paramD[1].Value = celulMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_NomProfesor7";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string ModificarPerfilProfe1(string estado, string estadoMod)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@estado", SqlDbType.VarChar);
                paramD[0].Value = estado;
                paramD[1] = new SqlParameter("@estadoMod", SqlDbType.VarChar);
                paramD[1].Value = estadoMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_PerfilProfe1";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@estado", SqlDbType.VarChar);
                paramD[0].Value = estado;
                paramD[1] = new SqlParameter("@estadoMod", SqlDbType.VarChar);
                paramD[1].Value = estadoMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_PerfilProfe1";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string ModificarPerfilProfe2(string fechaObte, string fechaObteMod)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@fechObte", SqlDbType.Date);
                paramD[0].Value = fechaObte;
                paramD[1] = new SqlParameter("@fechObteMod", SqlDbType.Date);
                paramD[1].Value = fechaObteMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_PerfilProfe2";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@fechObte", SqlDbType.Date);
                paramD[0].Value = fechaObte;
                paramD[1] = new SqlParameter("@fechObteMod", SqlDbType.Date);
                paramD[1].Value = fechaObteMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_PerfilProfe2";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string ModificarPerfilProfe3(string evidenci, string evidenciMod)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@evidenci", SqlDbType.VarChar);
                paramD[0].Value = evidenci;
                paramD[1] = new SqlParameter("@evidenciMod", SqlDbType.VarChar);
                paramD[1].Value = evidenciMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_PerfilProfe3";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@evidenci", SqlDbType.VarChar);
                paramD[0].Value = evidenci;
                paramD[1] = new SqlParameter("@evidenciMod", SqlDbType.VarChar);
                paramD[1].Value = evidenciMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_PerfilProfe3";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string ModificarGradoEspecial1(string titul, string titulMod)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@titulo", SqlDbType.VarChar);
                paramD[0].Value = titul;
                paramD[1] = new SqlParameter("@tituloMod", SqlDbType.VarChar);
                paramD[1].Value = titulMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_GradoEspecialidad1";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@titulo", SqlDbType.VarChar);
                paramD[0].Value = titul;
                paramD[1] = new SqlParameter("@tituloMod", SqlDbType.VarChar);
                paramD[1].Value = titulMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_GradoEspecialidad1";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }

        public string ModificarGradoEspecial2(string instituto, string instituMod)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@institu", SqlDbType.VarChar);
                paramD[0].Value = instituto;
                paramD[1] = new SqlParameter("@instituMod", SqlDbType.VarChar);
                paramD[1].Value = instituMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_GradoEspecialidad2";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@institu", SqlDbType.VarChar);
                paramD[0].Value = instituto;
                paramD[1] = new SqlParameter("@instituMod", SqlDbType.VarChar);
                paramD[1].Value = instituMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_GradoEspecialidad2";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string ModificarGradoEspecial3(string Pais, string paisMod)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@pais", SqlDbType.VarChar);
                paramD[0].Value = Pais;
                paramD[1] = new SqlParameter("@paisMod", SqlDbType.VarChar);
                paramD[1].Value = paisMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_GradoEspecialidad3";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@pais", SqlDbType.VarChar);
                paramD[0].Value = Pais;
                paramD[1] = new SqlParameter("@paisMod", SqlDbType.VarChar);
                paramD[1].Value = paisMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_GradoEspecialidad3";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string ModificarGradoEspecial4(string extra, string extraMod)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@extra", SqlDbType.VarChar);
                paramD[0].Value = extra;
                paramD[1] = new SqlParameter("@extraMod", SqlDbType.VarChar);
                paramD[1].Value = extraMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_GradoEspecialidad4";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@extra", SqlDbType.VarChar);
                paramD[0].Value = extra;
                paramD[1] = new SqlParameter("@extraMod", SqlDbType.VarChar);
                paramD[1].Value = extraMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_GradoEspecialidad4";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }


        public string ModificarAsignaProfeMateriaCuatri(string Extra, string ExtraMod)
        {
            string msj = "";
            try
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@extra", SqlDbType.VarChar);
                paramD[0].Value = Extra;
                paramD[1] = new SqlParameter("@extraMod", SqlDbType.VarChar);
                paramD[1].Value = ExtraMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_AsignaProfeMateriaCuatri";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            catch (Exception)
            {
                SqlParameter[] paramD = new SqlParameter[2];
                paramD[0] = new SqlParameter("@extra", SqlDbType.VarChar);
                paramD[0].Value = Extra;
                paramD[1] = new SqlParameter("@extraMod", SqlDbType.VarChar);
                paramD[1].Value = ExtraMod;
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.CommandText = "Modificar_AsignaProfeMateriaCuatri";
                COMANDO.Connection = CONEXION;
                COMANDO.Parameters.AddRange(paramD);
                COMANDO.ExecuteNonQuery();
                msj = "Ingresado Correctamente";
            }
            return msj;
        }
    }
}
