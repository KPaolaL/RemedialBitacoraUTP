using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClassCapaEntidades;
using ClassLogicaNegocios;
namespace RemedialBitacora.AsignaciondeProfeMateria
{
    public partial class AgregaAsignacion : System.Web.UI.Page
    {
        LogicaAsignaprofeMateriaCuatri ObjAsig = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ObjAsig = new LogicaAsignaprofeMateriaCuatri();
                Session["ObjAsig"] = ObjAsig;
                string msj = "";
                GridView1.DataSource = ObjAsig.ObtenAsig(ref msj);
                if (GridView1.DataSource != null)
                {
                    GridView1.DataBind();
                }
            }
            else
            {
                ObjAsig = (LogicaAsignaprofeMateriaCuatri)Session["objGE"];
            }
            if (!IsPostBack)
            {
                List<EntidadProfesor> Profe = null;
                string msj = "";
                Profe = ObjAsig.GetProfe1(ref msj);
                GridView1.DataSource = ObjAsig.ObtenAsig(ref msj);
                if (GridView1.DataSource != null)
                {
                    GridView1.DataBind();
                }
                if (Profe != null)
                {
                    foreach (EntidadProfesor edo in Profe)
                    {
                        DropDownList1.Items.Add(new ListItem(edo.Nombre.ToString(), edo.id_Profe.ToString()));
                        DropDownList1.DataBind();
                    }
                }
                List<EntidadMateria> mostrarMate = null;
                mostrarMate = ObjAsig.GetMateria(ref msj);
                if (Profe != null)
                {
                    foreach (EntidadMateria mat in mostrarMate)
                    {
                        DropDownList2.Items.Add(new ListItem(mat.NombreMateria.ToString(), mat.id_Materia.ToString()));
                        DropDownList2.DataBind();

                    }
                }
                //List<EntidadGrupoCuatrimestre> MostrarCuatri = null;
                //MostrarCuatri = ObjAsig.GetGrupoCuatri(ref msj);
                //if (Profe != null)
                //{
                //    foreach (EntidadGrupoCuatrimestre cua in MostrarCuatri)
                //    {
                //        DropDownList3.Items.Add(new ListItem(cua.Turno.ToString(), cua.Id_GruCuat.ToString()));
                //        DropDownList3.DataBind();
                //    }
                //}
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntidadAsignaProfeMatCuatri temp = new EntidadAsignaProfeMatCuatri
            {
                F_Profe = Convert.ToInt16(DropDownList1.SelectedValue),
                F_Materia = Convert.ToInt16(DropDownList2.SelectedValue),
               // F_GrupoCuatri = Convert.ToInt16(DropDownList3.SelectedValue),
                Extra = TextBox1.Text
            };

            string resp = "";
            Boolean recibe = false;
            recibe = ObjAsig.InsertarAsignacionProf(temp, ref resp);

        }
        protected void EliminarAsignacion(object sender, EventArgs e)
        {
            string msj = "";
            string x = ((Button)sender).CommandArgument;
            string id = x.ToString();
            ObjAsig.DeleteAsig(id, ref msj);

            GridView1.DataSource = ObjAsig.ObtenAsig(ref msj);
            if (GridView1.DataSource != null)
            {
                GridView1.DataBind();
            }
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}