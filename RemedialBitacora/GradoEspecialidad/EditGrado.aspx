<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditGrado.aspx.cs" Inherits="RemedialBitacora.GradoEspecialidad.EditGrado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="background-color:gainsboro">
        <div>
                <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" BorderStyle="Outset" CssClass="auto-style271 auto-style272 auto-style273 auto-style274">
                <Items>
                   
                    <asp:MenuItem NavigateUrl="../inicio.aspx" Text="Regresar al inicio" Value="1"/>
                    <asp:MenuItem NavigateUrl="../Profesor/AgregaProfesor.aspx" Text="Funciones profesor" Value="2"/>
                    <asp:MenuItem NavigateUrl="../PerfilProfesor/AgregaPerfilProfe.aspx" Text="Funciones Perfil Profe" Value="3"/> 
                    <asp:MenuItem NavigateUrl="../AsignaciondeProfeMateria/AgregaAsignacion.aspx" Text="Funciones de asignacion" Value="4"/>   
                </Items>
               </asp:Menu>
             <div> 
             <div class="page-wrapper bg-gra-02 p-t-130 p-b-100 font-poppins">
                    <div class="wrapper wrapper--w680">
                         <div class="col-2">
                                  <div class="input-group">
                                        <label class="label">Titulo</label>
                                        <asp:TextBox ID="TextBox1"   runat="server"  BorderStyle="Solid"></asp:TextBox>  
                                   </div>
                                   </div>
                            <div class="col-2">
                                  <div class="input-group">
                                        <label class="label">Institucion</label>
                                        <asp:TextBox ID="TextBox2"   runat="server"  BorderStyle="Solid"></asp:TextBox>  
                                   </div>
                                   </div>
                              <div class="col-2">
                                  <div class="input-group">
                                        <label class="label">Pais</label>
                                        <asp:TextBox ID="TextBox3"   runat="server"  BorderStyle="Solid"></asp:TextBox>  
                                   </div>
                                   </div>
                              <div class="col-2">
                                  <div class="input-group">
                                        <label class="label">Extra</label>
                                        <asp:TextBox ID="TextBox4"   runat="server"  BorderStyle="Solid"></asp:TextBox>  
                                   </div>
                                   </div>
                <div>
                            <asp:Button ID="Button1" runat="server" Text="Insertar" OnClick="Button1_Click"></asp:Button>
                    
                            <br />
                            <br />
                    </div>
                 </div>
              </div>
        </div>
    </form>
</body>
</html>
