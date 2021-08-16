 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregaAsignacion.aspx.cs" Inherits="RemedialBitacora.AsignaciondeProfeMateria.AgregaAsignacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div style="background-color:antiquewhite" >
    <center>
           <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" BorderStyle="Outset" CssClass="auto-style271 auto-style272 auto-style273 auto-style274">
                <Items>
                   <asp:MenuItem NavigateUrl="../inicio.aspx" Text="Regresar al inicio" Value="1"/>
                    <asp:MenuItem NavigateUrl="../GradoEspecialidad/AgregarGradoEspe.aspx" Text="Funciones Grado especialidad" Value="2"/>
                    <asp:MenuItem NavigateUrl="../PerfilProfesor/AgregaPerfilProfe.aspx" Text="Funciones Perfil Profe" Value="3"/> 
                 </Items>
            </asp:Menu>
                 <div>
                     <asp:Label ID="Label1" runat="server" Text="Selecciona profesor"></asp:Label>
                    
                     <asp:DropDownList ID="DropDownList1" runat="server">
                     </asp:DropDownList>

                 </div>
                    <div>
                        <asp:Label ID="Label2" runat="server" Text="Selecciona materia"></asp:Label>
                     <asp:DropDownList ID="DropDownList2" runat="server">
                     </asp:DropDownList>

                 </div>
                <div>
                    <asp:Label ID="Label3" runat="server" Text="Selecciona grupo cuatrimestre"></asp:Label>
                     <asp:DropDownList ID="DropDownList3" runat="server">
                     </asp:DropDownList>

                 </div>
                 <div>
                     <asp:Label ID="Label4" runat="server" Text="Extra"></asp:Label>
                     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                 </div>
        <div>

            <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" />

        </div>
        <div>
            <h2>Muestra registros agregados</h2>
            <p>
                <asp:GridView ID="GridView1" runat="server" CssClass="auto-style1" Height="171px" Width="278px">
                </asp:GridView>
            </p>

        </div>
        </center>
              </div>
        </div>
    </form>
</body>
</html>
