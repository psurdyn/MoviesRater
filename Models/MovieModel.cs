using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRater.Models
{
    public class MovieModel
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("opening_crawl")]
        public string OpeningCrawl { get; set; }
        [JsonProperty("director")]
        public string Director { get; set; }
        [JsonProperty("producer")]
        public string Producer { get; set; }
        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }
    }

    public class ResultsModel
    {
        [JsonProperty("results")]
        public List<MovieModel> Movies { get; set; }
    }
}
