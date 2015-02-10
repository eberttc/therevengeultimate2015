package com.upc.condominio.modelo;

import java.io.Serializable;

public class Medico implements Serializable {

	
	        /**
	 * 
	 */
	private static final long serialVersionUID = 1L;

			public int IdMedico ;
	        
	        public String Nombre ;
	        
	        public String Ape_Paterno ;
	        
	        public String Ape_Materno ;
	        
	        public String Sexo ;
	        
			public String Telefono ;
	        	       
	        public int Tipo_Documento ;
	        
	        public String Nro_Documento ;
	        	        
	        public int Cmp ;
	        
	        public int Especialidad ;
	        
	        public String Direccion ;
	        
	        public String Correo ;
	        
	        public String Password;
	        
			public String getPassword() {
				return Password;
			}

			public void setPassword(String password) {
				Password = password;
			}

			public int getIdMedico() {
				return IdMedico;
			}

			public void setIdMedico(int idMedico) {
				IdMedico = idMedico;
			}

			public String getNombre() {
				return Nombre;
			}

			public void setNombre(String nombre) {
				Nombre = nombre;
			}

			public String getApe_Paterno() {
				return Ape_Paterno;
			}

			public void setApe_Paterno(String ape_Paterno) {
				Ape_Paterno = ape_Paterno;
			}

			public String getApe_Materno() {
				return Ape_Materno;
			}

			public void setApe_Materno(String ape_Materno) {
				Ape_Materno = ape_Materno;
			}

			public String getSexo() {
				return Sexo;
			}

			public void setSexo(String sexo) {
				Sexo = sexo;
			}

			public int getTipo_Documento() {
				return Tipo_Documento;
			}

			public void setTipo_Documento(int tipo_Documento) {
				Tipo_Documento = tipo_Documento;
			}

			public String getNro_Documento() {
				return Nro_Documento;
			}

			public void setNro_Documento(String nro_Documento) {
				Nro_Documento = nro_Documento;
			}

			public int getCmp() {
				return Cmp;
			}

			public void setCmp(int cmp) {
				Cmp = cmp;
			}

			public int getEspecialidad() {
				return Especialidad;
			}

			public void setEspecialidad(int especialidad) {
				Especialidad = especialidad;
			}

			public String getDireccion() {
				return Direccion;
			}

			public void setDireccion(String direccion) {
				Direccion = direccion;
			}

			public String getCorreo() {
				return Correo;
			}

			public void setCorreo(String correo) {
				Correo = correo;
			}

			 public String getTelefono() {
					return Telefono;
				}

				public void setTelefono(String telefono) {
					this.Telefono = telefono;
				}
			
	        
	        
	        
}
