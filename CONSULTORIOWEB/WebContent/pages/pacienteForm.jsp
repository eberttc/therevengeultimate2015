<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
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
     <link href="<%=request.getContextPath()%>/css/style1.css" rel="stylesheet" media="screen">
 
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
	Paciente paciente = (Paciente)request.getAttribute("paciente");
	
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
				<input type="hidden" value="<%=paciente.getIdPaciente() %>" name="identificador" /> 
				<h4 class="page-header">Formulario de Registro</h4>
					<div class="form-group">
						<label class="col-sm-2 control-label">Nombre</label>
						<div class="col-sm-4">
							<input type="text" class="form-control" name="_nombres" data-toggle="tooltip" data-placement="bottom" title="Tooltip for name" value="<%=paciente.getNombres().getValue() %>">
						</div>
						<label class="col-sm-2 control-label">Apellido Paterno</label>
						<div class="col-sm-4">
							<input type="text" class="form-control" name="_pat" data-toggle="tooltip" data-placement="bottom" title="Tooltip for last name" value="<%=paciente.getApePaterno().getValue() %>" >
						</div>
					</div>
                    
                    <div class="form-group">
						<label class="col-sm-2 control-label">Apellido Materno</label>
						<div class="col-sm-4">
							<input type="text" class="form-control" name="_mat"  data-toggle="tooltip" data-placement="bottom" title="Tooltip for name" value="<%=paciente.getApeMaterno().getValue() %>">
						</div>
						<label class="col-sm-2 control-label">Sexo</label>
						<div class="col-sm-4">
							<input type="text" class="form-control" name="_sex"  data-toggle="tooltip" data-placement="bottom" title="Tooltip for last name" value="<%=paciente.getSexo().getValue() %>">
						</div>
					</div>
                        <div class="form-group">
						<label class="col-sm-2 control-label">Tipo de Documento</label>
						<div class="col-sm-4">
							<input type="text" class="form-control" name="_tdoc"  data-toggle="tooltip" data-placement="bottom" title="Tooltip for name" value="<%=paciente.getIdTipoDoc().intValue() %>" >
						</div>
						<label class="col-sm-2 control-label">Numero de Documento</label>
						<div class="col-sm-4">
							<input type="text" class="form-control" name="_ndoc" data-toggle="tooltip" data-placement="bottom" title="Tooltip for last name" value="<%=paciente.getNroDocumento().getValue() %>">
						</div>
					</div>
                    	<div class="form-group">
						<label class="col-sm-2 control-label">Correo</label>
						<div class="col-sm-2">
							<input type="text" class="form-control" name="_mail" value="<%=paciente.getCorreo().getValue() %>" >
							
						</div>
						<div class="col-sm-2">
							<input type="text" class="form-control" value="<%=paciente.getCorreo().getValue() %>" >							
						</div>
						<label class="col-sm-2 control-label">Direccion</label>
						<div class="col-sm-4">
							<input type="text" class="form-control" name="_direccion"  data-toggle="tooltip" data-placement="top" title="Hello world!" value="<%=paciente.getDireccion().getValue() %>">
						</div>					
					</div>
                             <div class="form-group has-feedback">
						<label class="col-sm-2 control-label">Teléfono</label>
						<div class="col-sm-4">
							<input type="text" class="form-control" name="_telefono"  data-toggle="tooltip" data-placement="bottom" title="Tooltip for name" value="<%=paciente.getTelefono().getValue() %>">
						</div>
					<label class="col-sm-2 control-label">Fecha de Nacimiento</label>
						<div class="col-sm-4">
							<input type="date" id="input_date" name="_fecnac" class="form-control" value="<%=paciente.getFecNac().toGregorianCalendar().getTime() %>" >
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
    $(document).on('ready', function () {
        //$('#input_date').datepicker({ setDate: new Date() });
    });

    $('#btnGrabar').on('click', function () {
       // window.location.href = '@Url.Action("index", "paciente")';
    });
</script>

        
    



</div>
	
</body>	
</html>