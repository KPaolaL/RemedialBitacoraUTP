using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCapaEntidades
{
    public class EntidadPerfilProfe
    {
        public int Id_Perfil { set; get; }
        public int F_Profe { set; get; }
        public int F_Grado { set; get; }
        public string Estado { set; get; }
        public DateTime FechaOrientacion { set; get; }
        public string Evidencia { set; get; }
    }
}
