<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    
<%@ taglib uri="http://java.sun.com/jstl/core_rt" prefix="c" %>
<html>
  
  <head>
  <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>Reserva Cita de Atencion</title>    
  	<meta name="viewport" content="width=device-width">
   	<link href="<%=request.getContextPath()%>/css/bootstrap.css" rel="stylesheet" media="screen">
 	 <script src="<%=request.getContextPath()%>/js/jquery-1.10.2.js"></script> 	 
 	 <script src="<%=request.getContextPath()%>/js/bootbox.min.js"></script> 	  	 	    
     <script src="<%=request.getContextPath()%>/js/bootstrap-3.0.0.js"></script>
    <style type="text/css">
      body {
        padding-bottom: 20px;
      }
    </style>
    <script language="javascript" >
   
     
		
			window.name="medicos";
		    function grabar(){
		    
		    	    bootbox.alert("Registro de reserva exitoso,su numero de cita es 989999");
		    		  	<%-- 	
		    		  		 var f=document.forms[0];        	        	
		    					var url="<%=request.getContextPath()%>/pages/ListadoMedicos.jsp";							
		    					f.action=url;
		    					f.submit();
		    	
		    		 --%>
		    	   
		
		       	
		
		    }
		    
		    
		    function cancelar(){
		        
		    	var f=document.forms[0];
		    	        		
					var url="<%=request.getContextPath()%>/pages/principal.jsp";							
					f.action=url;
					f.submit();
		
		       	
		
		    }
		    
    
    </script>
    	

    	

       
      
      
         
  </head>
  
  <body>
  <jsp:include page="../pages/header.jsp" />
    <!-- Main jumbotron for a primary marketing message or call to action -->
    <div class="jumbotron">
      <div class="container">
        <h3>RESERVA DE ATENCION</h3>
        <p></p>
      </div>
    </div>
    <div class="container">
      <!-- Example row of columns -->
       
          	 <div class="well">	 
          		 <div class="form-group">
          		 		<div class="row">
			              <div class="col-sm-2">
			                <label class="form-label">Fecha</label>
			              </div>
			              <div class="col-sm-4">
			            	 <input type="date" class="form-control input-sm" required name="txtfecha" min="" id="idfecha"  >
			            
			              </div>
			              <div class="col-sm-6">
			              		 <input class="btn btn-primary" type="button" onclick="grabar();" value="BUSCAR">			              			             					           
			              </div>
			             </div>
			             
			              <br>
			              
			             <div class="row">
			             <div class="col-sm-2">
			                <label class="form-label">Especialidad</label>
			              </div>
			              <div class="col-sm-4">
			              	<select class="form-control input-sm"  name="cboSexo"  id="idSexo">
			              			<option value="0">---Seleccione---</option>
			              			<option value="1">CONSULTA OFTALMOLOGICA</option>
			              			<option value="2">DEFECTOS REFRACTIVOS</option>	
			              			<option value="3">CIRUGIAS</option>			              	
			              	</select>
			              </div>
			              <div class="col-sm-2"></div>
			              <div class="col-sm-4"> </div>
			              
			             </div>
			              <br>
			              
			             <div class="row">
			                <table class="table table-bordered table-hover" id="jqueryDataTable">
					        <thead>
					          <tr class="success">
					            <th>Nombre Medico</th>
					            <th>Opciones</th>  
					          </tr>
					        </thead>
					        <tbody>
					          <tr>
					          	<td>Miguel</td>
					          	<td><input type="radio" name="rbdOpcion"/></td>                    	          	          	          		           	       
					          </tr> 
					        </tbody>
					      </table> 
			             </div>
			             
			             <br/>
			             
			          <div class="row">
			              <div class="col-sm-2">
			                <label class="form-label">Horario</label>
			              </div>
			              <div class="col-sm-4">
			            	<select class="form-control input-sm"  name="cboHorario"  id="idHorario">
			              			
			              			<option value="-1">No hay Horario disponible</option>
			              				              	
			              	</select>
			            
			              </div>
			              <div class="col-sm-6">         			             					           
			              </div>
			             </div>
			             
			             <br/>
			             
			              <div class="form-group">
				           <c:if test="${requestScope.mensaje!='1'}">
					          <div class="row">
					            <div class="col-md-6" align="center">
					              <input class="btn btn-primary" type="button" onclick="grabar();" value="Reservar">			              			             
					            </div>
					            <div class="col-md-6" align="center">
					              <input class="btn btn-primary" type="button" onclick="cancelar();" value="Cancelar">			              			             
					            </div>
					          </div>	
				          </c:if>	
			          </div>
			              
			     </div>
		 </div>
      <hr>
      <footer>
        <p>&copy; Developers 2013</p>
        <nav>
          <div class="container"></div>
        </nav>
      </footer>
    </div>
    <!-- /container -->
    
  </body>

</html>