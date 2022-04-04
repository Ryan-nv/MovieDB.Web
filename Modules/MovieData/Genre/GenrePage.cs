using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace MovieDB.MovieData.Pages
{

    [PageAuthorize(typeof(GenreRow))]
    public class GenreController : Controller
    {
        [Route("MovieData/Genre")]
        public ActionResult Index()
        {
            return View("~/Modules/MovieData/Genre/GenreIndex.cshtml");
        }
    }
}