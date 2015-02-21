package com.upc.condominio.forms;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.HashMap;
import java.util.Map;

import org.apache.commons.lang3.RandomStringUtils;
import org.apache.commons.lang3.StringUtils;
import org.apache.commons.validator.routines.EmailValidator;

import pe.com.consultorio.ws.Paciente;

import com.upc.condominio.util.DateTimeUtil;
import com.upc.condominio.util.EyeSuiteParseException;


public class PacienteForm {
	
	public String getNombre() {
		return nombre;
	}



	public void setNombre(String nombre) {
		this.nombre = nombre;
	}



	public String getApellidoPaterno() {
		return apellidoPaterno;
	}



	public void setApellidoPaterno(String apellidoPaterno) {
		this.apellidoPaterno = apellidoPaterno;
	}



	public String getApellidoMaterno() {
		return apellidoMaterno;
	}



	public void setApellidoMaterno(String apellidoMaterno) {
		this.apellidoMaterno = apellidoMaterno;
	}



	public String getSexo() {
		return sexo;
	}



	public void setSexo(String sexo) {
		this.sexo = sexo;
	}



	public String getTipoDocumento() {
		return tipoDocumento;
	}



	public void setTipoDocumento(String tipoDocumento) {
		this.tipoDocumento = tipoDocumento;
	}



	public String getNumeroDocumento() {
		return numeroDocumento;
	}



	public void setNumeroDocumento(String numeroDocumento) {
		this.numeroDocumento = numeroDocumento;
	}



	public String getCorreo() {
		return correo;
	}



	public void setCorreo(String correo) {
		this.correo = correo;
	}



	public String getDireccion() {
		return direccion;
	}



	public void setDireccion(String direccion) {
		this.direccion = direccion;
	}



	public String getTelefono() {
		return telefono;
	}



	public void setTelefono(String telefono) {
		this.telefono = telefono;
	}



	public String getFechaNacimiento() {
		return fechaNacimiento;
	}



	public void setFechaNacimiento(String fechaNacimiento) {
		this.fechaNacimiento = fechaNacimiento;
	}



	public String getIdentificador() {
		return identificador;
	}



	public void setIdentificador(String identificador) {
		this.identificador = identificador;
	}

	private String nombre ; 
	private String apellidoPaterno ; 
	private String apellidoMaterno;
	private String sexo;
	private String tipoDocumento;
	private String numeroDocumento;
	private String correo;
	private String correVerifica;
	public String getCorreVerifica() {
		return correVerifica;
	}



	public void setCorreVerifica(String correVerifica) {
		this.correVerifica = correVerifica;
	}

	private String direccion;
	private String telefono;
	private String fechaNacimiento;
	private String identificador;
	
	
	private Map<String,String> errors;

	public Map<String, String> getErrors() {
		return errors;
	}
	
	public void addError(String code, String message){
		this.errors.put(code,message);
	}

	
	
