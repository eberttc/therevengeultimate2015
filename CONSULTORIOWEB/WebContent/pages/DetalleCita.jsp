<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    
<%@ taglib uri="http://java.sun.com/jstl/core_rt" prefix="c" %>

<!doctype html>
<!-- Built with Divshot - http://www.divshot.com -->
<html>
  <head>
    <title>New Page</title>
   <!-- Bootstrap core CSS -->
     <link href="<%=request.getContextPath()%>/css/bootstrap.css" rel="stylesheet" media="screen"> 
 	<script src="<%=request.getContextPath()%>/js/jquery-1.10.2.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="<%=request.getContextPath()%>/js/bootstrap-3.0.0.js"></script>
  </head>
  <body>
    <div class="container">
        <div class="text-center">
        <h3><strong>Datos de la cita</strong></h3>
        </div>
      <form>
        
        <div class="form-group">
          <label for="txtNombre">Diagnostico</label>
          <input type="text" 
          class="form-control" id="txtNombre"  disabled="disabled">          
        </div>        
        <div class="form-group">
          <label for="txtNombre">Observaciones</label>
          <input type="text" 
          class="form-control" id="txtNro"  disabled="disabled">              
        </div>
        
        <div class="row">
          <div class="col-md-12" align="center">
          	 <input class="btn btn-primary"  type="button" onclick="window.close();" value="Salir">	
          </div>          
          </div>
        
      </form>
      
    </div>
  </body>
