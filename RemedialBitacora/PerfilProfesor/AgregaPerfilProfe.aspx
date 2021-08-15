<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregaPerfilProfe.aspx.cs" Inherits="RemedialBitacora.PerfilProfesor.AgregaPerfilProfe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
           <center><asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" BorderStyle="Outset" CssClass="auto-style271 auto-style272 auto-style273 auto-style274">
                <Items>
                    <asp:MenuItem NavigateUrl="Profesor/AgregaProfesor.aspx" Text="Agregar profesor" Value="1"/>
                    <asp:MenuItem NavigateUrl="GradoEspecialidad/AgregarGradoEspe.aspx" Text="Funciones Grado especialidad" Value="2"/>
                    <asp:MenuItem NavigateUrl="PerfilProfesor/AgregaPerfilProfe.aspx" Text="Funciones Perfil Profe" Value="3"/> 
                  
                    <asp:MenuItem NavigateUrl="AsignaciondeProfeMateria/AgregaAsignacion.aspx" Text="Funciones de asignacion" Value="3"/>   
                </Items>
            </asp:Menu> </center>
        <div>
        </div>
    </form>
</body>
</html>
