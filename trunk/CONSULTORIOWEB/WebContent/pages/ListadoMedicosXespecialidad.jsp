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

	function listado(tipoEspecialidad){	  
		
		        var f=parent.document.forms[0];
		        var codigoHidden= f.codMed.value;
				if(tipoEspecialidad!="-1"){					
					url = "<%=request.getContextPath()%>/ReservaCitaServlet?accion=listadoMedico&tipo="+tipoEspecialidad+"&codigoHidden="+codigoHidden;            
			    	parent.window.document.ifrmMedicos.location.replace(url);
				}
	    	
		}
	
	

		
    	function devuelveCodigo(){
    			
   			 return CodigoMedico();
   		} 
          
  

</script>
	
 <script type="text/javascript">
    $(document).ready(function() {
			
    	CodigoMedico = function (){
    		 
   			 var radioPRM = $("input[id=rbdMed]:checked").attr('codigoMedico');
   			 return radioPRM;
   		}
    	
    	
          
   });
    </script>	
  <body>    			   
          
      <br>
      <table class="table table-bordered table-hover" id="jqueryDataTable">
        <thead>
          <tr class="success">
            <th>id</th>
            <th>Nombre Medico</th>
            <th>Apellido Paterno</th>
            <th>Apellido Materno</th>
            <th>Cmp</th>
            <th>Seleccionar</th>
                      
          </tr>
        </thead>
        <tbody>
         
          <c:forEach var="bean" items="${requestScope.listadoMedico}" varStatus="i">
          <tr>
          	<td>${bean.idMedico}</td>
          	<td>${bean.nombre}</td>
          	<td>${bean.ape_Paterno}</td>
          	<td>${bean.ape_Materno}</td>
          	<td>${bean.cmp}</td>
          	<td><input type="radio" id="rbdMed" name="rbdMedico" codigoMedico='<c:out value="${bean.idMedico}"/>'  <c:if test="${bean.idMedico==requestScope.codigoHidden}">checked</c:if>  ></td>                    	          	          	          		           	                 	
          </tr>
           </c:forEach>
        </tbody>
      </table>        
  </body>
	
</html>