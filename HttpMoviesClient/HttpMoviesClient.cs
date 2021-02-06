using MoviesRater.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoviesRater.HttpMovies
{
    public class HttpMoviesClient : IHttpMoviesClient
    {
        private HttpClient _httpClient;
        private readonly string BasicUrlAddress = "https://swapi.dev/api/films/";

        public HttpMoviesClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IList<MovieModel>> GetAll()
        {
            var httpResponse = await _httpClient.GetAsync(BasicUrlAddress);
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            var allMovies = JsonConvert.DeserializeObject<ResultsModel>(stringResponse)?.Movies;

            return allMovies;
        }

        public async Task<MovieModel> GetMovieById(int id)
        {
            var httpResponse = await _httpClient.GetAsync($"{BasicUrlAddress}{id}/");
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            var movie = JsonConvert.DeserializeObject<MovieModel>(stringResponse);

            return movie;
        }
    }
}
