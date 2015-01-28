
package com.upc.consultorio.ws.proxy;

import java.math.BigDecimal;
import java.math.BigInteger;
import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.datatype.Duration;
import javax.xml.datatype.XMLGregorianCalendar;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the com.upc.consultorio.ws.proxy package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _AnyURI_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "anyURI");
    private final static QName _Char_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "char");
    private final static QName _UnsignedByte_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "unsignedByte");
    private final static QName _DateTime_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "dateTime");
    private final static QName _AnyType_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "anyType");
    private final static QName _UnsignedInt_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "unsignedInt");
    private final static QName _Int_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "int");
    private final static QName _QName_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "QName");
    private final static QName _UnsignedShort_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "unsignedShort");
    private final static QName _ArrayOfPaciente_QNAME = new QName("http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", "ArrayOfPaciente");
    private final static QName _Float_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "float");
    private final static QName _Decimal_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "decimal");
    private final static QName _Long_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "long");
    private final static QName _Double_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "double");
    private final static QName _Short_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "short");
    private final static QName _Guid_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "guid");
    private final static QName _Paciente_QNAME = new QName("http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", "Paciente");
    private final static QName _Base64Binary_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "base64Binary");
    private final static QName _Duration_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "duration");
    private final static QName _Byte_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "byte");
    private final static QName _String_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "string");
    private final static QName _UnsignedLong_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "unsignedLong");
    private final static QName _Boolean_QNAME = new QName("http://schemas.microsoft.com/2003/10/Serialization/", "boolean");
    private final static QName _ListarPacienteResponseListarPacienteResult_QNAME = new QName("http://tempuri.org/", "listarPacienteResult");
    private final static QName _ActualizarPacientePaciente_QNAME = new QName("http://tempuri.org/", "_paciente");
    private final static QName _CrearPacienteResponseCrearPacienteResult_QNAME = new QName("http://tempuri.org/", "crearPacienteResult");
    private final static QName _ConsultarPacienteResponseConsultarPacienteResult_QNAME = new QName("http://tempuri.org/", "consultarPacienteResult");
    private final static QName _ActualizarPacienteResponseActualizarPacienteResult_QNAME = new QName("http://tempuri.org/", "actualizarPacienteResult");
    private final static QName _PacienteDireccion_QNAME = new QName("http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", "Direccion");
    private final static QName _PacienteSexo_QNAME = new QName("http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", "Sexo");
    private final static QName _PacienteNombres_QNAME = new QName("http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", "Nombres");
    private final static QName _PacientePassword_QNAME = new QName("http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", "Password");
    private final static QName _PacienteApeMaterno_QNAME = new QName("http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", "Ape_Materno");
    private final static QName _PacienteApePaterno_QNAME = new QName("http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", "Ape_Paterno");
    private final static QName _PacienteTelefono_QNAME = new QName("http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", "Telefono");
    private final static QName _PacienteNroDocumento_QNAME = new QName("http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", "Nro_Documento");
    private final static QName _PacienteCorreo_QNAME = new QName("http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", "Correo");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: com.upc.consultorio.ws.proxy
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link CrearPaciente }
     * 
     */
    public CrearPaciente createCrearPaciente() {
        return new CrearPaciente();
    }

    /**
     * Create an instance of {@link Paciente }
     * 
     */
    public Paciente createPaciente() {
        return new Paciente();
    }

    /**
     * Create an instance of {@link ListarPaciente }
     * 
     */
    public ListarPaciente createListarPaciente() {
        return new ListarPaciente();
    }

    /**
     * Create an instance of {@link CrearPacienteResponse }
     * 
     */
    public CrearPacienteResponse createCrearPacienteResponse() {
        return new CrearPacienteResponse();
    }

    /**
     * Create an instance of {@link EliminarPacienteResponse }
     * 
     */
    public EliminarPacienteResponse createEliminarPacienteResponse() {
        return new EliminarPacienteResponse();
    }

    /**
     * Create an instance of {@link ActualizarPacienteResponse }
     * 
     */
    public ActualizarPacienteResponse createActualizarPacienteResponse() {
        return new ActualizarPacienteResponse();
    }

    /**
     * Create an instance of {@link ListarPacienteResponse }
     * 
     */
    public ListarPacienteResponse createListarPacienteResponse() {
        return new ListarPacienteResponse();
    }

    /**
     * Create an instance of {@link ArrayOfPaciente }
     * 
     */
    public ArrayOfPaciente createArrayOfPaciente() {
        return new ArrayOfPaciente();
    }

    /**
     * Create an instance of {@link ActualizarPaciente }
     * 
     */
    public ActualizarPaciente createActualizarPaciente() {
        return new ActualizarPaciente();
    }

    /**
     * Create an instance of {@link ConsultarPaciente }
     * 
     */
    public ConsultarPaciente createConsultarPaciente() {
        return new ConsultarPaciente();
    }

    /**
     * Create an instance of {@link EliminarPaciente }
     * 
     */
    public EliminarPaciente createEliminarPaciente() {
        return new EliminarPaciente();
    }

    /**
     * Create an instance of {@link ConsultarPacienteResponse }
     * 
     */
    public ConsultarPacienteResponse createConsultarPacienteResponse() {
        return new ConsultarPacienteResponse();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "anyURI")
    public JAXBElement<String> createAnyURI(String value) {
        return new JAXBElement<String>(_AnyURI_QNAME, String.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Integer }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "char")
    public JAXBElement<Integer> createChar(Integer value) {
        return new JAXBElement<Integer>(_Char_QNAME, Integer.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Short }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "unsignedByte")
    public JAXBElement<Short> createUnsignedByte(Short value) {
        return new JAXBElement<Short>(_UnsignedByte_QNAME, Short.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link XMLGregorianCalendar }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "dateTime")
    public JAXBElement<XMLGregorianCalendar> createDateTime(XMLGregorianCalendar value) {
        return new JAXBElement<XMLGregorianCalendar>(_DateTime_QNAME, XMLGregorianCalendar.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Object }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "anyType")
    public JAXBElement<Object> createAnyType(Object value) {
        return new JAXBElement<Object>(_AnyType_QNAME, Object.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Long }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "unsignedInt")
    public JAXBElement<Long> createUnsignedInt(Long value) {
        return new JAXBElement<Long>(_UnsignedInt_QNAME, Long.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Integer }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "int")
    public JAXBElement<Integer> createInt(Integer value) {
        return new JAXBElement<Integer>(_Int_QNAME, Integer.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link QName }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "QName")
    public JAXBElement<QName> createQName(QName value) {
        return new JAXBElement<QName>(_QName_QNAME, QName.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Integer }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "unsignedShort")
    public JAXBElement<Integer> createUnsignedShort(Integer value) {
        return new JAXBElement<Integer>(_UnsignedShort_QNAME, Integer.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ArrayOfPaciente }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", name = "ArrayOfPaciente")
    public JAXBElement<ArrayOfPaciente> createArrayOfPaciente(ArrayOfPaciente value) {
        return new JAXBElement<ArrayOfPaciente>(_ArrayOfPaciente_QNAME, ArrayOfPaciente.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Float }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "float")
    public JAXBElement<Float> createFloat(Float value) {
        return new JAXBElement<Float>(_Float_QNAME, Float.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link BigDecimal }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "decimal")
    public JAXBElement<BigDecimal> createDecimal(BigDecimal value) {
        return new JAXBElement<BigDecimal>(_Decimal_QNAME, BigDecimal.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Long }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "long")
    public JAXBElement<Long> createLong(Long value) {
        return new JAXBElement<Long>(_Long_QNAME, Long.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Double }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "double")
    public JAXBElement<Double> createDouble(Double value) {
        return new JAXBElement<Double>(_Double_QNAME, Double.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Short }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "short")
    public JAXBElement<Short> createShort(Short value) {
        return new JAXBElement<Short>(_Short_QNAME, Short.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "guid")
    public JAXBElement<String> createGuid(String value) {
        return new JAXBElement<String>(_Guid_QNAME, String.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Paciente }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", name = "Paciente")
    public JAXBElement<Paciente> createPaciente(Paciente value) {
        return new JAXBElement<Paciente>(_Paciente_QNAME, Paciente.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link byte[]}{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "base64Binary")
    public JAXBElement<byte[]> createBase64Binary(byte[] value) {
        return new JAXBElement<byte[]>(_Base64Binary_QNAME, byte[].class, null, ((byte[]) value));
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Duration }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "duration")
    public JAXBElement<Duration> createDuration(Duration value) {
        return new JAXBElement<Duration>(_Duration_QNAME, Duration.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Byte }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "byte")
    public JAXBElement<Byte> createByte(Byte value) {
        return new JAXBElement<Byte>(_Byte_QNAME, Byte.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "string")
    public JAXBElement<String> createString(String value) {
        return new JAXBElement<String>(_String_QNAME, String.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link BigInteger }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "unsignedLong")
    public JAXBElement<BigInteger> createUnsignedLong(BigInteger value) {
        return new JAXBElement<BigInteger>(_UnsignedLong_QNAME, BigInteger.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Boolean }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.microsoft.com/2003/10/Serialization/", name = "boolean")
    public JAXBElement<Boolean> createBoolean(Boolean value) {
        return new JAXBElement<Boolean>(_Boolean_QNAME, Boolean.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ArrayOfPaciente }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "listarPacienteResult", scope = ListarPacienteResponse.class)
    public JAXBElement<ArrayOfPaciente> createListarPacienteResponseListarPacienteResult(ArrayOfPaciente value) {
        return new JAXBElement<ArrayOfPaciente>(_ListarPacienteResponseListarPacienteResult_QNAME, ArrayOfPaciente.class, ListarPacienteResponse.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Paciente }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "_paciente", scope = ActualizarPaciente.class)
    public JAXBElement<Paciente> createActualizarPacientePaciente(Paciente value) {
        return new JAXBElement<Paciente>(_ActualizarPacientePaciente_QNAME, Paciente.class, ActualizarPaciente.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Paciente }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "_paciente", scope = CrearPaciente.class)
    public JAXBElement<Paciente> createCrearPacientePaciente(Paciente value) {
        return new JAXBElement<Paciente>(_ActualizarPacientePaciente_QNAME, Paciente.class, CrearPaciente.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Paciente }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "crearPacienteResult", scope = CrearPacienteResponse.class)
    public JAXBElement<Paciente> createCrearPacienteResponseCrearPacienteResult(Paciente value) {
        return new JAXBElement<Paciente>(_CrearPacienteResponseCrearPacienteResult_QNAME, Paciente.class, CrearPacienteResponse.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Paciente }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "consultarPacienteResult", scope = ConsultarPacienteResponse.class)
    public JAXBElement<Paciente> createConsultarPacienteResponseConsultarPacienteResult(Paciente value) {
        return new JAXBElement<Paciente>(_ConsultarPacienteResponseConsultarPacienteResult_QNAME, Paciente.class, ConsultarPacienteResponse.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Paciente }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "actualizarPacienteResult", scope = ActualizarPacienteResponse.class)
    public JAXBElement<Paciente> createActualizarPacienteResponseActualizarPacienteResult(Paciente value) {
        return new JAXBElement<Paciente>(_ActualizarPacienteResponseActualizarPacienteResult_QNAME, Paciente.class, ActualizarPacienteResponse.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", name = "Direccion", scope = Paciente.class)
    public JAXBElement<String> createPacienteDireccion(String value) {
        return new JAXBElement<String>(_PacienteDireccion_QNAME, String.class, Paciente.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", name = "Sexo", scope = Paciente.class)
    public JAXBElement<String> createPacienteSexo(String value) {
        return new JAXBElement<String>(_PacienteSexo_QNAME, String.class, Paciente.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", name = "Nombres", scope = Paciente.class)
    public JAXBElement<String> createPacienteNombres(String value) {
        return new JAXBElement<String>(_PacienteNombres_QNAME, String.class, Paciente.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", name = "Password", scope = Paciente.class)
    public JAXBElement<String> createPacientePassword(String value) {
        return new JAXBElement<String>(_PacientePassword_QNAME, String.class, Paciente.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", name = "Ape_Materno", scope = Paciente.class)
    public JAXBElement<String> createPacienteApeMaterno(String value) {
        return new JAXBElement<String>(_PacienteApeMaterno_QNAME, String.class, Paciente.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", name = "Ape_Paterno", scope = Paciente.class)
    public JAXBElement<String> createPacienteApePaterno(String value) {
        return new JAXBElement<String>(_PacienteApePaterno_QNAME, String.class, Paciente.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", name = "Telefono", scope = Paciente.class)
    public JAXBElement<String> createPacienteTelefono(String value) {
        return new JAXBElement<String>(_PacienteTelefono_QNAME, String.class, Paciente.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", name = "Nro_Documento", scope = Paciente.class)
    public JAXBElement<String> createPacienteNroDocumento(String value) {
        return new JAXBElement<String>(_PacienteNroDocumento_QNAME, String.class, Paciente.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio", name = "Correo", scope = Paciente.class)
    public JAXBElement<String> createPacienteCorreo(String value) {
        return new JAXBElement<String>(_PacienteCorreo_QNAME, String.class, Paciente.class, value);
    }

}
