package com.upc.condominio.modelo;

import java.io.Serializable;

public class Observacion implements Serializable {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	public int CodigoError ;
   
    public String MensajeError;

	public int getCodigoError() {
		return CodigoError;
	}

	public void setCodigoError(int codigoError) {
		CodigoError = codigoError;
	}

	public String getMensajeError() {
		return MensajeError;
	}

	public void setMensajeError(String mensajeError) {
		MensajeError = mensajeError;
	}
    
    
}
