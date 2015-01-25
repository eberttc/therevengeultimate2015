<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    
<%@ taglib uri="http://java.sun.com/jstl/core_rt" prefix="c" %>

<!doctype html>
<!-- Built with Divshot - http://www.divshot.com -->
<html>
  <head>
    <title>New Page</title>
    <meta name="viewport" content="width=device-width">
    <link rel="stylesheet" href="https://netdna.bootstrapcdn.com/bootswatch/3.0.0/cosmo/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.0.3/jquery.min.js" type="text/javascript"></script>
    <script src="https://netdna.bootstrapcdn.com/bootstrap/3.0.1/js/bootstrap.min.js" type="text/javascript"></script>
  </head>
  <body>
    <div class="container">
        <div class="text-center">
        <h3><strong>Datos del Residente</strong></h3>
        </div>
      <form>
        
        <div class="form-group">
          <label for="txtNombre">Nombre</label>
          <input type="text" 
          class="form-control" id="txtNombre" value="${resi.nombreResidente}" disabled="disabled">          
        </div>        
        <div class="form-group">
          <label for="txtNombre">Nro Documento</label>
          <input type="text" 
          class="form-control" id="txtNro" value="${resi.numeroDocumento}"  disabled="disabled">              
        </div>
        <div class="form-group">
          <label for="txtNombre">Fecha Nacimiento</label>
          <input type="text" 
          class="form-control" id="txtNombre" value="${resi.fechaNacimiento}"  disabled="disabled">              
        </div>
        <div class="form-group">
          <label for="txtNombre">Correo</label>
          <input type="text" 
          class="form-control" id="txtNombre" value="${resi.correo}"  disabled="disabled">              
        </div>
        <div class="row">
          <div class="col-md-12" align="center">
          	 <input class="btn btn-primary"  type="button" onclick="window.close();" value="Cerrar">	
          </div>          
          </div>
        
      </form>
      
    </div>
  </body>
