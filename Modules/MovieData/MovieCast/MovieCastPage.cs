using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace MovieDB.MovieData.Pages
{

    [PageAuthorize(typeof(MovieCastRow))]
    public class MovieCastController : Controller
    {
        [Route("MovieData/MovieCast")]
        public ActionResult Index()
        {
            return View("~/Modules/MovieData/MovieCast/MovieCastIndex.cshtml");
        }
    }
}