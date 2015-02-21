package com.upc.condominio.servlets;

import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
 
/**
 * Servlet implementation class ReservaCitaServlet
 */
@WebServlet("/ReservaCitaServlet")
public class ReservaCitaServlet extends HttpServlet {
//	private static final long serialVersionUID = 1L;
//       
//    /**
//     * @see HttpServlet#HttpServlet()
//     */
//    public ReservaCitaServlet() {
//        super();
//        // TODO Auto-generated constructor stub
//    }
//
//	/**
//	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
//	 */
//	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
//		process(request,response);
//	}
//
//	
//
//	/**
//	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
//	 */
//	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
//		process(request,response);
//
//	}
//	
//	
//	private void process(HttpServletRequest request,
//			HttpServletResponse response) throws ServletException, IOException {
//		
//		String id=request.getParameter("idReserva")==null?"":request.getParameter("idReserva");
//		String accion=request.getParameter("accion")==null?"":request.getParameter("accion");
//		String tipoEspecialidad=request.getParameter("tipo")==null?"":request.getParameter("tipo");
//		String codMedico=request.getParameter("codigoMed")==null?"-1":request.getParameter("codigoMed");
//		String codigoHidden=request.getParameter("codigoHidden")==null?"-1":request.getParameter("codigoHidden");
//		String codEspe=request.getParameter("cboEspecialidad")==null?"-1":request.getParameter("cboEspecialidad");
//		String cboHorario=request.getParameter("cboHorario")==null?"-1":request.getParameter("cboHorario");
//		String strFechaReserva=request.getParameter("txtfecha")==null?"-1":request.getParameter("txtfecha");
//		
//		
//		Cita output=null;
//		String mensaje="";
//		String pages="/pages/ingresarReserva.jsp";
//		List<Medico> lstMedicos=null;
//		List<Especialidad> lstEspeList=listarEspecialidades();
//		List<Horario> lstHorarios=listarHorarios();
//		Cita beanCita=null;
//		String observacion="";
//		Cita beanReserva=null;
//		
//		 if(accion.equals("listadoMedico")){
//			pages="/pages/ListadoMedicosXespecialidad.jsp";
//			lstMedicos=listarMedicosXEspecialidades(request, response, Integer.parseInt(tipoEspecialidad));
//			
//		 }else if(accion.equals("grabar")){
//			
//			beanCita=new Cita();
//			beanCita.setFecReserva(strFechaReserva);
//			beanCita.setIdEspecialidad(Integer.parseInt(codEspe));
//			beanCita.setIdMedico(Integer.parseInt(codMedico));
//			beanCita.setIdHorario(Integer.parseInt(cboHorario));
//			beanCita.setIdPaciente(Integer.parseInt("1"));
//			beanCita.setIdEstado(1);
//			try {
//				ClientConfig clientConfig = new DefaultClientConfig();
//
//				clientConfig.getFeatures().put(
//						JSONConfiguration.FEATURE_POJO_MAPPING, Boolean.TRUE);
//
//				Client client = Client.create(clientConfig);
//
//				WebResource webResource = client
//						.resource("http://localhost:1921/Citas.svc/Citas");
//				
//				ClientResponse resp = null;
//				
//				if(id.equals("")||id.equals("0")){
//					
//					 resp = webResource.accept("application/json")
//							.type("application/json").post(ClientResponse.class, beanCita);
//
//				
//				}else{
//					
//					
//					 resp = webResource.accept("application/json")
//							.type("application/json").put(ClientResponse.class, beanCita);
//
//			
//				}
//				
//				if (resp.getStatus() != 200) {					
//					observacion=resp.getEntity(Observacion.class).getMensajeError();
//					mensaje="3";
//					output=beanCita;
//				}else{
//					output = resp.getEntity(Cita.class);
//					if(output.getIdCita()==-1)
//						mensaje="1";
//					else
//						mensaje="2";
//				}
//
//				
//				
//				
//			} catch (Exception e) {
//				observacion=e.getMessage();
//				mensaje="3";
//				output=beanCita;
//			}
//			
//			
//		 }else if(accion.equals("listadoCitas")){
//			 
//			 List<Cita> listado=null;
//				try {
//					ClientConfig clientConfig = new DefaultClientConfig();
//
//					clientConfig.getFeatures().put(
//							JSONConfiguration.FEATURE_POJO_MAPPING, Boolean.TRUE);
//
//					Client client = Client.create(clientConfig);
//
//					WebResource webResource = client
//							.resource("http://localhost:1921/Citas.svc/Citas");
//
//					listado=webResource.type("application/json").get(new GenericType<List<Cita>>() {});
//							
//					
//					
//				} catch (Exception e) {
//					e.printStackTrace();
//				}
//				
//			
//			 
//		 }
//	
//		request.setAttribute("listadoMedico", lstMedicos);
//		request.setAttribute("lstEspeList", lstEspeList);
//		request.setAttribute("lstHorarios", lstHorarios);
//		request.setAttribute("beanReserva", output);
//		request.setAttribute("mensaje", mensaje);
//		request.setAttribute("obs", observacion);
//		request.setAttribute("codigoHidden", codigoHidden);
//		
//		RequestDispatcher rd = request.getRequestDispatcher(pages);
//		rd.forward(request, response);
//	}
//	
//	
//	
//    private List<Especialidad> listarEspecialidades(){
//		
//		List<Especialidad> listado=null;
//		try {
//			ClientConfig clientConfig = new DefaultClientConfig();
//
//			clientConfig.getFeatures().put(
//					JSONConfiguration.FEATURE_POJO_MAPPING, Boolean.TRUE);
//
//			Client client = Client.create(clientConfig);
//
//			WebResource webResource = client
//					.resource("http://localhost:1921/Especialidades.svc/Especialidades");
//
//			 listado=webResource.type("application/json").get(new GenericType<List<Especialidad>>() {});
//					
//			
//			
//		} catch (Exception e) {
//			e.printStackTrace();
//		}
//		
//		return listado;
//	}
//    
//    private List<Horario> listarHorarios(){
//		
//		List<Horario> listado=null;
//		try {
//			ClientConfig clientConfig = new DefaultClientConfig();
//
//			clientConfig.getFeatures().put(
//					JSONConfiguration.FEATURE_POJO_MAPPING, Boolean.TRUE);
//
//			Client client = Client.create(clientConfig);
//
//			WebResource webResource = client
//					.resource("http://localhost:1921/Horarios.svc/Horarios");
//
//			 listado=webResource.type("application/json").get(new GenericType<List<Horario>>() {});
//					
//			
//			
//		} catch (Exception e) {
//			e.printStackTrace();
//		}
//		
//		return listado;
//	}
//    
//    private List<Medico> listarMedicosXEspecialidades(HttpServletRequest request, HttpServletResponse response,int i){
//		
//		List<Medico> listado=null;
//		try {
//			ClientConfig clientConfig = new DefaultClientConfig();
//
//			clientConfig.getFeatures().put(
//					JSONConfiguration.FEATURE_POJO_MAPPING, Boolean.TRUE);
//
//			Client client = Client.create(clientConfig);
//
//			WebResource webResource = client
//					.resource("http://localhost:1921/Medicos.svc/Medicos?Especialidades="+i);
//
//			 listado=webResource.type("application/json").get(new GenericType<List<Medico>>() {});
//					
//			
//			
//		} catch (Exception e) {
//			e.printStackTrace();
//		}
//		
//		return listado;
//	}

}
