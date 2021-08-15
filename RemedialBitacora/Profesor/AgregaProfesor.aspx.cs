using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClassCapaEntidades;
using ClassLogicaNegocios;

namespace RemedialBitacora.Profesor
{
    public partial class AgregaProfesor : System.Web.UI.Page
    {
        LogicaProfesor objlogProf = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                objlogProf = new LogicaProfesor();
                Session["objlogProf"] = objlogProf;
                string msj = "";
                GridView1.DataSource = objlogProf.ObtenerProfesores(ref msj);
                if (GridView1.DataSource != null)
                {
                    GridView1.DataBind();
                }
            }
            else
            {
                objlogProf = (LogicaProfesor)Session["objlogProf"];
            }
            if (!IsPostBack)
            {
                List<EntidadEstadoCiv> EstadoCiv = null;
                string msj = "";
                EstadoCiv = objlogProf.GetEstadoCivi(ref msj);
                if (EstadoCiv != null)
                {
                    foreach (EntidadEstadoCiv edo in EstadoCiv)
                    {
                        DropDownList1.Items.Add(new ListItem(edo.Estado.ToString(), edo.idEdo.ToString()));
                        DropDownList1.DataBind();
                    }
                }
            }


        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            EntidadProfesor temp = new EntidadProfesor
            {
                RegistroEmpleado = Convert.ToInt32(TextBox1.Text),
                Nombre = TextBox2.Text,
                ApellidoP = TextBox3.Text,
                ApellidoM = TextBox4.Text,
                Genero = TextBox5.Text,
                Categoria = TextBox6.Text,
                Correo = TextBox7.Text,
                Celular = TextBox8.Text,
            };

            if (DropDownList1.SelectedItem != null)
            {
                Session["Id_Edo"] = Convert.ToInt32(DropDownList1.SelectedValue);
            };

            EntidadEstadoCiv EstadoCiv = new EntidadEstadoCiv
            {
                idEdo = Convert.ToInt32(Session["Id_Edo"])
            };

            string resp = "";
            Boolean recibe = false;
            recibe = objlogProf.InsertaProf(temp, EstadoCiv, ref resp);
            //string mensaje = "";
            TextBox1.Text = resp;

        }

        protected void EliminarProfesor (object sender, EventArgs e)
        {
            string msj = "";
            string x = ((Button)sender).CommandArgument;
            string id = x.ToString();
            objlogProf.DeleteProfe(id, ref msj);

            GridView1.DataSource = objlogProf.ObtenerProfesores(ref msj);
            if (GridView1.DataSource != null)
            {
                GridView1.DataBind();
            }
        }

        protected void EditarProfesor(object sender, EventArgs e)
        {
            string x = ((Button)sender).CommandArgument;
            Session["id_seleccionado"] = Convert.ToInt32(x);
            Server.Transfer("EditarProfe.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}