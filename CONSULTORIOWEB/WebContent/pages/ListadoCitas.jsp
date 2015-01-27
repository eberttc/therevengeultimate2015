<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    
<%@ taglib uri="http://java.sun.com/jstl/core_rt" prefix="c" %>
<!DOCTYPE html>
<html lang="en">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Listado de citas</title>
  <!-- Bootstrap core CSS -->

 	<!-- Bootstrap core CSS -->
     <link href="<%=request.getContextPath()%>/css/bootstrap.css" rel="stylesheet" media="screen"> 
 	<script src="<%=request.getContextPath()%>/js/jquery-1.10.2.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="<%=request.getContextPath()%>/js/bootstrap-3.0.0.js"></script>
    
  
</head>

<script>
window.showModalDialog = function (url, arg, feature) {
    var opFeature = feature.split(";");
   var featuresArray = new Array()
    if (document.all) {
       for (var i = 0; i < opFeature.length - 1; i++) {
            var f = opFeature[i].split("=");
           featuresArray[f[0]] = f[1];
        }
   }
    else {

        for (var i = 0; i < opFeature.length - 1; i++) {
            var f = opFeature[i].split(":");
           featuresArray[f[0].toString().trim().toLowerCase()] = f[1].toString().trim();
        }
   }



   var h = "200px", w = "400px", l = "100px", t = "100px", r = "yes", c = "yes", s = "no";
   if (featuresArray["dialogheight"]) h = featuresArray["dialogheight"];
    if (featuresArray["dialogwidth"]) w = featuresArray["dialogwidth"];
   if (featuresArray["dialogleft"]) l = featuresArray["dialogleft"];
    if (featuresArray["dialogtop"]) t = featuresArray["dialogtop"];
    if (featuresArray["resizable"]) r = featuresArray["resizable"];
   if (featuresArray["center"]) c = featuresArray["center"];
  if (featuresArray["status"]) s = featuresArray["status"];
    var modelFeature = "height = " + h + ",width = " + w + ",left=" + l + ",top=" + t + ",model=yes,alwaysRaised=yes" + ",resizable= " + r + ",celter=" + c + ",status=" + s;

    var model = window.open(url, "", modelFeature, null);

   model.dialogArguments = arg;

}
function consultar(){
	
	window.showModalDialog("<%=request.getContextPath()%>/pages/DetalleCita.jsp",window,"dialogHeight:500px;dialogWidth:600px;center:yes;help:no;resizable:no;status:no");

	
	
}



</script>
	
  <body>
  
  <jsp:include page="/pages/header.jsp" />
  <form id="frmcitas">
  
   
			  
  <input type="hidden" id="hidopcion"  name="opcion">  
    <div class="jumbotron">
      <div class="container">
        <h3>Listado de citas</h3>
			
      </div>
    </div>
    <div class="container">
                  
      <br>
      <table class="table table-bordered table-hover" id="jqueryDataTable">
        <thead>
          <tr class="success">
            <th>Numero cita</th>
            <th>Fecha de Resrva</th>
            <th>Especialidad</th>
            <th>Medico</th>
            <th>Fecha de Atencion</th>
            <th>Estado</th>
            <th>Seleccionar</th>
                      
          </tr>
        </thead>
        <tbody>
         
          
          <tr>
          	<td>9999</td>
          	<td>19/07/2014</td>
          	<td>Cirugia</td>
          	<td>Miguel Merino</td>
          	<td>19/07/2014</td>
          	<td>Reservada</td>
          	<td><input type="checkbox" name="chksel"/></td>                    	          	          	          		           	       
          </tr>
        </tbody>
      </table>  
      
      <br/>
       <div class="form-group">
				           <c:if test="${requestScope.mensaje!='1'}">
					          <div class="row">
					            <div class="col-md-2" align="center">
					              <input class="btn btn-primary" type="button" id="opener" onclick="consultar();" value="Consultar">			              			             
					           </div>
					   <div class="col-md-10" align="center">
					     			              			             
				</div>
					            
		    </div>	
	    </c:if>	
			   </div> 
      <footer></footer>
    </div>
  
    </form>
  
  </body>
	
</html>