<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    
<%@ taglib uri="http://java.sun.com/jstl/core_rt" prefix="c" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
  <head>
    <title>Registro de Visitantes</title>
    <meta name="viewport" content="width=device-width">
    <link rel="stylesheet" href="https://netdna.bootstrapcdn.com/bootstrap/3.0.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.0.3/jquery.min.js" type="text/javascript"></script>
    <script src="https://netdna.bootstrapcdn.com/bootstrap/3.0.1/js/bootstrap.min.js" type="text/javascript"></script>
  </head>
 
<body>

  	<jsp:include page="/pages/header.jsp" />
  	<div class="jumbotron">
      <div class="container">
        <h3>REGISTRO DE VISITANTES</h3>
        <p></p>
      </div>
    </div>
    <form method="post" action="<%=request.getContextPath()%>/VisitanteServlet">
      
      <div class="container">      
        <table class="table">        
          <tbody>
            <tr>
              <td>DNI Visitante:</td>
              <td>
                <input class="form-control" type="text" id="txtDNIVisitante" name="txtDNIVisitante" required autofocus>
              </td>
            </tr>
            <tr>
              <td>Nombre Visitante:</td>
              <td>
                <input class="form-control" type="text" id="txtNombreVisitante" name="txtNombreVisitante" required>
              </td>
            </tr>
            <tr>
              <td>Residente:</td>
              <td>
                <select class="form-control" id="txtResidente" name="txtResidente">
               	<c:forEach items="${requestScope.residentes}" var="residente" varStatus="i">
					 <option value="<c:out value='${residente.idResidente}'/>"> 
						 <c:out value='${residente.nombreResidente}'/> 
					 </option>
								
				</c:forEach>
                 
                </select>
              </td>
            </tr>
            <tr>
              <td>Fecha de Visita:</td>
              <td>
                <input class="form-control" type= "date" id="txtFechaVisita" name="txtFechaVisita" required />
              </td>
            </tr>
            <tr>
              <td></td>
              <td>
                <div class="btn-group">
                  <input id="botonEnviar" class="btn btn-default" type="submit" value="ENVIAR">
                </div>
                <div>
                 <%
            String aux = request.getParameter("aux");
            if(aux != null && aux.equals("y")){%>
            		  <p></p>
			          <div class="alert alert-success">
			            <button type="button" class="close" data-dismiss="alert">&times;</button>
			            <b>En hora buena,</b>El registro se insert� con �xito.
			          </div>
            	
            <%}else if(aux != null && aux.equals("n")){%>
			          <p></p>
			          <div class="alert alert-danger">
			            <button type="button" class="close" data-dismiss="alert">&times;</button>
			            <b>ERROR!</b> No se pudo insertar los registros.
			          </div>
            		
            	<%}%>
                </div>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </form>


</body>
</html>