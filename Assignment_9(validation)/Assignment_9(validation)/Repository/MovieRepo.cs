using Assignment_9_validation_.Model;

namespace Assignment_9_validation_.Repository
{
    public class MovieRepo : ImovieRepo
    {
        List<Movie> movie_List = new List<Movie>()
        {
            new Movie(){MovieId=456,Actor="Hani",Director="Prithwi",MovieName="RollBack",Lang="malayalm",ReleaseYear= 2024},
            new Movie(){MovieId=221,Actor="Jaya",Director="unni k",MovieName="Namma",Lang="malayalm",ReleaseYear= 2023}
            
        };
        public void AddMovie(Movie mvie)
        {
            
            movie_List.Add(mvie);
            
        }

        public List<Movie> GetAllMovies()
        {
            return movie_List;
        }

        public Movie GetMovieByName(string MovName)
        {
           // k.MovieName == MovName
            //List <Movie> MovNameList = new List<Movie> ();
            foreach (var k in movie_List)
            {
                if (string.Equals(k.MovieName, MovName))
                {
                    return k;
                }
               
            }
            return null;
           
        }

        public Movie GetMoviesByActor(string ActName)
        {
            foreach (var k in movie_List)
            {
                if (k.Actor == ActName)
                {
                    return k;
                }

            }
            return null;

        }

        public Movie GetMoviesByDirector(string DirName)
        {
            foreach (var k in movie_List)
            {
                if (k.Director == DirName)
                {
                    return k;
                }

            }
            return null;

        }

        public List< Movie> GetMoviesByReleaseYear(int RlsDate)

        {
            List<Movie> movie_yr = new List<Movie>();
            foreach (var k in movie_List)
            {
                if (k.ReleaseYear == RlsDate)
                {
                   movie_yr.Add(k);
                }
                

            }
            return movie_yr;


        }
    }
}
