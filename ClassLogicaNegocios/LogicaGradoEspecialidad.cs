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
            string sentencia1 = "UPDATE GradoEspecialidad SET titulo = @titulo, institucion = @insititucion, pais = @pais, extra = @extra  WHERE Id_Grado = " + id + ";";
            Boolean salida = false;

            salida = objectoDeAcceso.ModificaParametros(sentencia1, objectoDeAcceso.AbrirConexion(ref result), ref result, parametros);

            return salida;
        }

    }
}
