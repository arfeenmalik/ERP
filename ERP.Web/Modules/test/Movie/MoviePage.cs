
namespace ERP.test.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.MovieRow))]
    public class MovieController : Controller
    {
        [Route("test/Movie")]
        public ActionResult Index()
        {
            return View("~/Modules/test/Movie/MovieIndex.cshtml");
        }
    }
}