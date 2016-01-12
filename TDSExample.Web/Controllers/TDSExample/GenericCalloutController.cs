using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;

namespace TDSExample.Web.Controllers.TDSExample
{
    public class GenericCalloutController : GlassController
    {
        // GET: GenericCallout
        public ActionResult Default()
        {
            return View("~/Views/TDSExample/Renderings/GenericCallout.cshtml");
        }
    }
}