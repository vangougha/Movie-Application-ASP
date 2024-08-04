using System.ComponentModel.DataAnnotations;

namespace Filmler_ve_Filimler.Models
{
    public class MovieViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Movie name is required")]
        public string MovieName { get; set; }
        [Required(ErrorMessage = "Your rating for the movie is required")]
        [Range(1, 10, ErrorMessage = "Movie Degree must be between 1 and 10.")]
        public int MovieDegree { get; set; }

    }
}
