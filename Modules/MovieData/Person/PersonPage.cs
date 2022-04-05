using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace MovieDB.MovieData.Pages
{

    [PageAuthorize(typeof(PersonRow))]
    public class PersonController : Controller
    {
        [Route("MovieData/Person")]
        public ActionResult Index()
        {
            return View("~/Modules/MovieData/Person/PersonIndex.cshtml");
        }
    }
}