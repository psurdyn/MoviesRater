using MoviesRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRater.ViewModels
{
    public class MovieRatingVM
    {
        public MovieModel Movie { get; set; }
        public List<MovieRatingModel> Rating { get; set; }
    }
}
