using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace lbite_final.Controllers
{
    public class AutenticationController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
            
        }

        [HttpPost]
        public ActionResult Login()
        {
            string User = Request.Form["user"];
            string Password = Request.Form["password"];
            
            if (User.Length >= 5 && Password.Length >= 5)
            {
                return View("Index");
            }
            else
            {
                if (User.Length < 5) ViewBag.ErrorUsuario = "El ususario debe tener minimo 5 caracteres";   
                
                if (Password.Length < 5) ViewBag.ErrorPassword = "El password debe tener minimo 5 caracteres";
                

                return View("Index");
            }

            
        }
    }
}