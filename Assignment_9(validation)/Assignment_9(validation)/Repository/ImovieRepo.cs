using Assignment_9_validation_.Model;

namespace Assignment_9_validation_.Repository
{
    public interface ImovieRepo
    {
        public void AddMovie(Movie mvie);
        public List<Movie> GetAllMovies();

        public Movie GetMovieByName(string MovName);
        public Movie GetMoviesByActor(string AtName);

        public List<Movie> GetMoviesByReleaseYear(int RlsDate);
        public Movie GetMoviesByDirector(string DirName);
    }
}
