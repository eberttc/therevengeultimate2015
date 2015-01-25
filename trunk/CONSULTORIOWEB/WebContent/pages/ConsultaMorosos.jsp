<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    
<%@ taglib uri="http://java.sun.com/jstl/core_rt" prefix="c" %>
<!DOCTYPE html>
<html lang="en">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
  <!-- Bootstrap core CSS -->
  
 
 	<!-- Bootstrap core CSS -->
     <link href="<%=request.getContextPath()%>/css/bootstrap.css" rel="stylesheet" media="screen">
 
 	<script src="<%=request.getContextPath()%>/js/jquery-1.10.2.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="<%=request.getContextPath()%>/js/bootstrap-3.0.0.js"></script>
     
  
</head>



<script type="text/javascript">

$(document).ready(function() {

	
	 
	 $("#chktodos").click(function(){
		 
		 verificaCheck();
     		
	 });
	 
	 var verificaCheck=function(){
		 
		 
		 if($("#chktodos").is(':checked')){
			
			 $("#txtcodigo").val("");
			 $("#hidopcion").val("1");			 
			 $("#txtcodigo").attr("disabled", true);
			 
		 }
     	else{
			$("#hidopcion").val("2");			 
     		$("#txtcodigo").attr("disabled", false);
     	}
		 
	 };
	
	 function detalleResidente(id){
		 
		 if(id==""){
			 return;
			 
		 }
	 		var fecha=new Date();
    		window.showModalDialog("<%=request.getContextPath()%>/RegistrarJuntaServlet?opcion=4&codigo="+id+"&fecha="+fecha,window,"dialogHeight:500px;"+
            "dialogWidth:600px;center:yes;help:no;resizable:no;status:no");    		    		
   
		 
	 }
	
	function detalleVivienda(id){
		if(id==""){
			 return;
			 
		 }
 		var fecha=new Date();
		window.showModalDialog("<%=request.getContextPath()%>/RegistrarJuntaServlet?opcion=5&codigo="+id+"&fecha="+fecha,window,"dialogHeight:500px;"+
        "dialogWidth:600px;center:yes;help:no;resizable:no;status:no");    		    		

		
	}
	
	$('#myLinkR').click(function(){
		
		var id=$('#myLinkR').attr("enlace");
		
		detalleResidente(id);
		
		
	});
	
	$('#myLinkV').click(function(){
		
		var id=$('#myLinkV').attr("enlace");
		
		detalleVivienda(id);
		
		
	});
	
	 verificaCheck();

} );

</script>
	
  <body>
  
  <jsp:include page="/pages/header.jsp" />
  <form id="frmMorosos" action="${pageContext.request.contextPath}/CuotasServlet">
  <input type="hidden" id="hidopcion"  name="opcion">  
    <div class="jumbotron">
      <div class="container">
        <h3>Cuotas Vencidas</h3>

      </div>
    </div>
    <div class="container">
      <hr>
      <div class="row">
        <div class="col-md-3" >
          <h4>Codigo de Vivienda</h4>
        </div>
        <div class="col-md-3">
          <input type="text" id="txtcodigo" name="codigo" class="form-control">
        </div>
        <div class="col-md-3">
          <div class="checkbox">
            <label>
              <input type="checkbox"  id="chktodos" name="todos">Todos</label>
          </div>
        </div>
        <div class="col-md-3">
             <input type="submit" class="btn btn-primary" value="Buscar" />
        </div>
      </div>
      <hr>
      <table class="table table-bordered table-hover" id="jqueryDataTable">
        <thead>
          <tr class="success">
            <th>Id Cuota</th>
            <th>Nombre Residente</th>           
            <th>Importe a pagar</th>
             <th>Fecha Vencimiento</th>
            <th>Id Vivienda</th>
            
          
          </tr>
        </thead>
        <tbody>
          <c:forEach var="bean" items="${requestScope.lista}" varStatus="i">
          <tr>
          	<td >${bean.n_IdCuot}</td>
          	<td><a id="myLinkR" href="#" enlace="${bean.o_Vivienda.residente.idResidente}">${bean.o_Vivienda.residente.nombreResidente}</a></td>
          	<td>${bean.n_ImpPag}</td>
          	<td>${bean.d_FecVen}</td>
          	<td><a id="myLinkV" href="#" enlace="${bean.o_Vivienda.n_IdVivi}" >${bean.o_Vivienda.n_IdVivi}</a></td>          	
          	          	
          	          		           	        
          </tr>
          </c:forEach>
        </tbody>
      </table>  
      <footer></footer>
    </div>
  
    </form>
  </body>
	
</html>