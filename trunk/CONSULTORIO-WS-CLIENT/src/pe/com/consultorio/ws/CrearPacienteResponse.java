
package pe.com.consultorio.ws;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
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

    @XmlElement(nillable = true)
    protected Paciente crearPacienteResult;

    /**
     * Gets the value of the crearPacienteResult property.
     * 
     * @return
     *     possible object is
     *     {@link Paciente }
     *     
     */
    public Paciente getCrearPacienteResult() {
        return crearPacienteResult;
    }

    /**
     * Sets the value of the crearPacienteResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link Paciente }
     *     
     */
    public void setCrearPacienteResult(Paciente value) {
        this.crearPacienteResult = value;
    }

}
