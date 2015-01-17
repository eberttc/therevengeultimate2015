using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EYESsuite.Controllers
{
    public class PacienteController : Controller
    {
        //
        // GET: /Paciente/



        [HttpGet]
        public ActionResult Registrar()
        {
            ViewBag.flagExito = false;
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(String viewmodel="asd")
        {
            ViewBag.flagExito = true;
            return View();
        }
        
        public ActionResult Index()
        {

            
            return View();
        }
    }
}
