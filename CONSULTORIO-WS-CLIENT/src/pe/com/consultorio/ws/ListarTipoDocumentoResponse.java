
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
 *         &lt;element name="listarTipo_DocumentoResult" type="{http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio}ArrayOfTipo_Documento" minOccurs="0"/>
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
    "listarTipoDocumentoResult"
})
@XmlRootElement(name = "listarTipo_DocumentoResponse")
public class ListarTipoDocumentoResponse {

    @XmlElement(name = "listarTipo_DocumentoResult", nillable = true)
    protected ArrayOfTipoDocumento listarTipoDocumentoResult;

    /**
     * Gets the value of the listarTipoDocumentoResult property.
     * 
     * @return
     *     possible object is
     *     {@link ArrayOfTipoDocumento }
     *     
     */
    public ArrayOfTipoDocumento getListarTipoDocumentoResult() {
        return listarTipoDocumentoResult;
    }

    /**
     * Sets the value of the listarTipoDocumentoResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link ArrayOfTipoDocumento }
     *     
     */
    public void setListarTipoDocumentoResult(ArrayOfTipoDocumento value) {
        this.listarTipoDocumentoResult = value;
    }

}
