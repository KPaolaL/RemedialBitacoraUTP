using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLogicaNegocios;
using ClassCapaEntidades;


namespace RemedialBitacora.GradoEspecialidad
{
    public partial class EditGrado : System.Web.UI.Page
    {
        LogicaGradoEspecialidad objGE = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                objGE = new LogicaGradoEspecialidad();
                Session["objGE"] = objGE;

            }
            else
            {
                objGE = (LogicaGradoEspecialidad)Session["objGE"];
            }
            if (!IsPostBack)
            {
                List<EntidadGradoEspecialidad> mostrargrado = null;
                string msj = "";
                string id = Convert.ToString(Session["id_seleccionado"]);
                mostrargrado = objGE.ListaGrado(id, ref msj);
                if (mostrargrado != null)
                {
                    foreach (EntidadGradoEspecialidad grado in mostrargrado)
                    {
                        TextBox1.Text = grado.Titulo.ToString();
                        TextBox2.Text = grado.Institucion.ToString();
                        TextBox3.Text = grado.Pais.ToString();
                        TextBox4.Text = grado.Extra.ToString();
                    }
                }
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            EntidadGradoEspecialidad entidad = new EntidadGradoEspecialidad
            {
                Titulo = TextBox1.Text,
                Institucion = TextBox2.Text,
                Pais = TextBox3.Text,
                Extra = TextBox4.Text
            };

            string resp = "";
            Boolean recibe = false;
            string id = Convert.ToString(Session["id_seleccionado"]);
            recibe = objGE.UpdateClient(entidad, id, ref resp);
            //string mensaje = "";
            Server.Transfer("AgregarGradoEspe.aspx");
        }
    }
}