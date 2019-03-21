using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LdsMovies.Models
{
    public class LdsMoviesContext : DbContext
    {
        public LdsMoviesContext (DbContextOptions<LdsMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<LdsMovies.Models.Movie> Movie { get; set; }
    }
}
