<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregaPerfilProfe.aspx.cs" Inherits="RemedialBitacora.PerfilProfesor.AgregaPerfilProfe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style274 {
            font-size: xx-small;
        }
        .auto-style274 {
            font-size: medium;
        }
        .auto-style274 {
            font-size: x-large;
        }
        .auto-style275 {
            width: 67px;
        }
        .auto-style276 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:azure">
           <asp:Menu ID="Menu1" runat="server" CssClass="auto-style271 auto-style272 auto-style273 auto-style274" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#FFFBD6" />
                <DynamicSelectedStyle BackColor="#FFCC66" />
                <Items>
                    <asp:MenuItem NavigateUrl="Profesor/AgregaProfesor.aspx" Text="Agregar profesor" Value="1"/>
                    <asp:MenuItem NavigateUrl="GradoEspecialidad/AgregarGradoEspe.aspx" Text="Funciones Grado especialidad" Value="2"/>
                    <asp:MenuItem NavigateUrl="PerfilProfesor/AgregaPerfilProfe.aspx" Text="Funciones Perfil Profe" Value="3"/> 
                  
                    <asp:MenuItem NavigateUrl="AsignaciondeProfeMateria/AgregaAsignacion.aspx" Text="Funciones de asignacion" Value="3"/>   
                </Items>
                <StaticHoverStyle BackColor="#990000" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#FFCC66" />
            </asp:Menu>
            <div>
                <center>
                    <div>
                           <asp:Label ID="Label1" runat="server" Text="Seleccione profesor"></asp:Label>
                           <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                           <br />
                    </div>
                    <div>
                         <asp:Label ID="Label2" runat="server" Text="Seleccione grado"></asp:Label>
                           <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                         <br />
                    </div>
                    <div>
                         <asp:Label ID="Label3" runat="server" Text="Estado"></asp:Label>
                         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                         <br />
                    </div>
                    <div>
                         <asp:Label ID="Label4" runat="server" Text="Ingrese fecha de obtencion"></asp:Label>
                         <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                         <br />
                    </div>
                    <div>
                         <asp:Label ID="Label5" runat="server" Text="Evidencia"></asp:Label>
                         <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                         <br />
                         <br />
                    </div>
                    <asp:Button ID="Button1" runat="server" Text="Agregar" CssClass="auto-style275" OnClick="Button1_Click"></asp:Button>

                 <div>
                     <h2>Mostrar tabla de registros</h2>

                     <asp:GridView ID="GridView1" runat="server" CssClass="auto-style276" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="245px">
                     </asp:GridView>
                     <br />

                 </div>
                    <br />
                    <br />
                    <br />
                    <br />

                 
                </center>
                

            </div>
            </div>
    </form>
</body>
</html>
