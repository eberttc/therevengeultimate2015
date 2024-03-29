
package pe.com.consultorio.ws;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlSchemaType;
import javax.xml.bind.annotation.XmlType;
import javax.xml.datatype.XMLGregorianCalendar;


/**
 * <p>Java class for Paciente complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="Paciente">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="Ape_Materno" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="Ape_Paterno" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="Correo" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="Direccion" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="Fec_Nac" type="{http://www.w3.org/2001/XMLSchema}dateTime" minOccurs="0"/>
 *         &lt;element name="IdPaciente" type="{http://www.w3.org/2001/XMLSchema}int" minOccurs="0"/>
 *         &lt;element name="Id_Tipo_Doc" type="{http://www.w3.org/2001/XMLSchema}int" minOccurs="0"/>
 *         &lt;element name="Nombres" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="Nro_Documento" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="Password" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="Sexo" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="Telefono" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "Paciente", namespace = "http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", propOrder = {
    "apeMaterno",
    "apePaterno",
    "correo",
    "direccion",
    "fecNac",
    "idPaciente",
    "idTipoDoc",
    "nombres",
    "nroDocumento",
    "password",
    "sexo",
    "telefono"
})
public class Paciente {

    @XmlElement(name = "Ape_Materno", nillable = true)
    protected String apeMaterno;
    @XmlElement(name = "Ape_Paterno", nillable = true)
    protected String apePaterno;
    @XmlElement(name = "Correo", nillable = true)
    protected String correo;
    @XmlElement(name = "Direccion", nillable = true)
    protected String direccion;
    @XmlElement(name = "Fec_Nac")
    @XmlSchemaType(name = "dateTime")
    protected XMLGregorianCalendar fecNac;
    @XmlElement(name = "IdPaciente")
    protected Integer idPaciente;
    @XmlElement(name = "Id_Tipo_Doc")
    protected Integer idTipoDoc;
    @XmlElement(name = "Nombres", nillable = true)
    protected String nombres;
    @XmlElement(name = "Nro_Documento", nillable = true)
    protected String nroDocumento;
    @XmlElement(name = "Password", nillable = true)
    protected String password;
    @XmlElement(name = "Sexo", nillable = true)
    protected String sexo;
    @XmlElement(name = "Telefono", nillable = true)
    protected String telefono;

    /**
     * Gets the value of the apeMaterno property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getApeMaterno() {
        return apeMaterno;
    }

    /**
     * Sets the value of the apeMaterno property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setApeMaterno(String value) {
        this.apeMaterno = value;
    }

    /**
     * Gets the value of the apePaterno property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getApePaterno() {
        return apePaterno;
    }

    /**
     * Sets the value of the apePaterno property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setApePaterno(String value) {
        this.apePaterno = value;
    }

    /**
     * Gets the value of the correo property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getCorreo() {
        return correo;
    }

    /**
     * Sets the value of the correo property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setCorreo(String value) {
        this.correo = value;
    }

    /**
     * Gets the value of the direccion property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getDireccion() {
        return direccion;
    }

    /**
     * Sets the value of the direccion property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setDireccion(String value) {
        this.direccion = value;
    }

    /**
     * Gets the value of the fecNac property.
     * 
     * @return
     *     possible object is
     *     {@link XMLGregorianCalendar }
     *     
     */
    public XMLGregorianCalendar getFecNac() {
        return fecNac;
    }

    /**
     * Sets the value of the fecNac property.
     * 
     * @param value
     *     allowed object is
     *     {@link XMLGregorianCalendar }
     *     
     */
    public void setFecNac(XMLGregorianCalendar value) {
        this.fecNac = value;
    }

    /**
     * Gets the value of the idPaciente property.
     * 
     * @return
     *     possible object is
     *     {@link Integer }
     *     
     */
    public Integer getIdPaciente() {
        return idPaciente;
    }

    /**
     * Sets the value of the idPaciente property.
     * 
     * @param value
     *     allowed object is
     *     {@link Integer }
     *     
     */
    public void setIdPaciente(Integer value) {
        this.idPaciente = value;
    }

    /**
     * Gets the value of the idTipoDoc property.
     * 
     * @return
     *     possible object is
     *     {@link Integer }
     *     
     */
    public Integer getIdTipoDoc() {
        return idTipoDoc;
    }

    /**
     * Sets the value of the idTipoDoc property.
     * 
     * @param value
     *     allowed object is
     *     {@link Integer }
     *     
     */
    public void setIdTipoDoc(Integer value) {
        this.idTipoDoc = value;
    }

    /**
     * Gets the value of the nombres property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getNombres() {
        return nombres;
    }

    /**
     * Sets the value of the nombres property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setNombres(String value) {
        this.nombres = value;
    }

    /**
     * Gets the value of the nroDocumento property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getNroDocumento() {
        return nroDocumento;
    }

    /**
     * Sets the value of the nroDocumento property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setNroDocumento(String value) {
        this.nroDocumento = value;
    }

    /**
     * Gets the value of the password property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getPassword() {
        return password;
    }

    /**
     * Sets the value of the password property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setPassword(String value) {
        this.password = value;
    }

    /**
     * Gets the value of the sexo property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getSexo() {
        return sexo;
    }

    /**
     * Sets the value of the sexo property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setSexo(String value) {
        this.sexo = value;
    }

    /**
     * Gets the value of the telefono property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getTelefono() {
        return telefono;
    }

    /**
     * Sets the value of the telefono property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setTelefono(String value) {
        this.telefono = value;
    }

}
