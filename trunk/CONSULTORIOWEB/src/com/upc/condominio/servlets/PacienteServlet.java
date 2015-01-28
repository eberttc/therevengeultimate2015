package com.upc.condominio.servlets;

import java.io.IOException;
import java.util.List;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;


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
		
	  	System.getProperties().put("proxySet", "true");
	    System.getProperties().put("proxyHost", "172.16.1.3");
	    System.getProperties().put("proxyPort", "8080"); 
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
		
		System.getProperties().put("proxySet", "true");
	    System.getProperties().put("proxyHost", "172.16.1.3");
	    System.getProperties().put("proxyPort", "8080"); 
	    PacientesService ws = new PacientesService();

		
		
	}

}

