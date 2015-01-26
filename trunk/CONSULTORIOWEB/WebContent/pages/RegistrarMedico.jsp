<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    
<%@ taglib uri="http://java.sun.com/jstl/core_rt" prefix="c" %>
<!DOCTYPE html>
<html lang="en">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Registrar Medico</title>

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
        <h3><strong >Registro de Medico</strong></h3> 
      	        
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
			                <label class="form-label">Nombre</label>
			              </div>
			              <div class="col-sm-4">
			            	 <input type="text" class="form-control input-sm" required name="txtNombre" min="" id="idNombre" value="" >
			            
			              </div>
			              <div class="col-sm-2">
			                <label class="form-label">Apellido Paterno</label>
			              </div>
			              <div class="col-sm-4">
			              	<input type="text" class="form-control input-sm" required name="txtApePat" id="idApePat" value="" >
			              </div>
			             </div>
			             
			              <br>
			              
			             <div class="row">
			              <div class="col-sm-2">
			                <label class="form-label">Apellido Materno</label>
			              </div>
			              <div class="col-sm-4">
			            	 <input type="text" class="form-control input-sm" required name="txtApeMat" id="idApeMat" value="" >
			            
			              </div>
			              <div class="col-sm-2">
			                <label class="form-label">Sexo</label>
			              </div>
			              <div class="col-sm-4">
			              	<select class="form-control input-sm"  name="cboSexo"  id="idSexo">
			              			<option value="0">---Seleccione---</option>
			              			<option value="M">Masculino</option>
			              			<option value="F">Femenino</option>			              	
			              	</select>
			              </div>
			             </div>
			             
			             <br/>
			             
			             <div class="row">
			              <div class="col-sm-2">
			                <label class="form-label">Tipo Documento</label>
			              </div>
			              <div class="col-sm-4">
			            	<select class="form-control input-sm"  name="cboTipoDoc"  id="idTipoDoc">
			              			<option value="0">---Seleccione---</option>
			              			<option value="DNI">DNI</option>
			              			<option value="LE">LIBRETA ELECTORAL</option>
			              			<option value="C.E">CARNET DE EXTRANJERIA</option>			              	
			              	</select>
			              </div>
			              <div class="col-sm-2">
			                <label class="form-label">Nro Documento</label>
			              </div>
			              <div class="col-sm-4">
			              	 <input type="text" class="form-control input-sm" required name="txtNroDoc" id="idNroDoc" value="" >
			            
			              </div>
			             </div>
			             
			             <br/>
			             
			             <div class="row">
				              <div class="col-sm-2">
				                <label class="form-label">CMP</label>
				              </div>
				              <div class="col-sm-4">
				            	 <input type="text" class="form-control input-sm" required name="txtCMP" id="idCMP" >
				            
				              </div>
				              <div class="col-sm-2">
				                <label class="form-label">Especialidad</label>
				              </div>
				              <div class="col-sm-4">
				              	<select class="form-control input-sm"  name="cboEspec"  id="idEspec">
				              			<option value="0">---Seleccione---</option>
				              			<option value="1">1</option>
				              			<option value="2">2</option>
				              			<option value="3">3</option>			              	
				              	</select>
				              </div>
			             </div>
			             
			              <br>
			              
			               <div class="row">
				              <div class="col-sm-2">
				                <label class="form-label">Direccion</label>
				              </div>
				              <div class="col-sm-10">
				            	 <input type="text" class="form-control input-sm" required name="txtDireccion" id="idDireccion" >
				            
				              </div>
				             
			             </div>
			             
			              <br>
			              
			             <div class="row">
				              <div class="col-sm-2">
				                <label class="form-label">Telefono</label>
				              </div>
				              <div class="col-sm-4">
				            	 <input type="text" class="form-control input-sm" required name="txtTelefono" id="idTelefono" >
				            
				              </div>
				              <div class="col-sm-6"></div>
			             </div>
			             
			              <br>
			              
			              <div class="row">
				              <div class="col-sm-2">
				                <label class="form-label">Correo</label>
				              </div>
				              <div class="col-sm-4">
				            	 <input type="text" class="form-control input-sm" required name="txtCorreo1" id="idCorreo1" >
				            
				              </div>
				               <div class="col-sm-2">
				                <label class="form-label">Confirmar Correo</label>
				              </div>
				              <div class="col-sm-4">
				            	 <input type="text" class="form-control input-sm" required name="txtCorreo2" id="idCorreo2" >
				            
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
