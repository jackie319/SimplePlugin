using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SimplePlugin.SimpleMvcPlugin.Controllers
{
    public class SimpleMvcPluginController:Controller
    {
        public ActionResult Index()
        {
            return View("~/Plugins/SimpleMvcPlugin/Views/SimpleMvcPlugin/Index.cshtml");
        }
    }
}
