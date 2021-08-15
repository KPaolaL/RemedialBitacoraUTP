using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClassCapaEntidades;
using ClassLogicaNegocios;

namespace RemedialBitacora.GradoEspecialidad
{
    public partial class AgregarGradoEspe : System.Web.UI.Page
    {
        LogicaGradoEspecialidad objGE = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (IsPostBack == false)
            {
                objGE = new LogicaGradoEspecialidad();
                Session["objGE"] = objGE;
                string msj = "";
                GridView1.DataSource = objGE.ObtenerGrado(ref msj);
                if (GridView1.DataSource != null)
                {
                    GridView1.DataBind();
                }
            }
            else
            {
                objGE = (LogicaGradoEspecialidad)Session["objGE"];
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
            string mensaje = "";
            Boolean recibe = false;
            recibe = objGE.InsertaGradoEspe(entidad, ref mensaje);
        }

        protected void EliminarDato (object sender, EventArgs e)
        {
            string msj = "";
            string x = ((Button)sender).CommandArgument;
            string id = x.ToString();
            objGE.deleteGrado(id, ref msj);

            GridView1.DataSource = objGE.ObtenerGrado(ref msj);
            if (GridView1.DataSource != null)
            {
                GridView1.DataBind();
            }
        }

        protected void EditarDato (object sender, EventArgs e)
        {
            string x = ((Button)sender).CommandArgument;
            Session["id_seleccionado"] = Convert.ToInt32(x);
            Server.Transfer("EditGrado.aspx");

        }
    }
}