using MoviesRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRater.HttpMovies
{
    public interface IHttpMoviesClient
    {
        public Task<IList<MovieModel>> GetAll();
        public Task<MovieModel> GetMovieById(int id);
    }
}
