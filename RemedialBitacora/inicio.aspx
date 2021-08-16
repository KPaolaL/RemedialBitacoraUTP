<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="RemedialBitacora.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport"    content="width=device-width, initial-scale=1.0">
	<meta name="description" content="">
	<meta name="author"      content="Sergey Pozhilov (GetTemplate.com)">
    <title></title>
   <link rel="shortcut icon" href="assets/images/gt_favicon.png"  />
    	<link rel="shortcut icon" href="assets/images/gt_favicon.png" />
	
	<!-- Bootstrap itself -->
    
	<link href="http://netdna.bootstrapcdn.com/bootstrap/3.0.3/css/bootstrap.min.css" rel="stylesheet" type="text/css">

	<!-- Custom styles -->
	<link rel="stylesheet" href="assets/css/magister.css">

	<!-- Fonts -->
	<link href="http://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.min.css" rel="stylesheet" type="text/css">
	<link href='http://fonts.googleapis.com/css?family=Wire+One' rel='stylesheet' type='text/css'>
    <style type="text/css">
        .auto-style1 {
            font-family: "Wire One", Helvetica, Arial, sans-serif;
            font-weight: normal;
            font-size: 5.5em;
            color: #000000;
            line-height: .9em;
            margin-top: 0;
            margin-bottom: 40px;
        }
        .auto-style2 {
            font-family: 'Wire One', Helvetica, Arial, sans-serif;
            font-weight: normal;
            font-size: 7em;
            margin-bottom: 15px;
            color: #000000;
            line-height: 1em;
        }
        .auto-style271 {
            color: #3399FF;
        }
        .auto-style272 {
            background-color: #000000;
        }
        .auto-style273 {
            text-decoration: underline;
        }
        .auto-style274 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" BorderStyle="Outset" CssClass="auto-style271 auto-style272 auto-style273 auto-style274">
                <Items>
                    <asp:MenuItem NavigateUrl="../Profesor/AgregaProfesor.aspx" Text="Agregar profesor" Value="1"/>
                    <asp:MenuItem NavigateUrl="../GradoEspecialidad/AgregarGradoEspe.aspx" Text="Funciones Grado especialidad" Value="2"/>
                    <asp:MenuItem NavigateUrl="../PerfilProfesor/AgregaPerfilProfe.aspx" Text="Funciones Perfil Profe" Value="3"/> 
                  
                    <asp:MenuItem NavigateUrl="../AsignaciondeProfeMateria/AgregaAsignacion.aspx" Text="Funciones de asignacion" Value="4"/>   
                </Items>
            </asp:Menu> </center>
            	<div class="container">
		                <div class="row">
			                    <div class="col-md-10 col-lg-10 col-md-offset-1 col-lg-offset-1 text-center">
                                    
				                <!-- Site Title, your name, HELLO msg, etc. -->
				                <h1 class="auto-style2"><strong>Bitacora Profesores</strong></h1>
				                <h2 class="auto-style1"><strong>Registrate como profesor</strong></h2>
                                    <img src="assets/images/bita.jpg" alt="" />
                                    <h2>Realizado por Karla Paola Lopez Meza</h2>
				                </div>
		                </div> <!-- /col -->
		        </div> <!-- /row -->
	
        </div>
			<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
        <script src="http://netdna.bootstrapcdn.com/bootstrap/3.0.3/js/bootstrap.min.js"></script>

    </form>
</body>
</html>
