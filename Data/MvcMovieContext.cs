using Microsoft.EntityFrameworkCore;
using myMvc.Models;
using Microsoft.AspNetCore;
using System.Linq;
namespace myMvc.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}