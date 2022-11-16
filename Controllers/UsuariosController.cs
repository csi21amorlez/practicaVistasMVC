using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemploMVC_vistas.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListaUsuarios()
        {
            List<string> listUsuarios = new List<string>();
            listUsuarios.Add("Fernando");
            listUsuarios.Add("Gustavo");
            listUsuarios.Add("Carlos");
            listUsuarios.Add("Alfredo");
            listUsuarios.Add("Felipe");
            listUsuarios.Add("Roman");
            listUsuarios.Add("Ricardo");

            //ViewBag.ListaUsuarios = listaUsuarios
            //TempData["ListaUsuarios"] = listUsuarios         
            Session["ListaUsuarios"] = listUsuarios;
            //ViewData["ListaUsuarios"] = listUsuarios; Para evitar el fallo vamos a usar session



            return View(listUsuarios);

        }

        [HttpPost]
        public ActionResult ListaUsuarios(string selUsuarios)
        {
            ViewBag.Usuarios = selUsuarios;
            //List<string> listaUsuarios = ViewBag.ListaUsuarios;
            //List<string> listaUsuarios = (List<string>)TempData["ListaUsuarios"];
            List<string> listaUsuarios = (List<string>)Session["ListaUsuarios"];
            //List<string> listaUsuarios = (List<string>)ViewData["ListaUsuarios"];
            return View(listaUsuarios);

        }
    }
}