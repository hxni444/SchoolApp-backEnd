using System.ComponentModel.DataAnnotations;

namespace Assignment_9_validation_.Model
{
    public class Movie
    {
        [Required(ErrorMessage ="Id Required")]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Moviw  Name Required")]
        public string MovieName {  get; set; }
  
        public string  Lang { get; set; }

        [Required(ErrorMessage = "Act Required")]
        public string Actor { get; set; }

        [Required(ErrorMessage = "Director Name Required")]
        public string Director { get; set; }

        [Required(ErrorMessage = "yeR Required")]
        public int ReleaseYear { get; set; }
    }
}
