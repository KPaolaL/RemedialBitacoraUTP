using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ClassCapaAccesoSQL;
using ClassCapaEntidades;

namespace ClassLogicaNegocios
{
    public class LogicaProfesor
    {
        private ClassAccesoSQL objectoDeAcceso = new ClassAccesoSQL("Server=LAPTOP-SFMTQ4SG\\SQLEXPRESS;Initial Catalog=Bitacora2021LabsUTP;" +
                                                                    "Integrated Security=true;");
        public Boolean InsertaProf(EntidadProfesor nuevo, EntidadEstadoCiv EstadoCiv, ref string mensajeSalida)
        {
            SqlParameter[] parametros = new SqlParameter[9];
            parametros[0] = new SqlParameter
            {
                ParameterName = "RegistroEmpleado",
                SqlDbType = SqlDbType.VarChar,
                Size = 4,
                Direction = ParameterDirection.Input,
                Value = nuevo.RegistroEmpleado
            };
            parametros[1] = new SqlParameter
            {
                ParameterName = "Nombre",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Direction = ParameterDirection.Input,
                Value = nuevo.Nombre
            };
            parametros[2] = new SqlParameter
            {
                ParameterName = "Ap_pat",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Direction = ParameterDirection.Input,
                Value = nuevo.ApellidoP
            };
            parametros[3] = new SqlParameter
            {
                ParameterName = "Ap_Mat",
                Size = 150,
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = nuevo.ApellidoM
            };
            parametros[4] = new SqlParameter
            {
                ParameterName = "Genero",
                Size = 10,
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = nuevo.Genero
            };
            parametros[5] = new SqlParameter
            {
                ParameterName = "Categoria",
                SqlDbType = SqlDbType.VarChar,
                Size = 5,
                Direction = ParameterDirection.Input,
                Value = nuevo.Categoria
            };
            parametros[6] = new SqlParameter
            {
                ParameterName = "Correo",
                SqlDbType = SqlDbType.VarChar,
                Size = 200,
                Direction = ParameterDirection.Input,
                Value = nuevo.Correo
            };
            parametros[7] = new SqlParameter
            {
                ParameterName = "Celular",
                SqlDbType = SqlDbType.VarChar,
                Size = 20,
                Direction = ParameterDirection.Input,
                Value = nuevo.Celular
            };
            parametros[8] = new SqlParameter
            {
                ParameterName = "F_EdoCivil",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = EstadoCiv.idEdo

            };

            string sentencia = "insert into Profesor values(@RegistroEmpleado, @Nombre, @Ap_pat, @Ap_Mat, @Genero, @Categoria, @Correo, @Celular, @F_EdoCivil)";
            Boolean salida = false;

            salida = objectoDeAcceso.OperacionesSQLConParametros(sentencia, objectoDeAcceso.AbrirConexion(ref mensajeSalida), ref mensajeSalida, parametros);
            return salida;

        }
        //obtener estado civil
        public List<EntidadEstadoCiv> GetEstadoCivi(ref string ms)
        {
            SqlConnection conexion = null;
            string consulta3 = "Select * from EstadoCivil";

            conexion = objectoDeAcceso.AbrirConexion(ref ms);
            SqlDataReader obtenDatos = null;

            obtenDatos = objectoDeAcceso.ConsultarReader(consulta3, conexion, ref ms);

            List<EntidadEstadoCiv> s = new List<EntidadEstadoCiv>();

            if (obtenDatos != null)
            {
                while (obtenDatos.Read())
                {
                    s.Add(new EntidadEstadoCiv
                    {
                        idEdo = (byte)obtenDatos[0],
                        Estado = (string)obtenDatos[1]
                    });
                }

            }
            else
            {
                s = null;
            }

            conexion.Close();
            conexion.Dispose();

            return s;
        }

        //borrar registro
        public Boolean DeleteProfe(string id, ref string result)
        {
          
            string sentencia = "delete from Profesor where ID_Profe = " + id + ";";
            Boolean salida = false;
            salida = objectoDeAcceso.ModificaBDinsegura(sentencia, objectoDeAcceso.AbrirConexion(ref result), ref result);
            return salida;

        }

