using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using myMvc.Data;

using Microsoft.EntityFrameworkCore;
using System.Text;

namespace myMvc.Controllers
{
    public class MoviesController : Controller
    {
        
        private readonly MvcMovieContext _context;
        public MoviesController(MvcMovieContext context){
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movie.ToListAsync());
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