using System.ComponentModel.DataAnnotations;

namespace Filmler_ve_Filimler.Models
{
    public class MovieViewModel
    {
        [Required(ErrorMessage = "Movie name is required")]
        public string MovieName { get; set; }
        [Required(ErrorMessage = "Your rating for the movie is required")]
        public int MovieDegree { get; set; }

    }
}
