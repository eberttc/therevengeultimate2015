package com.upc.condominio.servlets;

import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;
import java.util.List;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.xml.bind.JAXBElement;
import javax.xml.datatype.DatatypeConfigurationException;
import javax.xml.datatype.DatatypeConstants;
import javax.xml.datatype.DatatypeFactory;
import javax.xml.datatype.XMLGregorianCalendar;

import com.upc.consultorio.ws.proxy.ArrayOfPaciente;
import com.upc.consultorio.ws.proxy.ObjectFactory;
import com.upc.consultorio.ws.proxy.Paciente;
import com.upc.consultorio.ws.proxy.PacientesService;

/**
 * Servlet implementation class PacienteServlet
 */
@WebServlet("/PacienteServlet")
public class PacienteServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	
	private static final String PACIENTE_PAGE_LIST="pages/pacienteLista.jsp";
	private static final String PACIENTE_PAGE_FORM = "pages/pacienteForm.jsp";
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public PacienteServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		
	  	//System.getProperties().put("proxySet", "true");
	    //System.getProperties().put("proxyHost", "172.16.1.3");
	    //System.getProperties().put("proxyPort", "8080"); 
	    String target = request.getParameter("_target");
	    	   
	    PacientesService ws = new PacientesService();
	    RequestDispatcher rd = null;
	    if (target.equals("pacientes")){	    
			ArrayOfPaciente lista =  ws.getBasicHttpBindingIPacientesService().listarPaciente();
			List<Paciente> pacientes = lista.getPaciente();
			request.setAttribute("listaPacientes", pacientes);
			rd = request.getRequestDispatcher(PACIENTE_PAGE_LIST);
			
	    }else if (target.equals("formulario")){
	    	String action= "editar";
	    	String idParametro = request.getParameter("param");
	    	Paciente paciente = ws.getBasicHttpBindingIPacientesService().consultarPaciente(Integer.parseInt(idParametro));	    
		    if(paciente == null){
		    	paciente = new Paciente();
		    	action="crear";
		    }
	    request.setAttribute("paciente", paciente);
	    request.setAttribute("action", action);
	    rd = request.getRequestDispatcher(PACIENTE_PAGE_FORM);
	    }
		rd.forward(request, response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		
		//System.getProperties().put("proxySet", "true");
	    //System.getProperties().put("proxyHost", "172.16.1.3");
	    //System.getProperties().put("proxyPort", "8080"); 
		String action = request.getParameter("action");
		
		
	    PacientesService ws = new PacientesService();
	    ObjectFactory objectFactory = new ObjectFactory();
	    Paciente paciente = objectFactory.createPaciente();
	    
	    
	    String nombre = request.getParameter("_nombres");
	    String apellidoPaterno = request.getParameter("_pat");
	    String apellidoMaterno = request.getParameter("_mat");
	    String sexo = request.getParameter("_sex");
	    String tipoDocument = request.getParameter("_tdoc");
	    String numeroDocument = request.getParameter("_ndoc");
	    String correo = request.getParameter("_mail");
	    String direccion = request.getParameter("_direccion");
	    String telefono = request.getParameter("_telefono");
	    String fechaNacimienti = request.getParameter("_fecnac");
	    String identificador=request.getParameter("identificador");
	    
	    paciente.setNombres(objectFactory.createString(nombre));
	    paciente.setApeMaterno(objectFactory.createString(apellidoPaterno));
	    paciente.setApePaterno(objectFactory.createString(apellidoMaterno));
	    paciente.setSexo(objectFactory.createString(nombre));
	    paciente.setIdTipoDoc(Integer.parseInt(tipoDocument));
	    paciente.setNroDocumento(objectFactory.createString(numeroDocument));
	    paciente.setCorreo(objectFactory.createString(correo));
	    paciente.setDireccion(objectFactory.createString(direccion));
	    paciente.setTelefono(objectFactory.createString(telefono));	 
	    
	    
	    //paciente.setFecNac(convertStringDateToXmlGregorianCalendar( "2010/11/20", "yyyy/MM/dd", true ));
	    
	    if(action.equals("crear")){
	    ws.getBasicHttpBindingIPacientesService().crearPaciente(paciente);
	    }
	    else{
	    	
	    	paciente.setIdPaciente(Integer.parseInt((identificador)));
	    	ws.getBasicHttpBindingIPacientesService().actualizarPaciente(paciente);	
	    }
	    
	    RequestDispatcher rd = request.getRequestDispatcher(PACIENTE_PAGE_LIST);
	    rd.forward(request, response);
	   
	    		
	}
		
	    public static XMLGregorianCalendar 
	        convertStringDateToXmlGregorianCalendar( String dateStr, String dateFormat, boolean noTimezone )
	    {
	        try
	        {
	            // this may throw DatatypeConfigurationException
	            DatatypeFactory datatypeFactory = DatatypeFactory.newInstance();
	            GregorianCalendar calendar = new GregorianCalendar();
	            // reset all fields
	            calendar.clear();
	 
	            Calendar parsedCalendar = Calendar.getInstance();
	            // eg "yyyy-MM-dd"
	            SimpleDateFormat sdf = new SimpleDateFormat( dateFormat );
	            // this may throw ParseException
	            Date rawDate = sdf.parse( dateStr );
	            parsedCalendar.setTime( rawDate );
	 
	            // set date from parameter and leave time as default calendar values
	            calendar.set( parsedCalendar.get( Calendar.YEAR ), 
	                            parsedCalendar.get( Calendar.MONTH ),
	                            parsedCalendar.get( Calendar.DATE ) );
	 
	            XMLGregorianCalendar xmlCalendar = datatypeFactory.newXMLGregorianCalendar( calendar );
	            // clears default timezone
	            if ( noTimezone )
	            {
	                xmlCalendar.setTimezone( DatatypeConstants.FIELD_UNDEFINED );
	            }
	 
	            return xmlCalendar;
	        }
	        catch ( Exception e )
	        {
	            throw new RuntimeException( e );
	        }
	    }
	 
	    public static XMLGregorianCalendar 
	        convertStringTimeToXmlGregorianCalendar( String timeStr, String timeFormat, boolean noFractionalSecs, boolean noTimezone )
	    {
	        try
	        {
	            // this may throw DatatypeConfigurationException
	            DatatypeFactory datatypeFactory = DatatypeFactory.newInstance();
	            GregorianCalendar calendar = new GregorianCalendar();
	            // reset all fields
	            calendar.clear();
	 
	            Calendar parsedCalendar = Calendar.getInstance();
	            // eg "HH:mm:ss"
	            SimpleDateFormat sdf = new SimpleDateFormat( timeFormat );
	            // this may throw ParseException
	            Date rawDate = sdf.parse( timeStr );
	            parsedCalendar.setTime( rawDate );
	 
	            // set time from time parameter and set date to default values
	            calendar.set( calendar.get( GregorianCalendar.YEAR ), 
	                            calendar.get( GregorianCalendar.MONTH ),
	                            calendar.get( GregorianCalendar.DATE ), 
	                            parsedCalendar.get( Calendar.HOUR ),
	                            parsedCalendar.get( Calendar.MINUTE ), 
	                            parsedCalendar.get( Calendar.SECOND ) );
	 
	            XMLGregorianCalendar xmlCalendar = datatypeFactory.newXMLGregorianCalendar( calendar );
	            // clears default timezone
	            if ( noTimezone )
	            {
	                xmlCalendar.setTimezone( DatatypeConstants.FIELD_UNDEFINED );
	            }
	            // clears default fractional seconds
	            if ( noFractionalSecs )
	            {
	                xmlCalendar.setFractionalSecond( null );
	            }
	 
	            return xmlCalendar;
	        }
	        catch ( Exception e )
	        {
	            throw new RuntimeException( e );
	        }
	    }
	

}


