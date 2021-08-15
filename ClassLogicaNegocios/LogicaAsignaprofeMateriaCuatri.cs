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
    public class LogicaAsignaprofeMateriaCuatri
    {
        private ClassAccesoSQL objectoDeAcceso = new ClassAccesoSQL("Server=LAPTOP-SFMTQ4SG\\SQLEXPRESS;Initial Catalog=Bitacora2021LabsUTP;" +
                                                                   "Integrated Security=true;");

        //insertar grado especialidad
        public Boolean InsertarAsignacionProf(EntidadAsignaProfeMatCuatri asign, ref string mensajeSalida)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            //  string otro = "platano";

            parametros[0] = new SqlParameter
            {
                ParameterName = "F_Profe",
                SqlDbType = SqlDbType.TinyInt,
                Direction = ParameterDirection.Input,
                Value = asign.F_Profe
            };

            parametros[1] = new SqlParameter
            {
                ParameterName = "F_Materia",
                SqlDbType = SqlDbType.TinyInt,
                Direction = ParameterDirection.Input,
                Value = asign.F_Materia
            };

            parametros[2] = new SqlParameter
            {
                ParameterName = "F_GrupoCuatri",
                SqlDbType = SqlDbType.TinyInt,
                Direction = ParameterDirection.Input,
                Value = asign.F_GrupoCuatri

            };
            parametros[3] = new SqlParameter
            {
                ParameterName = "extra",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = asign.Extra
            };


            string sentencia = "insert into AsignaProfeMateriaCuatri values(@F_Profe, @F_Materia, @F_GrupoCuatri, @extra);";
            Boolean salida = false;

            salida = objectoDeAcceso.OperacionesSQLConParametros(sentencia, objectoDeAcceso.AbrirConexion(ref mensajeSalida),
                ref mensajeSalida, parametros);
            return salida;

        }

        //borrar registro
        public Boolean deleteGrado(string id, ref string result)
        {
            string sentencia = "delete from AsignaProfeMateriaCuatri where Id_AsignaPro = " + id + ";";
            Boolean salida = false;
            salida = objectoDeAcceso.ModificaBDinsegura(sentencia, objectoDeAcceso.AbrirConexion(ref result), ref result);
            return salida;

        }

        //editar registro
        public Boolean UpdateClient(EntidadAsignaProfeMatCuatri asign, string id, ref string result)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            //  string otro = "platano";

            parametros[0] = new SqlParameter
            {
                ParameterName = "F_Profe",
                SqlDbType = SqlDbType.TinyInt,
                Direction = ParameterDirection.Input,
                Value = asign.F_Profe
            };

            parametros[1] = new SqlParameter
            {
                ParameterName = "F_Materia",
                SqlDbType = SqlDbType.TinyInt,
                Direction = ParameterDirection.Input,
                Value = asign.F_Materia
            };

            parametros[2] = new SqlParameter
            {
                ParameterName = "F_GrupoCuatri",
                SqlDbType = SqlDbType.TinyInt,
                Direction = ParameterDirection.Input,
                Value = asign.F_GrupoCuatri

            };
            parametros[3] = new SqlParameter
            {
                ParameterName = "extra",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = asign.Extra
            };


            //string sentencia = "insert into AsignaProfeMateriaCuatri values(@F_Profe, @F_Materia, @F_GrupoCuatri, @extra);";
            string sentencia1 = "UPDATE AsignaProfeMateriaCuatri SET F_Profe = @F_Profe, F_Materia = @F_Materia, F_GrupoCuatri = @F_GrupoCuatri, extra = @extra  WHERE Id_AsignaPro = " + id + ";";
            Boolean salida = false;
            salida = objectoDeAcceso.ModificaParametros(sentencia1, objectoDeAcceso.AbrirConexion(ref result), ref result, parametros);

            return salida;
        }
    }
}
