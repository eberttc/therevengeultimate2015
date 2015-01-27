<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    
<%@ taglib uri="http://java.sun.com/jstl/core_rt" prefix="c" %>
<!DOCTYPE html>
<html lang="en">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Listado de Medicos</title>
  <!-- Bootstrap core CSS -->
  
 
 	<!-- Bootstrap core CSS -->
     <link href="<%=request.getContextPath()%>/css/bootstrap.css" rel="stylesheet" media="screen">
 
 	<script src="<%=request.getContextPath()%>/js/jquery-1.10.2.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="<%=request.getContextPath()%>/js/bootstrap-3.0.0.js"></script>
     
  
</head>



<script type="text/javascript">

$(document).ready(function() {

		
} );




</script>
	
  <body>
  
  <jsp:include page="/pages/header.jsp" />
  <form id="frmMorosos" action="${pageContext.request.contextPath}/pages/RegistrarMedico.jsp">
  
   
			  
  <input type="hidden" id="hidopcion"  name="opcion">  
    <div class="jumbotron">
      <div class="container">
        <h3>Listado de Medicos</h3>
			
      </div>
    </div>
    <div class="container">
        
          <div class="form-group">
				           <c:if test="${requestScope.mensaje!='1'}">
					          <div class="row">
					            <div class="col-md-2" align="center">
					              <input class="btn btn-primary" type="submit" value="Nuevo">			              			             
					            </div>
					            <div class="col-md-10" align="center">
					             			              			             
					            </div>
					            
					          </div>	
				          </c:if>	
			   </div> 
      <br>
      <table class="table table-bordered table-hover" id="jqueryDataTable">
        <thead>
          <tr class="success">
            <th>id</th>
            <th>Nombre Medico</th>
            <th>Apellido Paterno</th>
            <th>Apellido Materno</th>
            <th>Cmp</th>
            <th>opciones</th>
                      
          </tr>
        </thead>
        <tbody>
         
          
          <tr>
          	<td>1</td>
          	<td>Miguel</td>
          	<td>Merino</td>
          	<td>Merino}</td>
          	<td>12345678</td>
          	<td><a href="<%=request.getContextPath()%>/pages/RegistrarMedico.jsp">Editar</a></td>                    	          	          	          		           	       
          </tr>
        </tbody>
      </table>  
      <footer></footer>
    </div>
  
    </form>
  </body>
	
</html>