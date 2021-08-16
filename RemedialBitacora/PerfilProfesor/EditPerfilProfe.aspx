<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPerfilProfe.aspx.cs" Inherits="RemedialBitacora.PerfilProfesor.EditPerfilProfe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:cornsilk">
            <asp:Menu ID="Menu1" runat="server" Orientation="Vertical" BorderStyle="Outset" CssClass="auto-style271 auto-style272 auto-style273 auto-style274">
                <Items>
                    <asp:MenuItem NavigateUrl="../inicio.aspx" Text="Inicio" Value="1"/>
                   <asp:MenuItem NavigateUrl="../Profesor/AgregaProfesor.aspx" Text="Agregar profesor" Value="2"/>
                    <asp:MenuItem NavigateUrl="../PerfilProfesor/AgregaPerfilProfe.aspx" Text="Funciones Perfil Profe" Value="3"/> 
                    <asp:MenuItem NavigateUrl="../AsignaciondeProfeMateria/AgregaAsignacion.aspx" Text="Funciones de asignacion" Value="4"/>   
                </Items>
            </asp:Menu> 

        </div>
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
                    <asp:Button ID="Button1" runat="server" Text="Editar" CssClass="auto-style275" OnClick="Button1_Click"></asp:Button>
        
            
        <div>
            </center>
        </div>
    </form>
</body>
</html>
