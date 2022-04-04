using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace MovieDB.MovieData.Pages
{

    [PageAuthorize(typeof(MovieRow))]
    public class MovieController : Controller
    {
        [Route("MovieData/Movie")]
        public ActionResult Index()
        {
            return View("~/Modules/MovieData/Movie/MovieIndex.cshtml");
        }
    }
}