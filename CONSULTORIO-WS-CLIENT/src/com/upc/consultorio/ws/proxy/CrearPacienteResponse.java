
package com.upc.consultorio.ws.proxy;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for anonymous complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="crearPacienteResult" type="{http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio}Paciente" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "crearPacienteResult"
})
@XmlRootElement(name = "crearPacienteResponse")
public class CrearPacienteResponse {

    @XmlElementRef(name = "crearPacienteResult", namespace = "http://tempuri.org/", type = JAXBElement.class, required = false)
    protected JAXBElement<Paciente> crearPacienteResult;

    /**
     * Gets the value of the crearPacienteResult property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link Paciente }{@code >}
     *     
     */
    public JAXBElement<Paciente> getCrearPacienteResult() {
        return crearPacienteResult;
    }

    /**
     * Sets the value of the crearPacienteResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link Paciente }{@code >}
     *     
     */
    public void setCrearPacienteResult(JAXBElement<Paciente> value) {
        this.crearPacienteResult = value;
    }

}