	public Paciente parseForm(Map<String, String[]> parameters) throws EyeSuiteParseException {
		
		 this.nombre = parameters.get("_nombre")[0];
	     this.apellidoPaterno = parameters.get("_apellidoPaterno")[0];
	     this.apellidoMaterno = parameters.get("_apellidoMaterno")[0];
	     this.sexo = parameters.get("_sexo")[0];
	     this.tipoDocumento = parameters.get("_tipoDocumento")[0];
	     this.numeroDocumento = parameters.get("_numeroDocumento")[0];
	     this.correo = parameters.get("_correo")[0];
	     this.direccion = parameters.get("_direccion")[0];
	     this.telefono = parameters.get("_telefono")[0];
		 this.fechaNacimiento = parameters.get("_fechaNacimiento")[0];
		 this.identificador=parameters.get("_identificador")[0];
		 this.correVerifica=parameters.get("_correo_dup")[0];
		 
		 //validaciones
		 
		 if(!StringUtils.isAlpha(this.nombre)){
				errors.put("_nombre", "El nombre de usuario es invalido, solo se permiten letras");					
			}
			if(!StringUtils.isAlphaSpace(this.apellidoPaterno) ){
				errors.put("_apellidoPaterno", "Apellido paterno es invalido, solo se permiten letras");
			}
			if(!StringUtils.isAlphaSpace(this.apellidoMaterno)){
				errors.put("_apellidoMaterno", "Apellido materno invalido, solo se permiten letras");			
			}
			if(!StringUtils.isNumeric(this.numeroDocumento) ){
				errors.put("_numeroDocumento", "Numero de documento invalido, solo se permiten letras");			
			}		
			if(StringUtils.isBlank(this.direccion)) {
				errors.put("_direccion", "Direccion invalida");			
			}
			if(!StringUtils.isNumeric(this.telefono)){
				errors.put("_telefonno", "Telefono solo numeros");
			}
			if(StringUtils.isBlank(this.fechaNacimiento)){
				errors.put("_fechaNacimiento", "Fecha de Nacimiento invalida");
			}
				
			if(!EmailValidator.getInstance().isValid(correo) || !EmailValidator.getInstance().isValid(correVerifica) ){
				errors.put("_correo", "Correo invalido");
			}
						
			if(!this.correo.equals(correVerifica)){
				errors.put("_correo_fault", "Correos No coinciden");
			}
			
			if(!isValidForm()){
				throw new EyeSuiteParseException();
			}
			
			
			return populateObjeto();
		
		
	}
	
	
	
	public PacienteForm(){
		this.errors = new HashMap<String, String>();
		
		 this.nombre = StringUtils.EMPTY;
	     this.apellidoPaterno = StringUtils.EMPTY;
	     this.apellidoMaterno = StringUtils.EMPTY;
	     this.sexo = StringUtils.EMPTY;
	     this.tipoDocumento = StringUtils.EMPTY;
	     this.numeroDocumento = StringUtils.EMPTY;
	     this.correo = StringUtils.EMPTY;
	     this.direccion = StringUtils.EMPTY; 
	     this.telefono = StringUtils.EMPTY;
		 this.fechaNacimiento = StringUtils.EMPTY;
		 this.identificador=StringUtils.EMPTY;
		 
	
	}
	
	
	private boolean isValidForm(){
		return this.errors.isEmpty();		
	}
	
	public void populateForm(Paciente paciente){
		DateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
		 this.nombre = paciente.getNombres();
	     this.apellidoPaterno = paciente.getApePaterno();
	     this.apellidoMaterno = paciente.getApeMaterno();
	     this.sexo = paciente.getSexo();
	     this.tipoDocumento = String.valueOf(paciente.getIdTipoDoc().intValue());
	     this.numeroDocumento = paciente.getNroDocumento();
	     this.correo = paciente.getCorreo();
	     this.direccion = paciente.getDireccion(); 
	     this.telefono = paciente.getTelefono();
		 this.fechaNacimiento = sdf.format(paciente.getFecNac().toGregorianCalendar().getTime()).toString();
		 this.identificador=String.valueOf(paciente.getIdPaciente());
		 
	}
	
	private Paciente populateObjeto(){
		Paciente objeto = new Paciente();
		objeto.setApeMaterno(this.apellidoMaterno);
		objeto.setApePaterno(this.apellidoPaterno);
		objeto.setCorreo(this.correo);
		objeto.setDireccion(this.direccion);
		objeto.setFecNac(DateTimeUtil.convertStringDateToXmlGregorianCalendar(this.fechaNacimiento, "dd/MM/yyyy",Boolean.FALSE));
		if(StringUtils.isNotBlank(this.identificador))
		objeto.setIdPaciente(Integer.parseInt(this.identificador));
		objeto.setIdTipoDoc(Integer.parseInt(this.tipoDocumento));
		objeto.setNombres(this.nombre);
		objeto.setNroDocumento(this.numeroDocumento);
		objeto.setSexo(this.sexo);
		objeto.setTelefono(this.telefono);
		objeto.setPassword(RandomStringUtils.randomAscii(10));
		return objeto;
	}
	
}
