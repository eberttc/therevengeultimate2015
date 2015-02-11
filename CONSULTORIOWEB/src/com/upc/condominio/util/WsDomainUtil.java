package com.upc.condominio.util;

import com.upc.consultorio.ws.proxy.ObjectFactory;
import com.upc.consultorio.ws.proxy.Paciente;

public class WsDomainUtil {

	
	public static final Paciente toPaciente(String nombre , String apellidoPaterno, String apellidoMaterno,
												String sexo ,  String tipoDocumento ,  String numeroDocumento, String correo,
												String direccion, String telefono, String fechaNacimiento , String identificador ){
		ObjectFactory objectFactory = new ObjectFactory();
	    Paciente paciente = objectFactory.createPaciente();
	    paciente.setNombres(objectFactory.createString(nombre));
	    paciente.setApeMaterno(objectFactory.createString(apellidoPaterno));
	    paciente.setApePaterno(objectFactory.createString(apellidoMaterno));
	    paciente.setSexo(objectFactory.createString(nombre));
	    paciente.setIdTipoDoc(Integer.parseInt(tipoDocumento));
	    paciente.setNroDocumento(objectFactory.createString(numeroDocumento));
	    paciente.setCorreo(objectFactory.createString(correo));
	    paciente.setDireccion(objectFactory.createString(direccion));
	    paciente.setTelefono(objectFactory.createString(telefono));	 	    
	    paciente.setFecNac(DateTimeUtil.convertStringDateToXmlGregorianCalendar(fechaNacimiento, EyeSuiteConstants.DATE_FORMAT, Boolean.TRUE));
	    if(!identificador.equals(""))
	    paciente.setIdPaciente(Integer.parseInt(identificador));
	    return paciente;
	}
}
