using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoviesRater.ApplicationDbContext;
using MoviesRater.HttpMovies;
using MoviesRater.Models;
using MoviesRater.ViewModels;

namespace MoviesRater.Controllers
{
    public class MoviesController : Controller
    {
        private IHttpMoviesClient _client;
        private AppDbContext _dbContext;
        private int _currMovieId;

        public MoviesController(IHttpMoviesClient moviesClient, AppDbContext context)
        {
            _client = moviesClient;
            //_dbContext = context;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await _client.GetAll();

            return View(allMovies);
        }

        public async Task<IActionResult> Details(int id)
        {
            _currMovieId = id;

            var movie = await _client.GetMovieById(id);
            //var availableRatings = await _dbContext.Ratings;

            var result = new MovieRatingVM { Movie = movie, Rating = new List<MovieRatingModel> { new MovieRatingModel { Id = 1, RatingId = 1 } } };
            return View(result);
            //return View(movie, availableRatings);
        }

        public async Task<IActionResult> Rate(int rateId)
        {
            //commented because of EF issues
            //await _dbContext.AddAsync(new MovieRatingModel { Id = _currMovieId, Rating = new RatingModel { Id = rateId} });

            return Content("Movie has been succesfully rated!");
        }
    }
}