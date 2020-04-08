
namespace ERP.test.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.PersonRow))]
    public class PersonController : Controller
    {
        [Route("test/Person")]
        public ActionResult Index()
        {
            return View("~/Modules/test/Person/PersonIndex.cshtml");
        }
    }
}