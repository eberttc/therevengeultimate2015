<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<%@ page import="java.util.List" %>
<%@ page import="java.util.ArrayList" %>
<%@ page import="com.upc.consultorio.ws.proxy.Paciente" %>    
<!DOCTYPE html>
<html lang="en">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">
    <meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
	

 	<!-- Bootstrap core CSS -->
     <link href="<%=request.getContextPath()%>/css/bootstrap.css" rel="stylesheet" media="screen">
 
 	<script src="<%=request.getContextPath()%>/js/jquery-1.10.2.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="<%=request.getContextPath()%>/js/bootstrap-3.0.0.js"></script>
       <script src="<%=request.getContextPath()%>/js/bootbox.min.js"></script>
  
    
	<title>Consultorio</title>
</head>
<%
	/**String mensaje=request.getAttribute("mensaje")==null?"":request.getAttribute("mensaje").toString();
	String vreturn=request.getAttribute("vreturn")==null?"":request.getAttribute("vreturn").toString();
String tipoDocumento=request.getAttribute("txtTipoDocumento")==null?"":request.getAttribute("txtTipoDocumento").toString();**/	

	
%>
<body>
	
	<jsp:include page="../pages/header.jsp" />
<div class="container">
	<div class="row">
	<div class="col-xs-12">
		<div class="box">
			<div class="box-header">
				<div class="box-name">
					<i class="fa fa-usd"></i>
					<span>Listado de Pacientes</span>
				</div>
				<div class="box-icons">
					<a class="collapse-link">
						<i class="fa fa-chevron-up"></i>
					</a>
					<a class="expand-link">
						<i class="fa fa-expand"></i>
					</a>
					<a class="close-link">
						<i class="fa fa-times"></i>
					</a>
				</div>
				<div class="no-move"></div>
			</div>
			<div class="box-content no-padding">
				<table class="table table-bordered table-striped table-hover table-heading table-datatable" id="datatable-1">
					<thead>
						<tr>
							<th>Código</th>
							<th>Nombres</th>														
							<th>Dirección</th>                            
							<th>Operación</th>
						</tr>
					</thead>
					<tbody>
					<!-- Start: list_row -->
					<% List<Paciente> pacientes = (List<Paciente>)request.getAttribute("listaPacientes"); %>
					<% for(Paciente paciente : pacientes) { %>
						<tr>							
							<td><%= paciente.getNroDocumento().getValue() %></td>
							<td><img class="img-rounded" src="http://i.forbesimg.com/media/lists/people/carlos-slim-helu_50x50.jpg" alt=""> <%= paciente.getNombres().getValue() %> </td>														
							<td><%=paciente.getDireccion().getValue() %></td>							
								<td>
                            <div class="row">
                            <div class="col-lg-12">
                                <div class="btn-group">
									<a class="btn btn-primary" href="#"><i class="fa fa-desktop fa-fw"></i> Acción <i class="fa"></i></a>
									<a href="#" data-toggle="dropdown" class="btn btn-primary dropdown-toggle">
									<span class="fa fa-caret-down"></span></a>
									<ul class="dropdown-menu">
										<li><a href='<%=request.getContextPath() %>/PacienteServlet?_target=formulario&param=<%=paciente.getIdPaciente().intValue()%>'><i class="fa fa-pencil fa-fw"></i> Edit</a></li>
										<li><a href="#"><i class="fa fa-trash-o fa-fw"></i> Delete</a></li>
									</ul>
								</div>
                            </div>
                            </div>
                            </td>
						</tr>
					<%} %>						
					</tbody>				
				</table>
			</div>
		</div>
	</div>
</div> 
<div class="row">		
		<div class="col-sm-12" >
			<div class="bs-example">				
				<button class="btn  btn-danger" type="button" style="float:right"   id="btnAgregar">Agregar</button>				
			</div>
		</div>
</div>
</div>
	
</body>
</html>