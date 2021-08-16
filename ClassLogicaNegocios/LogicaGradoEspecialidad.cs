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
    public class LogicaGradoEspecialidad
    {
        private ClassAccesoSQL objectoDeAcceso = new ClassAccesoSQL("Server=LAPTOP-SFMTQ4SG\\SQLEXPRESS;Initial Catalog=Bitacora2021LabsUTP;" +
                                                                    "Integrated Security=true;");
        
        //insertar grado especialidad
        public Boolean InsertaGradoEspe(EntidadGradoEspecialidad grado, ref string mensajeSalida)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            //  string otro = "platano";

            parametros[0] = new SqlParameter
            {
                ParameterName = "titulo",
                SqlDbType = SqlDbType.VarChar,
                Size = 140,
                Direction = ParameterDirection.Input,
                Value = grado.Titulo
            };

            parametros[1] = new SqlParameter
            {
                ParameterName = "institucion",
                SqlDbType = SqlDbType.VarChar,
                Size = 140,
                Direction = ParameterDirection.Input,
                Value = grado.Institucion
            };

            parametros[2] = new SqlParameter
            {
                ParameterName = "pais",
                SqlDbType = SqlDbType.VarChar,
                Size = 40,
                Direction = ParameterDirection.Input,
                Value = grado.Pais

            };
            parametros[3] = new SqlParameter
            {
                ParameterName = "extra",
                SqlDbType = SqlDbType.VarChar,
                Size = 40,
                Direction = ParameterDirection.Input,
                Value = grado.Extra
            };


            string sentencia = "insert into GradoEspecialidad values(@titulo, @institucion, @pais, @extra);";
            Boolean salida = false;

            salida = objectoDeAcceso.OperacionesSQLConParametros(sentencia, objectoDeAcceso.AbrirConexion(ref mensajeSalida),
                ref mensajeSalida, parametros);
            return salida;

        }

        
        //borrar registro
        public Boolean deleteGrado(string id, ref string result)
        {
            string sentencia = "delete from GradoEspecialidad where Id_Grado = " + id + ";";
            Boolean salida = false;
            salida = objectoDeAcceso.ModificaBDinsegura(sentencia, objectoDeAcceso.AbrirConexion(ref result), ref result);
            return salida;

        }

        //editar registro
        public List<EntidadGradoEspecialidad> ListaGrado(string id, ref string msj_salida)
        {
            SqlConnection conexion = null;

            string query = "select * from GradoEspecialidad where Id_Grado = " + id + ";";
            conexion = objectoDeAcceso.AbrirConexion(ref msj_salida);

            SqlDataReader ObtenerDatos = null;

            ObtenerDatos = objectoDeAcceso.ConsultarReader(query, conexion, ref msj_salida);

            List < EntidadGradoEspecialidad> lista = new List<EntidadGradoEspecialidad>();
            if (ObtenerDatos != null)
            {
                while (ObtenerDatos.Read())
                {
                    lista.Add(new EntidadGradoEspecialidad
                    {
                        id_Grado = (short)ObtenerDatos[0],
                        Titulo = (string)ObtenerDatos[1],
                        Institucion = (string)ObtenerDatos[2],
                        Pais = (string)ObtenerDatos[3],
                        Extra= (string)ObtenerDatos[4]
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
            //editar registro
        public Boolean UpdateClient(EntidadGradoEspecialidad nuevo, string id, ref string result)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            //  string otro = "platano";
            parametros[0] = new SqlParameter
            {
                ParameterName = "titulo",
                SqlDbType = SqlDbType.VarChar,
                Size = 140,
                Direction = ParameterDirection.Input,
                Value = nuevo.Titulo
            };
            parametros[1] = new SqlParameter
            {
                ParameterName = "institucion",
                SqlDbType = SqlDbType.VarChar,
                Size = 140,
                Direction = ParameterDirection.Input,
                Value = nuevo.Institucion
            };
            parametros[2] = new SqlParameter
            {
                ParameterName = "pais",
                SqlDbType = SqlDbType.VarChar,
                Size = 40,
                Direction = ParameterDirection.Input,
                Value = nuevo.Pais
            };
            parametros[3] = new SqlParameter
            {
                ParameterName = "extra",
                SqlDbType = SqlDbType.VarChar,
                Size = 40,
                Direction = ParameterDirection.Input,
                Value = nuevo.Extra
            };
            //string sentencia = "insert into GradoEspecialidad values(@titulo, @institucion, @pais, @extra);";
            string sentencia1 = "UPDATE GradoEspecialidad SET titulo = @titulo, institucion = @institucion, pais = @pais, extra = @extra  WHERE Id_Grado = " + id + ";";
            Boolean salida = false;
            salida = objectoDeAcceso.ModificaParametros(sentencia1, objectoDeAcceso.AbrirConexion(ref result), ref result, parametros);
            return salida;
        }

        //Obtener grado en grid
        public DataTable ObtenerGrado(ref string msj_salida)
        {
            string query = "select Id_Grado as Codigo, Titulo as Titulo, Institucion as Institucion, Pais as Pais, Extra as Extra from GradoEspecialidad;"; 
            DataSet obtengrado = null;
            DataTable Datos_salida = null;
            obtengrado = objectoDeAcceso.ConsultaDS(query, objectoDeAcceso.AbrirConexion(ref msj_salida), ref msj_salida);

            if (obtengrado != null)
            {
                Datos_salida = obtengrado.Tables[0];
                if (Datos_salida.Rows.Count == 0)
                {
                    //La consulta es correcta pero el DataSet no está
                    //devolviendo registros

                }
            }
            return Datos_salida;
        }

        public List<EntidadGradoEspecialidad> GetGrado(ref string ms)
        {
            SqlConnection conexion = null;
            string consulta3 = "select * from GradoEspecialidad";

            conexion = objectoDeAcceso.AbrirConexion(ref ms);
            SqlDataReader obtenDatos = null;

            obtenDatos = objectoDeAcceso.ConsultarReader(consulta3, conexion, ref ms);

            List<EntidadGradoEspecialidad> s = new List<EntidadGradoEspecialidad>();

            if (obtenDatos != null)
            {
                while (obtenDatos.Read())
                {
                    s.Add(new EntidadGradoEspecialidad
                    {
                        id_Grado = (short)obtenDatos[0],
                        Titulo = obtenDatos[1].ToString(),

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

    }
}
