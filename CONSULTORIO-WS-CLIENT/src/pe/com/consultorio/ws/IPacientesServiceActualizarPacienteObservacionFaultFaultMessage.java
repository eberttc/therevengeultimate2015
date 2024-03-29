
package pe.com.consultorio.ws;

import javax.xml.ws.WebFault;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.4-b01
 * Generated source version: 2.2
 * 
 */
@WebFault(name = "Observacion", targetNamespace = "http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio")
public class IPacientesServiceActualizarPacienteObservacionFaultFaultMessage
    extends Exception
{

    /**
     * Java type that goes as soapenv:Fault detail element.
     * 
     */
    private Observacion faultInfo;

    /**
     * 
     * @param message
     * @param faultInfo
     */
    public IPacientesServiceActualizarPacienteObservacionFaultFaultMessage(String message, Observacion faultInfo) {
        super(message);
        this.faultInfo = faultInfo;
    }

    /**
     * 
     * @param message
     * @param faultInfo
     * @param cause
     */
    public IPacientesServiceActualizarPacienteObservacionFaultFaultMessage(String message, Observacion faultInfo, Throwable cause) {
        super(message, cause);
        this.faultInfo = faultInfo;
    }

    /**
     * 
     * @return
     *     returns fault bean: pe.com.consultorio.ws.Observacion
     */
    public Observacion getFaultInfo() {
        return faultInfo;
    }

}
