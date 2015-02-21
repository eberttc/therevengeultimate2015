package com.upc.condominio.servlets;

import java.io.IOException;
import java.util.List;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import pe.com.consultorio.ws.Paciente;

import com.upc.condominio.exceptions.DAOExcepcion;
import com.upc.condominio.exceptions.LoginExcepcion;
import com.upc.condominio.modelo.Usuario;
import com.upc.condominio.negocio.GestionUsuarios;
import com.upc.condominio.servicios.EyeSuiteWrapperService;


/**
 * Servlet implementation class for Servlet: LoginServlet
 * 
 */
@WebServlet("/LoginServlet")
public class LoginServlet extends javax.servlet.http.HttpServlet implements
		javax.servlet.Servlet {
	static final long serialVersionUID = 1L;

	/*
	 * (non-Java-doc)
	 * 
	 * @see javax.servlet.http.HttpServlet#HttpServlet()
	 */
	public LoginServlet() {
		super();
	}

	/*
	 * (non-Java-doc)
	 * 
	 * @see javax.servlet.http.HttpServlet#doGet(HttpServletRequest request,
	 *      HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		
		RequestDispatcher rd = request.getRequestDispatcher("index.xhtml");
		rd.forward(request, response);
	}

	/*
	 * (non-Java-doc)
	 * 
	 * @see javax.servlet.http.HttpServlet#doPost(HttpServletRequest request,
	 *      HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {

		
		//String usuario = request.getParameter("txtUser");
		// no es correo ? 
		String correo = request.getParameter("txtUser");
		String clave = request.getParameter("txtPass");
		System.out.println("clave :> " + clave);
		String tipoUsuraio= request.getParameter("hidTipo");
		Boolean usuarioEncontrado = Boolean.FALSE;
		
		//admin ? 
		if(tipoUsuraio.equals("A")){
			
			usuarioEncontrado = Boolean.TRUE;
		}
		
		//supongo que es para pacientes
		if(tipoUsuraio.equals("R")){
			List<Paciente> pacientes = EyeSuiteWrapperService.getInstance().obtenerServicioPaciente().listarPaciente().getPaciente();
			for (Paciente paciente : pacientes) {
				System.out.println("paciente : " + paciente.getCorreo() + " clave : " + paciente.getPassword());
				if(paciente.getCorreo().equals(correo) && paciente.getPassword().equals(clave)){
					usuarioEncontrado =  Boolean.TRUE;
					request.getSession(false).setAttribute("USUARIO", paciente );
					break;
				}
			}
			
			//falta para el medico !!
			//llamar al rest
		}
		
		
		
		
		System.out.println("correo "+correo); 
		System.out.println("clave "+clave);
		System.out.println("tipoUsuraio "+tipoUsuraio);
		
		//GestionUsuarios negocio = new GestionUsuarios();

		//try {
			/*Usuario vo = negocio.validarUsuario(usuario, clave,tipoUsuraio);
			List menu=negocio.obtienePermisos(vo);
			HttpSession session = request.getSession();
			session.setAttribute("USUARIO_ACTUAL", vo);
			session.setAttribute("MENU", menu);*/
			RequestDispatcher rd = null;
			if(usuarioEncontrado){				
			rd = request.getRequestDispatcher("/pages/principal.jsp");			
			}else{
				
				request.setAttribute("ERROR", "USUARIO NO EXISTE ");
				rd = request.getRequestDispatcher("/");
			}
			
			rd.forward(request, response);
			
			
			
		/*} catch (DAOExcepcion e) {
			request.setAttribute("MENSAJE", "Hubo un error al procesar la operación: " + e.getMessage());	
		} catch (LoginExcepcion e) {			
			request.setAttribute("MENSAJE", "Usuario y/o clave incorrectos");
		}
		
		RequestDispatcher rd = request.getRequestDispatcher("/index.jsp");
		rd.forward(request, response);*/
	}
}