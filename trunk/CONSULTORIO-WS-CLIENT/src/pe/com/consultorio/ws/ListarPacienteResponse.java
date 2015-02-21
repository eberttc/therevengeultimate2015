
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

    @XmlElement(nillable = true)
    protected ArrayOfPaciente listarPacienteResult;

    /**
     * Gets the value of the listarPacienteResult property.
     * 
     * @return
     *     possible object is
     *     {@link ArrayOfPaciente }
     *     
     */
    public ArrayOfPaciente getListarPacienteResult() {
        return listarPacienteResult;
    }

    /**
     * Sets the value of the listarPacienteResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link ArrayOfPaciente }
     *     
     */
    public void setListarPacienteResult(ArrayOfPaciente value) {
        this.listarPacienteResult = value;
    }

}
