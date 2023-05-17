using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMoviesDatabase.Models;

namespace MVCMoviesDatabase.Data
{
    public class MVCMoviesDatabaseContext : DbContext
    {
        public MVCMoviesDatabaseContext (DbContextOptions<MVCMoviesDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<MVCMoviesDatabase.Models.Movies> Movies { get; set; } = default!;
    }
}