        //editar registro
        public List<EntidadProfesor> ListaProfesores(string id, ref string msj_salida)
        {
            SqlConnection conexion = null;
            string query = "select * from Profesor where  ID_Profe = " + id + ";";
            conexion = objectoDeAcceso.AbrirConexion(ref msj_salida);

            SqlDataReader ObtenerDatos = null;

            ObtenerDatos = objectoDeAcceso.ConsultarReader(query, conexion, ref msj_salida);

            List<EntidadProfesor> lista = new List<EntidadProfesor>();


            if (ObtenerDatos != null)
            {
                while (ObtenerDatos.Read())
                {
                    lista.Add(new EntidadProfesor
                    {
                        id_Profe = (short)ObtenerDatos[0],
                        RegistroEmpleado = (int)ObtenerDatos[1],
                        Nombre = (string)ObtenerDatos[2],
                        ApellidoP = (string)ObtenerDatos[3],
                        ApellidoM = (string)ObtenerDatos[4],
                        Genero = (string)ObtenerDatos[5],
                        Categoria = (string)ObtenerDatos[6],
                        Correo = (string)ObtenerDatos[7],
                        Celular = (string)ObtenerDatos[8],
                        F_EdoCivil = (byte)ObtenerDatos[9]
                    });
                }
            }
            else
            {
                lista = null;
            }
            conexion.Close();
            conexion.Dispose();

            return lista;

        }
        public Boolean UpdateProfesor(EntidadProfesor nuevo, string id, ref string result)
        {
            SqlParameter[] parametros = new SqlParameter[9];
            parametros[0] = new SqlParameter
            {
                ParameterName = "RegistroEmpleado",
                SqlDbType = SqlDbType.VarChar,
                Size = 4,
                Direction = ParameterDirection.Input,
                Value = nuevo.RegistroEmpleado
            };
            parametros[1] = new SqlParameter
            {
                ParameterName = "Nombre",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Direction = ParameterDirection.Input,
                Value = nuevo.Nombre
            };
            parametros[2] = new SqlParameter
            {
                ParameterName = "Ap_pat",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Direction = ParameterDirection.Input,
                Value = nuevo.ApellidoP
            };
            parametros[3] = new SqlParameter
            {
                ParameterName = "Ap_Mat",
                Size = 150,
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = nuevo.ApellidoM
            };
            parametros[4] = new SqlParameter
            {
                ParameterName = "Genero",
                Size = 10,
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = nuevo.Genero
            };
            parametros[5] = new SqlParameter
            {
                ParameterName = "Categoria",
                SqlDbType = SqlDbType.VarChar,
                Size = 5,
                Direction = ParameterDirection.Input,
                Value = nuevo.Categoria
            };
            parametros[6] = new SqlParameter
            {
                ParameterName = "Correo",
                SqlDbType = SqlDbType.VarChar,
                Size = 200,
                Direction = ParameterDirection.Input,
                Value = nuevo.Correo
            };
            parametros[7] = new SqlParameter
            {
                ParameterName = "Celular",
                SqlDbType = SqlDbType.VarChar,
                Size = 20,
                Direction = ParameterDirection.Input,
                Value = nuevo.Celular
            };
            parametros[8] = new SqlParameter
            {
                ParameterName = "F_EdoCivil",
                SqlDbType = SqlDbType.VarChar,
                Size = 20,
                Direction = ParameterDirection.Input,
                Value = nuevo.F_EdoCivil
            };

            //  string sentencia = "insert into Profesor values(@RegistroEmpleado, @Nombre, @Ap_pat, @Ap_Mat, @Genero, @Categoria, @Correo @Celular, @F_EdoCivil)";
            string sentencia1 = "UPDATE Profesor SET RegistroEmpleado = @RegistroEmpleado, Nombre = @Nombre, Ap_pat = @Ap_pat, Ap_Mat = @Ap_Mat, Genero=@Genero, Categoria=@Categoria, Correo=@Correo, Celular=@Celular, F_EdoCivil=@F_EdoCivil WHERE ID_Profe = " + id + ";";
            Boolean salida = false;

            salida = objectoDeAcceso.ModificaParametros(sentencia1, objectoDeAcceso.AbrirConexion(ref result), ref result, parametros);

            return salida;
        }

        //Obtener profesores en grid
        public DataTable ObtenerProfesores(ref string msj_salida)
        {

            string query = "select ID_Profe as Codigo, Nombre, Ap_pat as Apellido_Paterno, Ap_Mat as Apellido_Materno, Genero, Categoria, Correo, Celular, Estado as Estado_Civil from Profesor inner join EstadoCivil on F_EdoCivil=Id_Edo";

            DataSet ObtencionCarreras = null;
            DataTable Datos_salida = null;
            ObtencionCarreras = objectoDeAcceso.ConsultaDS(query, objectoDeAcceso.AbrirConexion(ref msj_salida), ref msj_salida);

            if (ObtencionCarreras != null)
            {
                Datos_salida = ObtencionCarreras.Tables[0];
                if (Datos_salida.Rows.Count == 0)
                {
                    //La consulta es correcta pero el DataSet no está
                    //devolviendo registros

                }

            }
            return Datos_salida;
        }
    }
}
