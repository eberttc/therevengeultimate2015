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
        	var fecha=new Date();
        	var f=document.forms[0];
        	
        	if(validar()){
        		$('#hidepage').show();
				var url="<%=request.getContextPath()%>/MedicoServlet?fecha="+fecha;				
				f.target="medicos";
				f.accion.value="grabar";
				f.action=url;
				f.submit();

           	}

        }
        
        function validar(){
        	
        	
        	var f=document.forms[0];
        	
        	expr = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    	    if ( !expr.test(f.txtCorreo1.value) ){
    	    	bootbox.alert("formato de email invalido");    	    	
        		return false;
    	    }
        	if(f.txtCorreo1.value!=f.txtCorreo2.value){
        		bootbox.alert("Los correos no coinciden");
        		return false;
        	}
        	
        	
        	return true;
        		
        	
        }
        function cancelar(){
            
        	var f=document.forms[0];
        	        		
        		var url="<%=request.getContextPath()%>/MedicoServlet";						
				f.action=url;
				f.accion.value="listar";
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
	 <c:set value="${requestScope.beanMedico}"  var="beanMedico" />
	 
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
        		<form class="form-horizontal" method="POST">
         		  <input type="hidden" name="id" value='<c:out value="${beanMedico.idMedico}"></c:out>'>	  
         		  <input type="hidden" name="accion"/>
         		  <div id="hidepage" style="position: absolute;left:320px;top:290px;width: 150;height: 20">
						 <img  src="<%=request.getContextPath()%>/css/progress_bar.gif" >
					</div>          		 				
		         	 <div class="form-group">	
		         		          			          	 
		          		 <div class="col-sm-12"> 
		          				          		
			          		<c:choose>
			          			 <c:when test="${requestScope.mensaje=='1'}">
							     	 <div class="alert alert-dismissable alert-success">	
							     		 <button type="button" class="close" data-dismiss="alert">×</button>						     	
							     		 Se Registro satisfactoriamente
							     	 </div>
							     </c:when>	
							      <c:when test="${requestScope.mensaje=='3'}">
								      <div class="alert alert-dismissable alert-danger">
								       <button type="button" class="close" data-dismiss="alert">×</button>
								       ${requestScope.obs}</div>          						  
								  </c:when>						      							  			          			
								
			          		</c:choose>
		          		
		          		 </div>
		          		 
		          	</div>
           
          		 
          		 
          		 <div class="form-group">
          		 		<div class="row">
			              <div class="col-sm-2">
			                <label class="form-label">Nombre</label>
			              </div>
			              <div class="col-sm-4">
			            	 <input type="text" class="form-control input-sm" required name="txtNombre" min="" id="idNombre" value="<c:out value='${beanMedico.nombre}'/>"/>
			            
			              </div>
			              <div class="col-sm-2">
			                <label class="form-label">Apellido Paterno</label>
			              </div>
			              <div class="col-sm-4">
			              	<input type="text" class="form-control input-sm" required name="txtApePat" id="idApePat" value="<c:out value='${beanMedico.ape_Paterno}'/>"/>
			              </div>
			             </div>
			             
			              <br>
			              
			             <div class="row">
			              <div class="col-sm-2">
			                <label class="form-label">Apellido Materno</label>
			              </div>
			              <div class="col-sm-4">
			            	 <input type="text" class="form-control input-sm" required name="txtApeMat" id="idApeMat" value="<c:out value='${beanMedico.ape_Materno}'/>"/>
			            
			              </div>
			              <div class="col-sm-2">
			                <label class="form-label">Sexo</label>
			              </div>
			              <div class="col-sm-4">
			              	<select class="form-control input-sm"  name="cboSexo"  id="idSexo">
			              			<option value="0" >---Seleccione---</option>
			              			<option value="M" <c:if test="${beanMedico.sexo=='M'}">selected</c:if>>Masculino</option>
			              			<option value="F" <c:if test="${beanMedico.sexo=='F'}">selected</c:if>>Femenino</option>			              	
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
			              			<option value="1" <c:if test="${beanMedico.tipo_Documento==1}">selected</c:if>>DNI</option>
			              			<option value="2" <c:if test="${beanMedico.tipo_Documento==2}">selected</c:if>>LIBRETA ELECTORAL</option>
			              			<option value="3" <c:if test="${beanMedico.tipo_Documento==3}">selected</c:if>>CARNET DE EXTRANJERIA</option>			              	
			              	</select>
			              </div>
			              <div class="col-sm-2">
			                <label class="form-label">Nro Documento</label>
			              </div>
			              <div class="col-sm-4">
			              	 <input type="text" class="form-control input-sm" required name="txtNroDoc" id="idNroDoc" value="<c:out value='${beanMedico.nro_Documento}'/>"/>
			            
			              </div>
			             </div>
			             
			             <br/>
			             
			             <div class="row">
				              <div class="col-sm-2">
				                <label class="form-label">CMP</label>
				              </div>
				              <div class="col-sm-4">
				            	 <input type="text" class="form-control input-sm" required name="txtCMP" id="idCMP" value="<c:out value='${beanMedico.cmp}'/>"/>
				            
				              </div>
				              <div class="col-sm-2">
				                <label class="form-label">Especialidad</label>
				              </div>
				              <div class="col-sm-4">
				              	<select class="form-control input-sm"  name="cboEspec"  id="idEspec">
				              			<option value="0" >seleccione---</option>
				              			<option value="1" <c:if test="${beanMedico.especialidad==1}">selected</c:if>>1</option>
				              			<option value="2" <c:if test="${beanMedico.especialidad==2}">selected</c:if>>2</option>
				              			<option value="3" <c:if test="${beanMedico.especialidad==3}">selected</c:if>>3</option>			              	
				              	</select>
				              </div>
			             </div>
			             
			              <br>
			              
			               <div class="row">
				              <div class="col-sm-2">
				                <label class="form-label">Direccion</label>
				              </div>
				              <div class="col-sm-10">
				            	 <input type="text" class="form-control input-sm" required name="txtDireccion" id="idDireccion" value="<c:out value='${beanMedico.direccion}'/>"/>
				            
				              </div>
				             
			             </div>
			             
			              <br>
			              
			             <div class="row">
				              <div class="col-sm-2">
				                <label class="form-label">Telefono</label>
				              </div>
				              <div class="col-sm-4">
				            	 <input type="text" class="form-control input-sm" required name="txtTelefono" id="idTelefono" value="<c:out value='${beanMedico.telefono}'/>"/>
				            
				              </div>
				              <div class="col-sm-6"></div>
			             </div>
			             
			              <br>
			              
			              <div class="row">
				              <div class="col-sm-2">
				                <label class="form-label">Correo</label>
				              </div>
				              <div class="col-sm-4">
				            	 <input type="text" class="form-control input-sm" required name="txtCorreo1" id="idCorreo1" value="<c:out value='${beanMedico.correo}'/>"/>
				            
				              </div>
				               <div class="col-sm-2">
				                <label class="form-label">Confirmar Correo</label>
				              </div>
				              <div class="col-sm-4">
				            	 <input type="text" class="form-control input-sm" required name="txtCorreo2" id="idCorreo2" />
				            
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