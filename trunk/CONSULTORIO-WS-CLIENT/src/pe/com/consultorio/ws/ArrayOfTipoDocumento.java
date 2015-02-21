
package pe.com.consultorio.ws;

import java.util.ArrayList;
import java.util.List;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for ArrayOfTipo_Documento complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="ArrayOfTipo_Documento">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="Tipo_Documento" type="{http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio}Tipo_Documento" maxOccurs="unbounded" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "ArrayOfTipo_Documento", namespace = "http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", propOrder = {
    "tipoDocumento"
})
public class ArrayOfTipoDocumento {

    @XmlElement(name = "Tipo_Documento", nillable = true)
    protected List<TipoDocumento> tipoDocumento;

    /**
     * Gets the value of the tipoDocumento property.
     * 
     * <p>
     * This accessor method returns a reference to the live list,
     * not a snapshot. Therefore any modification you make to the
     * returned list will be present inside the JAXB object.
     * This is why there is not a <CODE>set</CODE> method for the tipoDocumento property.
     * 
     * <p>
     * For example, to add a new item, do as follows:
     * <pre>
     *    getTipoDocumento().add(newItem);
     * </pre>
     * 
     * 
     * <p>
     * Objects of the following type(s) are allowed in the list
     * {@link TipoDocumento }
     * 
     * 
     */
    public List<TipoDocumento> getTipoDocumento() {
        if (tipoDocumento == null) {
            tipoDocumento = new ArrayList<TipoDocumento>();
        }
        return this.tipoDocumento;
    }

}
