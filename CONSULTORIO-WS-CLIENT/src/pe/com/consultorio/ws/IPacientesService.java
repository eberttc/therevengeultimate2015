
package pe.com.consultorio.ws;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.4-b01
 * Generated source version: 2.2
 * 
 */
@WebService(name = "IPacientesService", targetNamespace = "http://tempuri.org/")
@XmlSeeAlso({
    ObjectFactory.class
})
public interface IPacientesService {


    /**
     * 
     * @param paciente
     * @return
     *     returns pe.com.consultorio.ws.Paciente
     * @throws IPacientesServiceCrearPacienteObservacionFaultFaultMessage
     */
    @WebMethod(action = "http://tempuri.org/IPacientesService/crearPaciente")
    @WebResult(name = "crearPacienteResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "crearPaciente", targetNamespace = "http://tempuri.org/", className = "pe.com.consultorio.ws.CrearPaciente")
    @ResponseWrapper(localName = "crearPacienteResponse", targetNamespace = "http://tempuri.org/", className = "pe.com.consultorio.ws.CrearPacienteResponse")
    public Paciente crearPaciente(
        @WebParam(name = "_paciente", targetNamespace = "http://tempuri.org/")
        Paciente paciente)
        throws IPacientesServiceCrearPacienteObservacionFaultFaultMessage
    ;

    /**
     * 
     * @param intIdPaciente
     * @return
     *     returns pe.com.consultorio.ws.Paciente
     */
    @WebMethod(action = "http://tempuri.org/IPacientesService/consultarPaciente")
    @WebResult(name = "consultarPacienteResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "consultarPaciente", targetNamespace = "http://tempuri.org/", className = "pe.com.consultorio.ws.ConsultarPaciente")
    @ResponseWrapper(localName = "consultarPacienteResponse", targetNamespace = "http://tempuri.org/", className = "pe.com.consultorio.ws.ConsultarPacienteResponse")
    public Paciente consultarPaciente(
        @WebParam(name = "intIdPaciente", targetNamespace = "http://tempuri.org/")
        Integer intIdPaciente);

    /**
     * 
     * @param paciente
     * @return
     *     returns pe.com.consultorio.ws.Paciente
     * @throws IPacientesServiceActualizarPacienteObservacionFaultFaultMessage
     */
    @WebMethod(action = "http://tempuri.org/IPacientesService/actualizarPaciente")
    @WebResult(name = "actualizarPacienteResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "actualizarPaciente", targetNamespace = "http://tempuri.org/", className = "pe.com.consultorio.ws.ActualizarPaciente")
    @ResponseWrapper(localName = "actualizarPacienteResponse", targetNamespace = "http://tempuri.org/", className = "pe.com.consultorio.ws.ActualizarPacienteResponse")
    public Paciente actualizarPaciente(
        @WebParam(name = "_paciente", targetNamespace = "http://tempuri.org/")
        Paciente paciente)
        throws IPacientesServiceActualizarPacienteObservacionFaultFaultMessage
    ;

    /**
     * 
     * @param intIdPaciente
     */
    @WebMethod(action = "http://tempuri.org/IPacientesService/eliminarPaciente")
    @RequestWrapper(localName = "eliminarPaciente", targetNamespace = "http://tempuri.org/", className = "pe.com.consultorio.ws.EliminarPaciente")
    @ResponseWrapper(localName = "eliminarPacienteResponse", targetNamespace = "http://tempuri.org/", className = "pe.com.consultorio.ws.EliminarPacienteResponse")
    public void eliminarPaciente(
        @WebParam(name = "intIdPaciente", targetNamespace = "http://tempuri.org/")
        Integer intIdPaciente);

    /**
     * 
     * @return
     *     returns pe.com.consultorio.ws.ArrayOfPaciente
     */
    @WebMethod(action = "http://tempuri.org/IPacientesService/listarPaciente")
    @WebResult(name = "listarPacienteResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "listarPaciente", targetNamespace = "http://tempuri.org/", className = "pe.com.consultorio.ws.ListarPaciente")
    @ResponseWrapper(localName = "listarPacienteResponse", targetNamespace = "http://tempuri.org/", className = "pe.com.consultorio.ws.ListarPacienteResponse")
    public ArrayOfPaciente listarPaciente();

}
