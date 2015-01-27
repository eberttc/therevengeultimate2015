<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    
<%@ taglib uri="http://java.sun.com/jstl/core_rt" prefix="c" %>
<!DOCTYPE html>
<html lang="en">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Registrar Atencion</title>

 	<!-- Bootstrap core CSS -->
 	
     <link href="<%=request.getContextPath()%>/css/bootstrap.css" rel="stylesheet" media="screen">
 	 <script src="<%=request.getContextPath()%>/js/jquery-1.10.2.js"></script> 	 
 	 <script src="<%=request.getContextPath()%>/js/bootbox.min.js"></script> 	  	 	    
     <script src="<%=request.getContextPath()%>/js/bootstrap-3.0.0.js"></script>

  
  
    <script>
    	

    	
		window.name="medicos";
        function grabar(){
        
        	    bootbox.alert("Registro Exitoso");
        		  	<%-- 	
        		  		 var f=document.forms[0];        	        	
        					var url="<%=request.getContextPath()%>/pages/ListadoMedicos.jsp";							
        					f.action=url;
        					f.submit();
        	
        		 --%>
        	   

           	

        }
        
        
        function cancelar(){
            
        	var f=document.forms[0];
        	        		
				var url="<%=request.getContextPath()%>/pages/ListadoMedicos.jsp";							
				f.action=url;
				f.submit();

           	

        }
        

       
      
      
         
    </script>
    <script type="text/javascript">
    $(document).ready(function() {
			
    	  $('#hidepage').hide();
    	  $('#example').tooltip();

    	 
          
   });
    </script>
   
</head>

<body>
	<jsp:include page="/pages/header.jsp" />
	 <c:set value="${requestScope.beanJunta}"  var="beanJunta" />
    <!-- Main jumbotron for a primary marketing message or call to action -->
      <div class="container">
      
        <div class="text-center">
        <h3><strong >Registro de Atencion</strong></h3> 
      	        
        </div>
        <br>
        <div class="row">
          <div class="col-sm-3"></div>
           <div class="col-sm-6"> 
        	 <div class="well">
        		<form class="form-horizontal">
         		 <input type="hidden" name="hidDirectivos">	  
         		  <div id="hidepage" style="position: absolute;left:320px;top:290px;width: 150;height: 20">
						 <img  src="<%=request.getContextPath()%>/css/progress_bar.gif" >
					</div>          		 				
		         	 <div class="form-group">	
		         		          			          	 
		          		 <div class="col-sm-12"> 
		          				          		
			          		<c:choose>
			          			 <c:when test="${requestScope.mensaje=='1'}">
							     	 <div class="alert  alert-success">							     	
							     		 Registro satisfactoriamente
							     	 </div>
							     </c:when>
							      <c:when test="${not empty mensaje}">
								      <div class="alert alert-dismissable alert-danger">
								       <button type="button" class="close" data-dismiss="alert">×</button>
								       ${requestScope.mensaje}</div>          						  
								  </c:when>
							   	 <c:otherwise>
							     </c:otherwise>
			          			
								
			          		</c:choose>
		          		
		          		 </div>
		          		 
		          	</div>
           
          		 
          		 
          		 <div class="form-group">
          		 		<div class="row">
			              <div class="col-sm-2">
			                <label class="form-label">Nro de Cita</label>
			              </div>
			              <div class="col-sm-4">
			            	 <input type="text" class="form-control input-sm" required name="txtcita" min="" id="idcita" value="" >
			            
			              </div>
			              
			               <div class="col-sm-6">
			              		 <input class="btn btn-primary" type="button"  value="BUSCAR">			              			             					           
			              
			              </div>
			             
			             </div>
			             
			              <br>
			              
			             <div class="row">
				              <div class="col-sm-2">
				                <label class="form-label">Paciente</label>
				              </div>
				              <div class="col-sm-8">
				            	 <input type="text" class="form-control input-sm" required name="txtpaciente" id="idpaciente" value="" >
				            
				              </div>
				              <div class="col-sm-2"></div>
			              </div>
			             
			             <br/>
			             
			             <div class="row">
			              <div class="col-sm-2">
			                <label class="form-label">Especialidad</label>
			              </div>
			              <div class="col-sm-8">
			            	 <input type="text" class="form-control input-sm" required name="txtespe" id="idespe" value="" >
				            
			              </div>
			              <div class="col-sm-2">
			                <label class="form-label"></label>
			              </div>
			             </div>
			             
			             <br/>
			             
			             
			             <div class="row">
			              <div class="col-sm-2">
			                <label class="form-label">Medico</label>
			              </div>
			              <div class="col-sm-8">
			            	 <input type="text" class="form-control input-sm" required name="txtxmed" id="idmed" value="" >
				            
			              </div>
			              <div class="col-sm-2">
			                <label class="form-label"></label>
			              </div>
			             </div>
			              <br/>
			             <div class="row">
			              <div class="col-sm-2">
			                <label class="form-label">fecha de Reserva</label>
			              </div>
			              <div class="col-sm-4">
			            	 <input type="text" class="form-control input-sm" required name="txtfecha" id="idfecha" value="" >
				            
			              </div>
			              <div class="col-sm-6">
			                <label class="form-label"></label>
			              </div>
			             </div>
			             
			             <br/>
			             
			             <div class="row">
			              <div class="col-sm-2">
			                <label class="form-label">fecha de Atencion</label>
			              </div>
			              <div class="col-sm-4">
			            	 <input type="text" class="form-control input-sm" required name="txtAtecnion" id="idAtencion" value="" >
				            
			              </div>
			              <div class="col-sm-6">
			                <label class="form-label"></label>
			              </div>
			             </div>
			             
			              <br/>
			             
			             <div class="row">
			              <div class="col-sm-2">
			                <label class="form-label">Diagnostico</label>
			              </div>
			              <div class="col-sm-8">
			            	<textarea class="form-control input-sm"  required placeholder="Diagnostico" rows="3" name="txtDiagnostico"></textarea>
				            
			              </div>
			              <div class="col-sm-2">
			                <label class="form-label"></label>
			              </div>
			             </div>
			             
			             <br/>
			             
			             <div class="row">
			              <div class="col-sm-2">
			                <label class="form-label">Observaciones</label>
			              </div>
			              <div class="col-sm-8">
			            	 <textarea class="form-control input-sm"  required placeholder="Observaciones" rows="3" name="txtobs"></textarea>
				            
			              </div>
			              <div class="col-sm-2">
			                <label class="form-label"></label>
			              </div>
			             </div>
			             <br/>
			             
			              <div class="form-group">
				           <c:if test="${requestScope.mensaje!='1'}">
					          <div class="row">
					            <div class="col-md-6" align="center">
					              <input class="btn btn-primary" type="button" onclick="grabar();" value="grabar">			              			             
					            </div>
					            <div class="col-md-6" align="center">
					              <input class="btn btn-primary" type="button" onclick="cancelar();" value="Cancelar">			              			             
					            </div>
					          </div>	
				          </c:if>	
			          </div>
			              
			     </div>
			    
			            
			          	          		 			          		           		        
              </form>
         	</div>
         </div>
          <div class="col-sm-3"></div>
       </div>     
       
     </div>
</body>
</html>
