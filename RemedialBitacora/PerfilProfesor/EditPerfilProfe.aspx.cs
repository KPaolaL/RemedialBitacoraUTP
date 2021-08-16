using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClassLogicaNegocios;
using ClassCapaEntidades;

namespace RemedialBitacora.PerfilProfesor
{
    public partial class EditPerfilProfe : System.Web.UI.Page
    {
        LogicaPerfilProfe LogPer = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                LogPer = new LogicaPerfilProfe();
                Session["LogPer"] = LogPer;
            }
            else
            {
                LogPer = (LogicaPerfilProfe)Session["LogPer"];
            }
            if (!IsPostBack)
            {
                List<EntidadPerfilProfe> mostrarPerf = null;
                string msj = "";
                string id = Convert.ToString(Session["id_seleccionado"]);
                //mostrarPerf = LogPer.ObtenerPerfil(ref msj);
                if (mostrarPerf != null)
                {
                    //foreach (EntidadPerfilProfe perfil in mostrarPerf)
                    {
                       // TextBox1.Text = perfil.Estado;
                       // TextBox2.Text = perfil.Evidencia;
                     //   Calendar1 = perfil.FechaObtencion;

                    }
                }
                List<EntidadProfesor> perfil = null;
                perfil = LogPer.GetProfe(ref msj);
                if (perfil != null)
                {
                    foreach (EntidadProfesor edo in perfil)
                    {
                        DropDownList1.Items.Add(new ListItem(edo.Nombre.ToString(), edo.id_Profe.ToString()));
                        DropDownList1.DataBind();
                    }
                }
                //List<EntidadGradoEspecialidad> perfil = null;
               // string msj = "";
                //perfil = LogPer.GetGrado(ref msj);
                if (perfil != null)
                {
                   // foreach (EntidadGradoEspecialidad edo in perfil)
                    {
                     //   DropDownList2.Items.Add(new ListItem(edo.Titulo.ToString(), edo.id_Grado.ToString()));
                        DropDownList2.DataBind();

                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}