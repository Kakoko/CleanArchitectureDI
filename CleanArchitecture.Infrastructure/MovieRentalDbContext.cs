using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure
{
    public class MovieRentalDbContext : DbContext, IMovieRentalDbContext
    {

        public MovieRentalDbContext(DbContextOptions<MovieRentalDbContext> options)
            :base(options)
        {

        }
        public DbSet<Movie> Movies { get ; set ; }
    }
}
