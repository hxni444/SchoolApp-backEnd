using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment_9_validation_.Model;
using Assignment_9_validation_.Repository;

namespace Assignment_9_validation_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieCollectionController : ControllerBase
    {
        MovieRepo obj;
        public MovieCollectionController(MovieRepo obj)
        {
            this.obj = obj; 
        }

        [HttpGet("Get mov by movie/{movie}")]
        public IActionResult GetMbyName(string movie) 
        {
           
            return StatusCode(200, obj.GetMovieByName(movie));
        }
        [HttpPost("Add Movie")]
        public IActionResult AddMOvie(Movie movie )
        {
            if (ModelState.IsValid)
            {
                obj.AddMovie(movie);
                return Ok(obj);
            }
            else
            {
                return BadRequest();
            }
                

        }
        [HttpGet("Get ALL")]
        public IActionResult Getall()
        {
            List<Movie> list = obj.GetAllMovies();
            return Ok(list);
           
        }
        [HttpGet("Get movie BY Director/{DirName}")]
        public IActionResult GetMovDiec(string DirName) 
        {
            return Ok(obj.GetMoviesByDirector(DirName));
        }

        [HttpGet("get Mov BY YEar/{RlsDate}")]
        public IActionResult GetMovYr(int RlsDate)
        {
            return Ok(obj.GetMoviesByReleaseYear(RlsDate));
        }

        [HttpGet("get Mov By Acro/{(ActName}")]
        public IActionResult GetMovAct(string ActName) 
        {
            return Ok(obj.GetMoviesByActor(ActName));
        }
    }
}
