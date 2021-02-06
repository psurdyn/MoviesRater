using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRater.Models
{
    [Table("Ratings", Schema = "dbo")]
    public class MovieRatingModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public RatingModel Rating { get; set; }
        [ForeignKey("Rating")]
        public int RatingId { get; set; }
    }
}
