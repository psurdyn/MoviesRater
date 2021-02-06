using Microsoft.EntityFrameworkCore;
using MoviesRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRater.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        DbSet<MovieRatingModel> MovieRatings { get; set; }
        DbSet<RatingModel> Ratings { get; set; }

    }
}
