package com.upc.condominio.servlets;

import java.io.IOException;
import java.util.List;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.xml.ws.soap.SOAPFaultException;

import org.apache.commons.lang3.StringUtils;

import com.upc.condominio.forms.PacienteForm;
import com.upc.condominio.util.EyeSuiteParseException;
import com.upc.consultorio.ws.proxy.ArrayOfPaciente;
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
		
	  	/*System.getProperties().put("proxySet", "true");
	    System.getProperties().put("proxyHost", "172.16.1.3");
	    System.getProperties().put("proxyPort", "8080");*/ 
	    String target = request.getParameter("_target");	    
	    PacientesService pacientesService = new PacientesService();
	    RequestDispatcher rd = null;
	    PacienteForm form = new PacienteForm();
	    if (target.equals("pacientes")){	    
			ArrayOfPaciente lista =  pacientesService.getBasicHttpBindingIPacientesService().listarPaciente();
			List<Paciente> pacientes = lista.getPaciente();
			request.setAttribute("listaPacientes", pacientes);
			rd = request.getRequestDispatcher(PACIENTE_PAGE_LIST);
			
	    }else if (target.equals("formulario")){
	    	String action= "editar";
	    	String idParametro = request.getParameter("param");
	    	
	    	if(StringUtils.isBlank(idParametro)){
	    		action="crear";
	    	}
	    	else{
	    		Paciente paciente =pacientesService.getBasicHttpBindingIPacientesService().consultarPaciente(Integer.parseInt(idParametro)); 	    				    
			    form.populateForm(paciente);			    
	    	}	    	
	    	
	    request.setAttribute("pacienteForm", form);
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
		
		/*System.getProperties().put("proxySet", "true");
	    System.getProperties().put("proxyHost", "172.16.1.3");
	    System.getProperties().put("proxyPort", "8080");*/ 
				
		
		String action = request.getParameter("action");
		PacientesService ws = new PacientesService();
		RequestDispatcher rd = null;
		PacienteForm form = new PacienteForm();
		
		try {
			Paciente paciente = form.parseForm(request.getParameterMap());
		   if(action.equals("crear")){
		    	ws.getBasicHttpBindingIPacientesService().crearPaciente(paciente);
		    }
		    else{	    		    
		    	ws.getBasicHttpBindingIPacientesService().actualizarPaciente(paciente);	
		 }
		   
		   response.sendRedirect("PacienteServlet?_target=pacientes");
		} catch ( EyeSuiteParseException |  SOAPFaultException e) {
			System.out.println("Exception : " + e.getMessage());
			request.setAttribute("pacienteForm", form);
			request.setAttribute("errors", form.getErrors().values().toArray());
			rd = request.getRequestDispatcher(PACIENTE_PAGE_FORM);
		}
		
	    	    	  	    	
		rd.forward(request, response);
	    		
	}
		
	   
	

}


