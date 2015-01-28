
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
 *         &lt;element name="listarPacienteResult" type="{http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio}ArrayOfPaciente" minOccurs="0"/>
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
    "listarPacienteResult"
})
@XmlRootElement(name = "listarPacienteResponse")
public class ListarPacienteResponse {

    @XmlElementRef(name = "listarPacienteResult", namespace = "http://tempuri.org/", type = JAXBElement.class, required = false)
    protected JAXBElement<ArrayOfPaciente> listarPacienteResult;

    /**
     * Gets the value of the listarPacienteResult property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfPaciente }{@code >}
     *     
     */
    public JAXBElement<ArrayOfPaciente> getListarPacienteResult() {
        return listarPacienteResult;
    }

    /**
     * Sets the value of the listarPacienteResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfPaciente }{@code >}
     *     
     */
    public void setListarPacienteResult(JAXBElement<ArrayOfPaciente> value) {
        this.listarPacienteResult = value;
    }

}
