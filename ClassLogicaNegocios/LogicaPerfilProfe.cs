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
    public class LogicaPerfilProfe
    {
        private ClassAccesoSQL objectoDeAcceso = new ClassAccesoSQL("Server=LAPTOP-SFMTQ4SG\\SQLEXPRESS;Initial Catalog=Bitacora2021LabsUTP;" +
                                                                   "Integrated Security=true;");

        public Boolean InsertaGradoEspe(EntidadPerfilProfe perf, ref string mensajeSalida)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            //  string otro = "platano";

            parametros[0] = new SqlParameter
            {
                ParameterName = "F_Profe",
                SqlDbType = SqlDbType.TinyInt,
                Direction = ParameterDirection.Input,
                Value = perf.F_Profe
            };

            parametros[1] = new SqlParameter
            {
                ParameterName = "F_Grado",
                SqlDbType = SqlDbType.TinyInt,
                Direction = ParameterDirection.Input,
                Value = perf.F_Grado
            };

            parametros[2] = new SqlParameter
            {
                ParameterName = "Estado",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Direction = ParameterDirection.Input,
                Value = perf.Estado

            };
            parametros[3] = new SqlParameter
            {
                ParameterName = "FechaOrientacion",
                SqlDbType = SqlDbType.VarChar,
                Size = 5,
                Direction = ParameterDirection.Input,
                Value = perf.FechaOrientacion
            };
            parametros[4] = new SqlParameter
            {
                ParameterName = "Evidencia",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = perf.Evidencia
            };


            string sentencia = "insert into PerfilProfe values(@F_Profe,F_Grado, @Estado, @FechaOrientacion, @Evidencia);";
            Boolean salida = false;

            salida = objectoDeAcceso.OperacionesSQLConParametros(sentencia, objectoDeAcceso.AbrirConexion(ref mensajeSalida),
                ref mensajeSalida, parametros);
            return salida;

        }

        //borrar registro
        public Boolean DeleteProfe(string id, ref string result)
        {

            string sentencia = "delete from PerfilProfe where Id_Perfil = " + id + ";";
            Boolean salida = false;
            salida = objectoDeAcceso.ModificaBDinsegura(sentencia, objectoDeAcceso.AbrirConexion(ref result), ref result);
            return salida;

        }

        //editar registro
        public Boolean UpdateProfesor(EntidadPerfilProfe perf, string id, ref string result)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            //  string otro = "platano";

            parametros[0] = new SqlParameter
            {
                ParameterName = "F_Profe",
                SqlDbType = SqlDbType.TinyInt,
                Direction = ParameterDirection.Input,
                Value = perf.F_Profe
            };

            parametros[1] = new SqlParameter
            {
                ParameterName = "F_Grado",
                SqlDbType = SqlDbType.TinyInt,
                Direction = ParameterDirection.Input,
                Value = perf.F_Grado
            };

            parametros[2] = new SqlParameter
            {
                ParameterName = "Estado",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Direction = ParameterDirection.Input,
                Value = perf.Estado

            };
            parametros[3] = new SqlParameter
            {
                ParameterName = "FechaOrientacion",
                SqlDbType = SqlDbType.VarChar,
                Size = 5,
                Direction = ParameterDirection.Input,
                Value = perf.FechaOrientacion
            };
            parametros[4] = new SqlParameter
            {
                ParameterName = "Evidencia",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = perf.Evidencia
            };

            //string sentencia = "insert into PerfilProfe values(@F_Profe,F_Grado, @Estado, @FechaOrientacion, @Evidencia);";
            string sentencia1 = "UPDATE PerfilProfe SET F_Profe = @F_Profe, F_Grado = @F_Grado, Estado = @Estado, FechaOrientacion = @FechaOrientacion, Evidencia=@Evidencia,  WHERE Id_Perfil = " + id + ";";
            Boolean salida = false;

            salida = objectoDeAcceso.ModificaParametros(sentencia1, objectoDeAcceso.AbrirConexion(ref result), ref result, parametros);

            return salida;
        }


    }
}
