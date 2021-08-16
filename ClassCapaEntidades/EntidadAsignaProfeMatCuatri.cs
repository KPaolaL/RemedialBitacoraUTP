using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCapaEntidades
{
    public class EntidadAsignaProfeMatCuatri
    {
        public int id_AsignaPro { set; get; }
        public short F_Profe { set; get; }
        public short F_Materia { set; get; }
        public int F_GrupoCuatri { set; get; }
        public string Extra { set; get; }
    }
}
