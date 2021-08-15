using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClassLogicaNegocios;
using ClassCapaEntidades;

namespace RemedialBitacora.Profesor
{
    public partial class EditarProfe : System.Web.UI.Page
    {
        LogicaProfesor objlogProf = null;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                objlogProf = new LogicaProfesor();
                Session["objlogProf"] = objlogProf;


            }
            else
            {
                objlogProf = (LogicaProfesor)Session["objlogProf"];
            }

            if (!IsPostBack)
            {
                List<EntidadProfesor> mostrarProfesores = null;
                string msj = "";
                string id = Convert.ToString(Session["id_seleccionado"]);
                mostrarProfesores = objlogProf.ListaProfesores(id, ref msj);
                if (mostrarProfesores != null)
                {
                    foreach (EntidadProfesor profesor in mostrarProfesores)
                    {
                        TextBox1.Text = profesor.RegistroEmpleado.ToString();
                        TextBox2.Text = profesor.Nombre;
                        TextBox3.Text = profesor.ApellidoP;
                        TextBox4.Text = profesor.ApellidoM;
                        TextBox5.Text = profesor.Genero;
                        TextBox6.Text = profesor.Categoria;
                        TextBox7.Text = profesor.Correo;
                        TextBox8.Text = profesor.Celular;
                        
                    }
                }
                List<EntidadEstadoCiv> mostrarEstados = null;
                mostrarEstados = objlogProf.GetEstadoCivi(ref msj);
                if (mostrarEstados != null)
                {
                    foreach (EntidadEstadoCiv estado in mostrarEstados)
                    {
                        DropDownList1.Items.Add(new ListItem(estado.Estado.ToString(), estado.idEdo.ToString()));
                        DropDownList1.DataBind();
                    }
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            EntidadProfesor  temp = new EntidadProfesor
            {
                RegistroEmpleado = Convert.ToInt32(TextBox1.Text),
                Nombre = TextBox2.Text,
                ApellidoP = TextBox3.Text,
                ApellidoM = TextBox4.Text,
                Genero = TextBox5.Text,
                Categoria = TextBox6.Text,
                Correo = TextBox7.Text,
                Celular = TextBox8.Text,
                F_EdoCivil = Convert.ToInt32(DropDownList1.SelectedValue)
            };
            
            string resp = "";
            Boolean recibe = false;
            string id = Convert.ToString(Session["id_seleccionado"]);
            recibe = objlogProf.UpdateProfesor(temp, id, ref resp);
            //string mensaje = "";
            Server.Transfer("AgregaProfesor.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("AgregaProfesor.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}