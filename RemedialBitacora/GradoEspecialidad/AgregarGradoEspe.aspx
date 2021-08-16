<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarGradoEspe.aspx.cs" Inherits="RemedialBitacora.GradoEspecialidad.AgregarGradoEspe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style274 {
            background-color: #9966FF;
        }
        .auto-style274 {
            text-decoration: underline;
        }
        .auto-style274 {
            text-decoration: underline;
        }
        .auto-style274 {
            text-decoration: underline;
        }
        .auto-style274 {
            text-decoration: underline;
        }
        .auto-style274 {
            text-decoration: underline;
        }
        .auto-style274 {
            background-color: #9900CC;
        }
        .auto-style274 {
            background-color: #CCCCFF;
        }
        .auto-style274 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <div>
       <div style="background-color:blanchedalmond">
         <center>
            
                <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" BorderStyle="Outset" CssClass="auto-style271 auto-style272 auto-style273 auto-style274">
                <Items>
                   
                    <asp:MenuItem NavigateUrl="../inicio.aspx" Text="Regresar al inicio" Value="1"/>
                    <asp:MenuItem NavigateUrl="../Profesor/AgregaProfesor.aspx" Text="Funciones profesor" Value="2"/>
                    <asp:MenuItem NavigateUrl="../PerfilProfesor/AgregaPerfilProfe.aspx" Text="Funciones Perfil Profe" Value="3"/> 
                    <asp:MenuItem NavigateUrl="../AsignaciondeProfeMateria/AgregaAsignacion.aspx" Text="Funciones de asignacion" Value="4"/>   
                </Items>
               </asp:Menu> 
            
            <h3>Registro de Grado especialidad</h3>
            <div class="row row-space">
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
                    <div>
                            Mostrar registros que fueron agregados<br />
                            <asp:GridView ID="GridView1" runat="server">
                                <Columns>
                                <asp:templateField headertext="Editar dato" SortExpression="[Id Especifico]">
                                    <itemtemplate>
                                    <asp:Button  OnClick="EditarDato"  ID='LinkButton1' runat="server" Text="Editar datos" CommandArgument='<%# Bind("[Codigo]")%>' >
                                    </asp:Button>
                                </itemtemplate>
                                </asp:templateField>
                                <asp:TemplateField HeaderText="Eliminar dato" SortExpression="[Id Especifico]"><ItemTemplate>
                                                                  <asp:Button  OnClick="EliminarDato"  ID='LinkButton2' runat="server" Text="Eliminar datos" CommandArgument='<%# Bind("[Codigo]")%>' >  </asp:Button>
                                
                                </ItemTemplate>
                                </asp:TemplateField>
                             </Columns>
                            </asp:GridView>
                            <br />
                    </div>
                </div>
             </div>
        </center>
          </div>  
        </div>
    </form>
</body>
</html>
