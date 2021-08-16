using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassCapaEntidades;
using ClassLogicaNegocios;

namespace RemedialBitacora.PerfilProfesor
{
    public partial class AgregaPerfilProfe : System.Web.UI.Page
    {
        LogicaPerfilProfe LogPer = null;
        LogicaProfesor LogProf = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                LogPer = new LogicaPerfilProfe();
             
                Session["LogPer"] = LogPer;
                string msj = "";
                GridView1.DataSource = LogPer.ObtenerPerfil(ref msj);
                if (GridView1.DataSource != null)
                {
                    GridView1.DataBind();
                }
            }
            else
            {
                LogPer = (LogicaPerfilProfe)Session["LogPer"];
            }
            if (!IsPostBack)
            {
                List<EntidadProfesor> Profe = null;
                string msj = "";
                Profe = LogPer.GetProfe(ref msj);
                if (Profe != null)
                {
                    foreach (EntidadProfesor edo in Profe)
                    {
                        DropDownList1.Items.Add(new ListItem(edo.Nombre.ToString(), edo.id_Profe.ToString()));
                        DropDownList1.DataBind();
                    }
                }
            }
            if (!IsPostBack)
            {
                List<EntidadGradoEspecialidad> Profe = null;
                string msj = "";
                Profe = LogPer.GetGrado(ref msj);
                if (Profe != null)
                {
                    foreach (EntidadGradoEspecialidad edo in Profe)
                    {
                        DropDownList2.Items.Add(new ListItem(edo.Titulo.ToString(), edo.id_Grado.ToString()));
                        DropDownList2.DataBind();

                    }
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntidadPerfilProfe temp = new EntidadPerfilProfe
            {
                F_Profe = Convert.ToInt16(DropDownList1.SelectedValue),
                F_Grado = Convert.ToInt16(DropDownList2.SelectedValue),
                Estado = TextBox1.Text,
                FechaObtencion = Calendar1.SelectedDate,
                Evidencia = TextBox2.Text
            };


            string resp = "";
            Boolean recibe = false;
            recibe = LogPer.InsertarPerfil(temp, ref resp);
       
           // TextBox1.Text = resp;
            //TextBox2.Text = DropDownList2.SelectedValue;

        }
        protected void EliminarPerfil (object sender, EventArgs e)
        {
            string msj = "";
            string x = ((Button)sender).CommandArgument;
            string id = x.ToString();
            LogPer.DeletePerfil(id, ref msj);

            GridView1.DataSource = LogPer.ObtenerPerfil(ref msj);
            if (GridView1.DataSource != null)
            {
                GridView1.DataBind();
            }
        }
        protected void EditarPerfil(object sender, EventArgs e)
        {
            string x = ((Button)sender).CommandArgument;
            Session["id_seleccionado"] = Convert.ToInt32(x);
            Server.Transfer("EditPerfilProfe.aspx");

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}