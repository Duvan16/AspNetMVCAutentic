using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCAutentic.Controllers
{
    [Authorize(Users = "dd@gmal.xom")]
    public class AccesoController : Controller
    {
        //[Authorize]
        public ContentResult Privado()
        {
            return Content("Esta parte de la web es PRIVADA");
        }

        [AllowAnonymous]
        public ContentResult Publico()
        {
            return Content("Esta parte de la web es PUBLICA");
        }
        // GET: Acceso
        public ActionResult Index()
        {
            return View();
        }
    }
}