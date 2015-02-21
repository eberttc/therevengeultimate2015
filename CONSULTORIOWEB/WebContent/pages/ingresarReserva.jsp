<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    
<%@ taglib uri="http://java.sun.com/jstl/core_rt" prefix="c" %>
<!DOCTYPE html>
<html lang="en">
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
      <link href="<%=request.getContextPath()%>/css/style1.css" rel="stylesheet" media="screen">
      <script src="<%=request.getContextPath()%>/js/jquery-ui-11.js"></script>
    <style type="text/css">
      body {
        padding-bottom: 20px;
      }
    </style>
    
    <script language="javascript" >
   
  
    
    
    window.name="Reserva";
	
    function grabar(){
    	var fecha=new Date();
    	var f=document.forms[0];
    	var codigoMedico=document.frames[0].devuelveCodigo();
    	
    	
    	if(typeof codigoMedico == "undefined") {
    		bootbox.alert("No se ha seleccionado el medico");
    		return false;
    	}
    	
    	if(validar()){    		
			var url="<%=request.getContextPath()%>/ReservaCitaServlet?fecha="+fecha+"&codigoMed="+codigoMedico;			
			f.target="Reserva";
			f.accion.value="grabar";
			f.action=url;
			f.submit();

       	}

    }
    function validar(){
    	
    	
    	var f=document.forms[0];
    	
    	if(f.txtfecha.value==""){
    		bootbox.alert("Ingrese una fecha");
    		return false;
    	}
    	if(f.cboEspecialidad.value=="-1"){
    		bootbox.alert("Seleccione una especialidad");
    		return false;
    	}
    	if(f.cboHorario.value=="-1"){
    		bootbox.alert("Seleccione una Horario");
    		return false;
    	}
    	
    	
    	return true;
    		
    	
    }
	   function cancelar(){
	            
	        	var f=document.forms[0];
	        	        		
					var url="<%=request.getContextPath()%>/pages/principal.jsp";							
					f.action=url;
					f.submit();

	           	

	   }
		    
    	function listadoMedicos(){  
    		
    		
    			var f=document.forms[0];        	
    			var tipoEspecialidad=f.cboEspecialidad.value;       			    			    			
                document.frames["ifrmMedicos"].listado(tipoEspecialidad);    	      		    		
    	}
    </script>
    	

    	
<script type="text/javascript">
$(document).on('ready' , function(){
	var fecReserva="<c:out value='${beanReserva.fecReserva}'/>";	
	$('#input_date').datepicker({ setDate: fecReserva ==='' ? new Date() : fecReserva  , dateFormat: 'dd/mm/yy' });
});
</script>                             
      
         
  </head>
  
  <body onload="listadoMedicos();">
  <jsp:include page="../pages/header.jsp" />
   <c:set value="${requestScope.beanReserva}"  var="beanReserva" />
   
    <!-- Main jumbotron for a primary marketing message or call to action -->
    <div class="jumbotron">
      <div class="container" align="center">
        <h3>RESERVA TU CITA</h3>
        <p></p>
        				
      </div>
    </div>
    <div class="container">
      <!-- Example row of columns -->
       <form method="POST">
       <input type="hidden" name="accion">
       <input type="hidden" name="codMed" value="<c:out value='${beanReserva.idMedico}'/>">
          	 <div class="well">	 
          		 <div class="form-group">
          		 		<div class="row">
			              <div class="col-sm-2">
			                <label class="form-label">Fecha</label>
			              </div>
			              <div class="col-sm-4">
			            	 <input type="text" class="form-control" required name="txtfecha" id="input_date"  value="<c:out value='${beanReserva.fecReserva}'/>">
			           		 <span class="fa fa-calendar txt-danger form-control-feedback"></span>
			              </div>
			              <div class="col-sm-6">
			              		 <input class="btn btn-primary" type="button" onclick="listadoMedicos();" value="BUSCAR">			              			             					           
			              </div>
			             </div>
			             
			              <br>
			              
			             <div class="row">
			             <div class="col-sm-2">
			                <label class="form-label">Especialidad</label>
			              </div>
			              <div class="col-sm-4">
			              	
			              	
			              	<select class="form-control input-sm" name="cboEspecialidad" tabindex="1">
			              		<option value="-1">--Selecciones una Especialidad</option>
                     			 <c:forEach var='lstEspe' items='${requestScope.lstEspeList}'> <option value="<c:out value='${lstEspe.idEspecialidad}'/>"  
                      				  <c:if test='${lstEspe.idEspecialidad == beanReserva.idEspecialidad}'>selected</c:if>> 
                      					<c:out value='${lstEspe.descripcion}'/> </option> 
                      			</c:forEach> 
                      	    </select>
			              </div>
			              <div class="col-sm-2"></div>
			              <div class="col-sm-4"> </div>
			              
			             </div>
			              <br>
			              
			             <div class="row">
			                	<iframe src="<%=request.getContextPath()%>/pages/ListadoMedicosXespecialidad.jsp"
                                frameborder="0"  width="100%" height="50%" name="ifrmMedicos"></iframe> 
			             </div>
			             
			             <br/>
			             
			          <div class="row">
			              <div class="col-sm-2">
			                <label class="form-label">Horario</label>
			              </div>
			              <div class="col-sm-4">
			            	
			              	<select class="form-control input-sm" name="cboHorario" tabindex="1" id="idHorario" >
			              	<option value="-1">--Selecciones una Horario</option>
                     			 <c:forEach var='lstHora' items='${requestScope.lstHorarios}'> <option value="<c:out value='${lstHora.idHorario}'/>"  
                      				  <c:if test='${lstHora.idHorario == beanReserva.idHorario}'>selected</c:if>> 
                      					<c:out value='${lstHora.valHor}'/> </option> 
                      			</c:forEach> 
                      	    </select>
			            
			              </div>
			              <div class="col-sm-6">         			             					           
			              </div>
			             </div>
			             
			             <br/>
			             
			              <div class="form-group">
				           <c:if test="${requestScope.mensaje!='1'||requestScope.mensaje!='2'}">
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
			              <c:choose>
			          			 <c:when test="${requestScope.mensaje=='2'}">							     								     							     								     		  							     		 
							     		 <script type="text/javascript">
							     		 			var mensaje='Se Registro satisfactoriamente .Nro de reservaGenerada <c:out value="${beanReserva.idCita}"></c:out>';
							     					bootbox.alert(mensaje);  		     	        								     					    	
							     					
    									 </script>							     	 
							     </c:when>	
							      <c:when test="${requestScope.mensaje=='1'}">							     	 								     							     								     		  
							     		  <script type="text/javascript">
							     		 			var mensaje='Su Reservase esta procesando en breve le llegara una confirmacion a su correo';
							     					bootbox.alert(mensaje);   							     												     					
							     					
    									 </script> 							     	
							     </c:when>	
							      <c:when test="${requestScope.mensaje=='3'}">								     								      							       
								        <script type="text/javascript">
							     		 			var mensaje='<c:out value="${requestScope.obs}"></c:out>';							     		 				
							     					bootbox.alert(mensaje);  							     					
							     					
    									 </script> 								         						  
								  </c:when>										  				      							  			          										
			          		</c:choose>
			     </div>
		 </div>
      <hr>
      </form>
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