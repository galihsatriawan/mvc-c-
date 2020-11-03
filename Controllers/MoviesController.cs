using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using myMvc.Data;

namespace myMvc.Controllers
{
    public class MoviesController : Controller
    {
        
        private readonly MvcMovieContext _context;
        public MoviesController(MvcMovieContext context){
            _context = context;
        }
        public IActionResult Index()
        {
            ViewData["title"] = "My Movie";
            ViewData["number"] = 5;
            ViewData["movies"] = "Dummy";
            return View();
        }
        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
    }
}