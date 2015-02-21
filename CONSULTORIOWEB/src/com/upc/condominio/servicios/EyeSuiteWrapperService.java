package com.upc.condominio.servicios;

import pe.com.consultorio.ws.IPacientesService;
import pe.com.consultorio.ws.ITiposDocService;
import pe.com.consultorio.ws.PacientesService;
import pe.com.consultorio.ws.TiposDocService;

public class EyeSuiteWrapperService {
	
	private static EyeSuiteWrapperService INSTANCE = null;
	private IPacientesService pacientesService;
	private ITiposDocService tiposDocService;
	protected EyeSuiteWrapperService() {
	     	this.pacientesService =  new PacientesService().getBasicHttpBindingIPacientesService();
	     	this.tiposDocService = new TiposDocService().getBasicHttpBindingITiposDocService();
	   }
	
	
	 public static EyeSuiteWrapperService getInstance() {
	      if(INSTANCE == null) {
	    	  INSTANCE = new EyeSuiteWrapperService();
	      }
	      return INSTANCE;
	   }
	 
	
	 public IPacientesService obtenerServicioPaciente(){
		 return this.pacientesService;
	 }
	 
	 public ITiposDocService obtenerServicioTipoDocumento(){
		 return this.tiposDocService;
	 }
}
