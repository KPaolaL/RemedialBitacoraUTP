<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregaProfesor.aspx.cs" Inherits="RemedialBitacora.Profesor.AgregaProfesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="vendor/mdi-font/css/material-design-iconic-font.min.css" rel="stylesheet" media="all"/>
        <link href="vendor/font-awesome-4.7/css/font-awesome.min.css" rel="stylesheet"  media="all" />
        <link href="https://fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet"/>
        <link href="vendor/select2/select2.min.css" rel="stylesheet"  media="all"/>
        <link href="vendor/datepicker/daterangepicker.css" rel="stylesheet" media="all" />
        <link href="css/main.css" rel="stylesheet"  media="all" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Registro de profesores</h3>
                              <div class="row row-space">
                            <div class="col-2">
                                  <div class="input-group">
                                        <label class="label">Registro Empleado</label>
                                        <asp:TextBox ID="TextBox1"   runat="server"  BorderStyle="Solid"></asp:TextBox>  
                                   </div>
                                   </div>
                                   <div class="col-2">
                                  <div class="input-group">
                                        <label class="label">Nombre</label>
                                        <asp:TextBox ID="TextBox2"   runat="server"  BorderStyle="Solid"></asp:TextBox>  
                                   </div>
                                   </div>
                                  <div class="col-2">
                                  <div class="input-group">
                                        <label class="label">Apellido paterno</label>
                                        <asp:TextBox ID="TextBox3"   runat="server"  BorderStyle="Solid"></asp:TextBox>  
                                   </div>
                                   </div>
                                  <div class="col-2">
                                  <div class="input-group">
                                        <label class="label">Apellido materno</label>
                                        <asp:TextBox ID="TextBox4"   runat="server"  BorderStyle="Solid"></asp:TextBox>  
                                   </div>
                                   </div>
                                  <div class="col-2">
                                  <div class="input-group">
                                        <label class="label">Genero</label>
                                        <asp:TextBox ID="TextBox5"   runat="server"  BorderStyle="Solid"></asp:TextBox>  
                                   </div>
                                   </div>
                                  <div class="col-2">
                                  <div class="input-group">
                                        <label class="label">Categoria:</label>  
                                        <asp:TextBox ID="TextBox6"   runat="server" ></asp:TextBox>  
                                   </div>
                                   </div>
                                   <div class="col-2">
                                   <div class="input-group">
                                        <label class="label">Correo: </label>
                                        <asp:TextBox ID="TextBox7"  runat="server" BorderColor="Black" BorderStyle="Solid" Height="37px" Width="220px"></asp:TextBox>
                                     </div>
                                    </div>
                                  <div class="col-2">
                                   <div class="input-group">
                                        <label class="label">Celular: </label>
                                        <asp:TextBox ID="TextBox8"  runat="server" BorderColor="Black" BorderStyle="Solid" Height="37px" Width="220px"></asp:TextBox>
                                     </div>
                                    </div>
                                  <div>
                                      <div class="col-2">
                                    <div class="input-group">
                                        <label class="label">Estado civil: </label>
                                        <div>
                                           
                                        </div>
                                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                                        </div>
                                   </div>
                                      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agragar profesor" />
                                      <asp:Button ID="Button2" runat="server" Text="Regresar" />
                                      <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                                  </div>
        </div>
            <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/select2/select2.min.js"></script>
    <script src="vendor/datepicker/moment.min.js"></script>
    <script src="vendor/datepicker/daterangepicker.js"></script>
    <script src="js/global.js"></script>
        </div>
    </form>
</body>
</html>
