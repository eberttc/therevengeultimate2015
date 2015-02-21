
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
 *         &lt;element name="consultarPacienteResult" type="{http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio}Paciente" minOccurs="0"/>
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
    "consultarPacienteResult"
})
@XmlRootElement(name = "consultarPacienteResponse")
public class ConsultarPacienteResponse {

    @XmlElement(nillable = true)
    protected Paciente consultarPacienteResult;

    /**
     * Gets the value of the consultarPacienteResult property.
     * 
     * @return
     *     possible object is
     *     {@link Paciente }
     *     
     */
    public Paciente getConsultarPacienteResult() {
        return consultarPacienteResult;
    }

    /**
     * Sets the value of the consultarPacienteResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link Paciente }
     *     
     */
    public void setConsultarPacienteResult(Paciente value) {
        this.consultarPacienteResult = value;
    }

}
