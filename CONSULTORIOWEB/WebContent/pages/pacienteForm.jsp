<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<%@ page import="com.upc.condominio.forms.PacienteForm" %>
<%@ page import="pe.com.consultorio.ws.TipoDocumento" %>
<%@ page import="java.util.List" %>    

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
     <link href="<%=request.getContextPath()%>/css/style1.css" rel="stylesheet" media="screen">
 
 	<script src="<%=request.getContextPath()%>/js/jquery-1.10.2.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="<%=request.getContextPath()%>/js/bootstrap-3.0.0.js"></script>
       <script src="<%=request.getContextPath()%>/js/bootbox.min.js"></script>
  <script src="<%=request.getContextPath()%>/js/jquery-ui-11.js"></script>
    
	<title>Consultorio</title>
</head>
<%
	
	PacienteForm form = (PacienteForm)request.getAttribute("pacienteForm");
	List<TipoDocumento> listaDocumento = (List<TipoDocumento>)request.getAttribute("tipos_documento"); 
	
%>
<body>	
<jsp:include page="../pages/header.jsp" />
<div class="container">
<div class="row">
	<div class="col-xs-12 col-sm-12">
		<div class="box">
			<div class="">
				<div class="box-name">
					<i class="fa fa-search"></i>					
				</div>				
				<div class="no-move"></div>
			</div>
			<div class="box-content">
				<form action='<%=request.getContextPath()%>/PacienteServlet?_target=pacientes&action=<%=request.getAttribute("action") %>' method="post">
				<input type="hidden" value="<%=form.getIdentificador() %>" name="_identificador" /> 
				<h4 class="page-header">Formulario de Registro</h4>
				
				       <div style="padding-top:30px" class="panel-body" >
                    	 <% if (request.getAttribute("isSaved") != null) { %>
                    	<!--  <div id="alertSuccess" class="alert alert-success" role="alert">  <strong>Correcto ! </strong> El registro ha sido guardado     </div>
                    	<script type="text/javascript">$("#alertSuccess").fadeOut(3000);</script> -->
                    	<% } %>
                    	<% if (request.getAttribute("errors") != null) { %>
						<div id="alertError" class="alert alert-danger" role="alert"><Strong>Error ! </Strong>
							<% for(Object error : (Object[])request.getAttribute("errors")){ %>
							<p><%=error %></p>
							<%} %>
						</div>
						<% } %>

                        <div style="display:none" id="login-alert" class="alert alert-danger col-sm-12"></div>
                        </div>
				
					<div class="form-group">
						<label class="col-sm-2 control-label">Nombre</label>
						<div class="col-sm-4">
							<input type="text" class="form-control" name="_nombre" data-toggle="tooltip" data-placement="bottom" title="Tooltip for name" value="<%=form.getNombre() %>">
						</div>
						<label class="col-sm-2 control-label">Apellido Paterno</label>
						<div class="col-sm-4">
							<input type="text" class="form-control" name="_apellidoPaterno" data-toggle="tooltip" data-placement="bottom" title="Tooltip for last name" value="<%=form.getApellidoPaterno() %>" >
						</div>
					</div>
                    
                    <div class="form-group">
						<label class="col-sm-2 control-label">Apellido Materno</label>
						<div class="col-sm-4">
							<input type="text" class="form-control" name="_apellidoMaterno"  data-toggle="tooltip" data-placement="bottom" title="Tooltip for name" value="<%=form.getApellidoMaterno()%>">
						</div>
						<label class="col-sm-2 control-label">Sexo</label>
						<div class="col-sm-4">
						<select class="form-control" name="_sexo"  data-toggle="tooltip" data-placement="bottom">
						<% if(form.getSexo().equals("F")) {%>
								<option selected="selected" value="F">Femenino</option>
								<option  value="M">M</option>
						<% }else{ %>											
								<option selected="selected" value="M">Masculino</option>
								<option  value="F">F</option>						
						<% } %>
						</select>							
						</div>
					</div>
                        <div class="form-group">
						<label class="col-sm-2 control-label">Tipo de Documento</label>
						<div class="col-sm-4">
							<select class="form-control" name="_tipoDocumento"  data-toggle="tooltip" data-placement="bottom">
							<% for (TipoDocumento item : listaDocumento) {%>
								<% if(item.getIDTipoDoc().toString().equals(form.getTipoDocumento())) {%>
								<option selected="selected" value="<%=item.getIDTipoDoc()%>"><%= item.getDescripcion() %></option>
								<% } else{ %>								
								<option  value="<%=item.getIDTipoDoc()%>"><%= item.getDescripcion() %></option>
								<% } %>
							<%} %>
							</select>
							
							<!-- <input type="text" class="form-control" name="_tipoDocumento"  data-toggle="tooltip" data-placement="bottom" title="Tooltip for name" value="<%=form.getTipoDocumento() %>" >-->
						</div>
						<label class="col-sm-2 control-label">Numero de Documento</label>
						<div class="col-sm-4">
							<input type="text" class="form-control" name="_numeroDocumento" data-toggle="tooltip" data-placement="bottom" title="Tooltip for last name" value="<%=form.getNumeroDocumento() %>">
						</div>
					</div>
                    	<div class="form-group">
						<label class="col-sm-2 control-label">Correo</label>
						<div class="col-sm-2">
							<input type="text" class="form-control" name="_correo" value="<%=form.getCorreo() %>" >
							
						</div>
						<div class="col-sm-2">
							<input type="text" class="form-control" name="_correo_dup" value="<%=form.getCorreo() %>" >							
						</div>
						<label class="col-sm-2 control-label">Direccion</label>
						<div class="col-sm-4">
							<input type="text" class="form-control" name="_direccion"  data-toggle="tooltip" data-placement="top" title="Hello world!" value="<%=form.getDireccion() %>">
						</div>					
					</div>
                             <div class="form-group has-feedback">
						<label class="col-sm-2 control-label">Teléfono</label>
						<div class="col-sm-4">
							<input type="text" class="form-control" name="_telefono"  data-toggle="tooltip" data-placement="bottom" title="Tooltip for name" value="<%=form.getTelefono() %>">
						</div>
					<label class="col-sm-2 control-label">Fecha de Nacimiento</label>
						<div class="col-sm-4">
							<input type="text" id="input_date" name="_fechaNacimiento" class="form-control" readonly="readonly" value="<%=form.getFechaNacimiento() %>" >
							<span class="fa fa-calendar txt-danger form-control-feedback"></span>
						</div>
					</div>


					
					<div class="form-group">	                    
						<div class="col-sm-4">
							<button type="submit" class="btn btn-primary" >
							<span><i class="fa fa-clock-o"></i></span>
							    Grabar
							</button>
						</div>
					</div>    
					<div class="clearfix"></div>
					</form>
			</div>
		</div>
	</div>
</div>

<script type="text/javascript">
$(document).on('ready' , function(){
	var fecNacimientio="";
	<% if (!form.getFechaNacimiento().equals("")) { %>
	 fecNacimientio = <%=form.getFechaNacimiento() %>;
	<% }%>
	$('#input_date').datepicker({ setDate: fecNacimientio ==='' ? new Date() : fecNacimientio  , dateFormat: 'dd/mm/yy' });
});
</script>                

</div>
	
</body>	
</html>