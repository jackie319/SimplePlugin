using SimplePlugin.PluginCore;
using System.Web.Mvc;

namespace SimplePlugin.Web.Controllers
{
    public class PluginController : Controller
    {
        public ActionResult Index()
        {
            return Content("Total "+PluginManager.PluginTypes.Count.ToString()+" Plugins");
        }

        public ActionResult Install()
        {
            PluginManager.ReStart();
            return RedirectToAction("Index");
        }
    }
}