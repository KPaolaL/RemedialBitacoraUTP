using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCapaEntidades
{
    public class EntidadProfesor
    {
        public int id_Profe { get; set; }
        public int RegistroEmpleado { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Genero { get; set; }
        public string Categoria { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public int F_EdoCivil { get; set; }
    }
}
