package com.upc.condominio.servlets;

import java.io.IOException;
import java.net.ConnectException;
import java.util.List;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.sun.jersey.api.client.Client;
import com.sun.jersey.api.client.ClientResponse;
import com.sun.jersey.api.client.GenericType;
import com.sun.jersey.api.client.WebResource;
import com.sun.jersey.api.client.config.ClientConfig;
import com.sun.jersey.api.client.config.DefaultClientConfig;
import com.sun.jersey.api.json.JSONConfiguration;
import com.upc.condominio.modelo.Medico;
import com.upc.condominio.modelo.Observacion;

/**
 * Servlet implementation class MedicoServlet
 */
@WebServlet("/MedicoServlet")
public class MedicoServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public MedicoServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		process(request,response);
	}

	
	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		process(request,response);
		}
	
	private void process(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		String accion=request.getParameter("accion")==null?"":request.getParameter("accion");
   		String id=request.getParameter("id")==null?"":request.getParameter("id");
   		String nombre=request.getParameter("txtNombre")==null?"":request.getParameter("txtNombre");
		String apepat=request.getParameter("txtApePat")==null?"":request.getParameter("txtApePat");
		String apemat=request.getParameter("txtApeMat")==null?"":request.getParameter("txtApeMat");
		String sexo=request.getParameter("cboSexo")==null?"":request.getParameter("cboSexo");
		String tipdoc=request.getParameter("cboTipoDoc")==null?"":request.getParameter("cboTipoDoc");		
		String numdoc=request.getParameter("txtNroDoc")==null?"":request.getParameter("txtNroDoc");
		String cmp=request.getParameter("txtCMP")==null?"":request.getParameter("txtCMP");
		String esp=request.getParameter("cboEspec")==null?"":request.getParameter("cboEspec");
		String dire=request.getParameter("txtDireccion")==null?"":request.getParameter("txtDireccion");
		String telef=request.getParameter("txtTelefono")==null?"":request.getParameter("txtTelefono");
		String correo=request.getParameter("txtCorreo1")==null?"":request.getParameter("txtCorreo1").toUpperCase();
		
		
		
		String pages="";
		String mensaje="";
		String observacion="";
		List<Medico> listado=null;		
		Medico output=null;
		
		
		if(accion.equals("grabar")){
			
			Medico bean=new Medico();
			bean.setNombre(nombre);
			bean.setApe_Paterno(apepat);
			bean.setApe_Materno(apemat);
			bean.setSexo(sexo);
			bean.setTipo_Documento(Integer.parseInt(tipdoc));
			bean.setNro_Documento(numdoc);
			bean.setCmp(Integer.parseInt(cmp));
			bean.setEspecialidad(Integer.parseInt(esp));
			bean.setDireccion(dire);
			bean.setTelefono(telef);
			bean.setCorreo(correo);
			bean.setPassword(numdoc);
			pages="/pages/RegistrarMedico.jsp";
			try {
				ClientConfig clientConfig = new DefaultClientConfig();

				clientConfig.getFeatures().put(
						JSONConfiguration.FEATURE_POJO_MAPPING, Boolean.TRUE);

				Client client = Client.create(clientConfig);

				WebResource webResource = client
						.resource("http://localhost:1921/Medicos.svc/Medicos");
				
				ClientResponse resp = null;
				
				if(id.equals("")||id.equals("0")){
					
					 resp = webResource.accept("application/json")
							.type("application/json").post(ClientResponse.class, bean);

				
				}else{
					
					 bean.setIdMedico(Integer.parseInt(id));
					 resp = webResource.accept("application/json")
							.type("application/json").put(ClientResponse.class, bean);

			
				}
				
				if (resp.getStatus() != 200) {
					
					observacion=resp.getEntity(Observacion.class).getMensajeError();
					mensaje="3";
					output=bean;
				}else{
					output = resp.getEntity(Medico.class);
					mensaje="1";
				}

				
				
				
			} catch (Exception e) {
				observacion=e.getMessage();
				mensaje="3";
				output=bean;
			}
			
		}else if(accion.equals("modificar")){
			
			pages="/pages/RegistrarMedico.jsp?accion=modificar";
			try {
				ClientConfig clientConfig = new DefaultClientConfig();

				clientConfig.getFeatures().put(
						JSONConfiguration.FEATURE_POJO_MAPPING, Boolean.TRUE);

				Client client = Client.create(clientConfig);

				WebResource webResource = client
						.resource("http://localhost:1921/Medicos.svc/Medicos/"+id);

				ClientResponse resp = webResource.accept("application/json")
						.type("application/json").get(ClientResponse.class);

			
				if (resp.getStatus() != 200) {
					
				}

				 output = resp.getEntity(Medico.class);
				
			} catch (Exception e) {
				e.printStackTrace();
			}
			
			
		}else if(accion.equals("eliminar")){
			
			
			try {
				ClientConfig clientConfig = new DefaultClientConfig();

				clientConfig.getFeatures().put(
						JSONConfiguration.FEATURE_POJO_MAPPING, Boolean.TRUE);

				Client client = Client.create(clientConfig);

				WebResource webResource = client
						.resource("http://localhost:1921/Medicos.svc/Medicos/"+id);

				ClientResponse resp = webResource.accept("application/json")
						.type("application/json").delete(ClientResponse.class);

			
				if (resp.getStatus() != 200) {
					
					
				}

				pages="/pages/ListadoMedicos.jsp";
				listado=listarTodos(request,response);				
				mensaje="2";
				
			} catch (Exception e) {
				e.printStackTrace();
			}
			
		}else if(accion.equals("listar")){
			
			pages="/pages/ListadoMedicos.jsp";
			listado=listarTodos(request,response);
			
		}
		
		request.setAttribute("listadoMedico", listado);
		request.setAttribute("mensaje", mensaje);
		request.setAttribute("obs", observacion);
		request.setAttribute("beanMedico", output);
						
		RequestDispatcher rd = request.getRequestDispatcher(pages);
		rd.forward(request, response);
		
	}
	
	private List<Medico> listarTodos(HttpServletRequest request, HttpServletResponse response){
		
		List<Medico> listado=null;
		try {
			ClientConfig clientConfig = new DefaultClientConfig();

			clientConfig.getFeatures().put(
					JSONConfiguration.FEATURE_POJO_MAPPING, Boolean.TRUE);

			Client client = Client.create(clientConfig);

			WebResource webResource = client
					.resource("http://localhost:1921/Medicos.svc/Medicos");

			 listado=webResource.type("application/json").get(new GenericType<List<Medico>>() {});
					
			
			
		} catch (Exception e) {
			e.printStackTrace();
		}
		
		return listado;
	}


}
