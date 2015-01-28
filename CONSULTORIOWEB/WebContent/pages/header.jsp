<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
<!-- Bootstrap core CSS -->
    <link href="<%=request.getContextPath()%>/css/bootstrap.css" rel="stylesheet" media="screen">

</head>
<body>
<!-- Static navbar -->
	  <div class="navbar navbar-default navbar-static-top">
	    <div class="container">
	      <div class="navbar-header">
	        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
	          <span class="icon-bar"></span>
	          <span class="icon-bar"></span>
	          <span class="icon-bar"></span>
	        </button>
	        <a class="navbar-brand">Condominio</a>
	      </div>
	      <div class="navbar-collapse collapse">
	        <ul class="nav navbar-nav">
	          <li class="active"><a href="principal.jsp">Inicio</a></li>
	          <li class="dropdown">
	            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Mantenimientos <b class="caret"></b></a>
	            <ul class="dropdown-menu">	             
	              <li><a href="<%=request.getContextPath()%>/PacienteServlet?_target=pacientes">Paciente</a></li>	              
	             <!--  <li><a href="<%=request.getContextPath()%>/ResidenteServlet?Param=" target="_top">Medicos</a></li> -->	              	             	             
	              <li><a href="<%=request.getContextPath()%>/pages/ListadoMedicos.jsp" target="_top">Medicos</a></li>
	            </ul>
	          </li>
	         
	          <li class="dropdown">
	            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Citas <b class="caret"></b></a>
	            <ul class="dropdown-menu">	             	            	             
	              <li><a href="<%=request.getContextPath()%>/pages/ListadoCitas.jsp" target="_top">Listado de Citas</a></li>	                        	             	             
	            </ul>
	          </li>
	          
	          <li class="dropdown">
	            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Registros<b class="caret"></b></a>
	            <ul class="dropdown-menu">	             
	              <li><a href="<%=request.getContextPath()%>/pages/RegistrarAtencion.jsp" target="_top">Registro Atencion</a></li>	              
	                           	             	             
	            </ul>
	          </li>
	          <li class="dropdown">
	            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Reservas <b class="caret"></b></a>
	            <ul class="dropdown-menu">	             
	              <li><a href="<%=request.getContextPath()%>/pages/ingresarReserva.jsp" target="_top">Citas</a></li>	              
	                           	             	             
	            </ul>
	          </li>

	          <li><a href="<%=request.getContextPath()%>/LogoutServlet" target="_top">Salir</a></li>
	        </ul>
	      </div><!--/.nav-collapse -->
	    </div>
	  </div>
</body>
</html>