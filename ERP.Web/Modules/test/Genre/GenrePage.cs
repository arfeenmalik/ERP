
namespace ERP.test.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.GenreRow))]
    public class GenreController : Controller
    {
        [Route("test/Genre")]
        public ActionResult Index()
        {
            return View("~/Modules/test/Genre/GenreIndex.cshtml");
        }
    }
}