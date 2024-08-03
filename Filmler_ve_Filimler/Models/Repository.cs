namespace Filmler_ve_Filimler.Models
{
    public class Repository
    {
        private static List<MovieViewModel> movieViewModels = new();
        public static IEnumerable<MovieViewModel> Movies => movieViewModels;
        public static void Add(MovieViewModel movieViewModel)
        {
            movieViewModels.Add(movieViewModel);
        }
    }
}
