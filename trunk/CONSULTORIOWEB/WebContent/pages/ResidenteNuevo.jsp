<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
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
  
    
	<title>Condominio</title>
</head>
<%
	String mensaje=request.getAttribute("mensaje")==null?"":request.getAttribute("mensaje").toString();
	String vreturn=request.getAttribute("vreturn")==null?"":request.getAttribute("vreturn").toString();
	String tipoDocumento=request.getAttribute("txtTipoDocumento")==null?"":request.getAttribute("txtTipoDocumento").toString();

	
%>
<body>

	
	
	<jsp:include page="../pages/header.jsp" />

	<div>	
	<br>
	<br>
	<br>
	
	<fieldset class="form-horizontal well">
		
		<form id="form1" name="form1" method="post" action="ResidenteServlet?Param=insertar">	
	
		<%@page import="java.util.*, com.upc.condominio.modelo.*" %>
				
		<h3>Nuevo Residente</h3>
		
		<TABLE WIDTH=300>
		
			<TR>
				<TD WIDTH=100>	
					Nombre:
				</TD>
				
				<TD WIDTH=100>
					<input id="txtNombre" name="txtNombre" type="text" value="${requestScope.txtNombre}" required autofocus/>
				</TD>
			</TR>
			
			<TR>
				<TD WIDTH=100>	
					Tipo Doc.: 
				</TD>
				
				<TD WIDTH=100>			
					<select id="txtTipoDocumento" name="txtTipoDocumento" >
					  <option value="1" <%if(tipoDocumento.equals("1")){%>selected<%}%>>DNI</option>
					  <option value="2" <%if(tipoDocumento.equals("2")){%>selected<%}%>>CARNET EXTRANJERIA</option>			  
					</select>
				</TD>
			</TR>
			
			<TR>
				<TD WIDTH=100>	
					Num. Doc.: 
				</TD>
				
				<TD WIDTH=100>
					<input id="txtNuDocumento" name="txtNuDocumento" value="${requestScope.txtNuDocumento}" min="0" max="9999999999"  type="number" required autofocus style=" width : 179px;"/>
				</TD>
			</TR>
			
			<TR>
				<TD WIDTH=100>	
					Fecha Nac.:
				</TD>
				
				<TD WIDTH=100>
					 <input id="txtFeNac" name="txtFeNac" value="${requestScope.txtFeNac}" type="date" required autofocus/>
				</TD>
			</TR>
			
			<TR>
				<TD WIDTH=100>	
					Correo:
				</TD>
				
				<TD WIDTH=100>
					 <input id="txtCorreo" name="txtCorreo" type="email"  value="${requestScope.txtCorreo}"required autofocus/>
				</TD>
			</TR>
			
			<TR>
				<TD WIDTH=100>	
					
				</TD>
				
				<TD WIDTH=100>
					<button id="botonEnviar" type="submit" class="btn btn-primary" >Enviar</button>
																
				</TD>
			</TR>		
			
			
		
		</TABLE>
				
				
		<p/>&nbsp;	
		</form>
	</fieldset>
	</div>
	
	<script>
		
		if("<%=mensaje%>"=='1'){
			bootbox.alert("<%=vreturn%>");
			  
		}
	</script>
</body>
</html>